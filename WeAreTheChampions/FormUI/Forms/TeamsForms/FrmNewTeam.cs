using Business.Abstract;
using Business.DependencyResolvers.Autofac;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI.Forms.TeamsForms
{
    public partial class FrmNewTeam : Form
    {
        // Services
        private readonly IColorService _colorService;
        private readonly IPlayerService _playerService;
        private readonly ITeamService _teamService;

        // Lists
        private List<Entities.Concrete.Color> AllColors;
        private List<Player> AllPlayers;
        private List<Team> AllTeams;

        private readonly Team newTeam;

        private bool isValidTeamName = true;
        public FrmNewTeam()
        {
            InitializeComponent();
            PropertyChanges();
            // Get Service Instances
            _teamService = InstanceFactory.GetInstance<ITeamService>();
            _playerService = InstanceFactory.GetInstance<IPlayerService>();
            _colorService = InstanceFactory.GetInstance<IColorService>();


            GetTeamList();
        }
        private void PropertyChanges()
        {
            dgvColors.AutoGenerateColumns = false;
            dgvTeamColors.AutoGenerateColumns = false;
        }
        private void FrmNewTeam_Load(object sender, EventArgs e)
        {
            panelNewTeam.BringToFront();
        }



        #region CreateTeam
        private void GetTeamList()
        {
            AllTeams = _teamService.GetAll().Data;
        }
        private void txtTeamName_TextChanged(object sender, EventArgs e)
        {
            if (txtTeamName.Text == string.Empty)
            {
                lblValidateTeamName.Visible = false;
                return;
            }
            if (AllTeams.Any(x => x.TeamName.ToLower() == txtTeamName.Text.ToLower()))
                InvalidTeamName();
            else
                ValidTeamName();
        }

        private void InvalidTeamName()
        {
            isValidTeamName = false;
            lblValidateTeamName.Text = "Bu takım adı daha önce alınmış.";
            lblValidateTeamName.ForeColor = System.Drawing.Color.Red;
            lblValidateTeamName.Visible = true;
            btnNextToColors.Enabled = false;
        }
        private void ValidTeamName()
        {
            isValidTeamName = true;
            lblValidateTeamName.Text = "Bu takım adı kullanılabilir.";
            lblValidateTeamName.ForeColor = System.Drawing.Color.Green;
            lblValidateTeamName.Visible = true;
            btnNextToColors.Enabled = true;


        }
        private void btnNextToColors_Click(object sender, EventArgs e)
        {
            Team team = new Team() { TeamName = txtTeamName.Text };
            // var result = _teamService.Add(team);

            if (true) //result.Success
            {
                //newTeam=_teamService.
                GetColorSectionActive();
            }
            else
            {
                MessageBox.Show("Bir hata oluştu. Lütfen tekrar deneyiniz.");
            }
        }

        #endregion

        #region Create and Select Color
        private void GetColorList()
        {
            AllColors = _colorService.GetAll().Data;
            dgvColors.DataSource = AllColors;

        }
        private void GetColorSectionActive()
        {
            GetColorList();
            lblToolTipColors.Visible = true;
            lblCreateTeam.BackColor = System.Drawing.Color.FromArgb(31, 31, 31);
            lblCreateTeam.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            lblColors.BackColor = System.Drawing.Color.FromArgb(243, 124, 105);
            lblColors.ForeColor = System.Drawing.SystemColors.ButtonFace;
            panelColors.BringToFront();
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
                    MessageBox.Show("Bir hata oluştu. Lütfen tekrar deneyiniz.");
            }

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
        private void CheckKeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)8)
            { }
            else
            {
                e.Handled = true;
            }
        }
        private void dgvColors_DoubleClick(object sender, EventArgs e)
        {
            if (dgvColors.SelectedRows.Count != 1) return;
            var colorId =((Entities.Concrete.Color)dgvColors.SelectedRows[0].DataBoundItem).Id;

        }
        #endregion

        #region Select Player
        private void GetPlayerList()
        {

            AllPlayers = _playerService.GetAll().Data;

        }

        #endregion


    }
}
