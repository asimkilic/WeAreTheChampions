using Business.Abstract;
using Business.DependencyResolvers.Autofac;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI.Forms.ColorForms
{
    public partial class FrmNewColor : Form
    {
        // Services
        private readonly IColorService _colorService;
        private readonly ITeamColorService _teamColorService;

        // Lists
        private List<Entities.Concrete.Color> AllColors;

        public FrmNewColor()
        {
            InitializeComponent();
            _colorService = InstanceFactory.GetInstance<IColorService>();
            _teamColorService = InstanceFactory.GetInstance<ITeamColorService>();

        }

        private void FrmNewColor_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = KLCCache.KLCCacheManager.NameSurname;
            PropertyChanges();
            GetColorList();
        }
        private void GetColorList()
        {
            AllColors = _colorService.GetAll().Data;
            dgvColors.DataSource = AllColors;

        }
        private void PropertyChanges()
        {
            dgvColors.EnableHeadersVisualStyles = false;
            dgvColors.AutoGenerateColumns = false;

        }
        private Entities.Concrete.Color FillColor()
        {

            if ((!byte.TryParse(txtRed.Text, out byte resultRed)) ||
                (!byte.TryParse(txtGreen.Text, out byte resultGreen)) ||
                (!byte.TryParse(txtBlue.Text, out byte resultBlue)) ||
                (txtColorName.Text.Trim() == string.Empty)
                )
            {
                lblValidateColors.Visible = true;
                return null;
            }
            else
                lblValidateColors.Visible = false;

            return new Entities.Concrete.Color()
            {
                Red = resultRed,
                Green = resultGreen,
                Blue = resultBlue,
                ColorName = txtColorName.Text.Trim()
            };

        }

        private void btnAddNewColor_Click(object sender, EventArgs e)
        {
            var color = FillColor();
            if (color != null)
            {
                var result = _colorService.Add(color);
                if (result.Success)
                {
                    GetColorList();

                }
                else
                    MessageBox.Show(result.Message == null ? "Bir hata oluştu. Lütfen tekrar deneyiniz." : result.Message);
            }
        }
        private void CheckKeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)8)
            { }
            else
            {
                e.Handled = true;
            }
        }

        private void dgvColors_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvColors.SelectedRows.Count == 1 && e.KeyCode == Keys.Delete)
            {
                DialogResult dr = MessageBox.Show("Seçilen renk bir takıma ait olabilir. Yinede silmek istiyor musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No) return;
                var colorId = ((Entities.Concrete.Color)dgvColors.SelectedRows[0].DataBoundItem).Id;
                var result = _teamColorService.DeleteByColorId(colorId);
                if (result.Success)
                {
                    var result2 = _colorService.DeleteById(colorId);
                    if (result2.Success)
                    {
                        MessageBox.Show("Renk ve ilişkili verileri başarıyla silindi.");
                        GetColorList();
                        Clear();
                        return;
                    }
                }

                MessageBox.Show("Bir hata oluştu. Tekrar deneyin");

            }
            else
                return;
        }
        private void Clear()
        {
            txtBlue.Clear();
            txtColorName.Clear();
            txtGreen.Clear();
            txtRed.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
