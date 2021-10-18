using Business.Abstract;
using Business.DependencyResolvers.Autofac;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI.Forms.MatchForms
{
    public partial class FrmMatchEdit : Form
    {
        private IMatchService _matchService;
        private Match editedMatch;
        private int _matchId;

        public FrmMatchEdit(int matchId)
        {
            InitializeComponent();
            _matchService = InstanceFactory.GetInstance<IMatchService>();
            _matchId = matchId;
            GetMatchDetails();
        }
        private void FrmMatchEdit_Load(object sender, EventArgs e)
        {
            BindDataToForm();
        }
        private void GetMatchDetails()
        {
            editedMatch = _matchService.GetWithHomeAwayDetailsById(_matchId).Data;
        }
        private void BindDataToForm()
        {
            this.Text = editedMatch.HomeTeam.TeamName + " vs " + editedMatch.AwayTeam.TeamName;
            lblHome.Text = editedMatch.HomeTeam.TeamName;
            lblAway.Text = editedMatch.AwayTeam.TeamName;
            txtScoreHome.Text = editedMatch.Score1 != null ? editedMatch.Score1.ToString() : string.Empty;
            txtScoreAway.Text = editedMatch.Score2 != null ? editedMatch.Score2.ToString() : string.Empty;
            dtpDate.Value = editedMatch.MatchTime;
            dtpHour.Value = editedMatch.MatchTime;



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            FillEntity();
            var result = _matchService.Update(editedMatch);
            if (result.Success)
            {
                BindDataToForm();
                MessageBox.Show("Değişiklikler kaydedildi");
                return;
            }
            MessageBox.Show(result.Message != null ? result.Message : "Bir hata oluştu. Bilgileri kontrol ederek tekrar giriniz.");


        }


        private void FillEntity()
        {

            if (byte.TryParse(txtScoreAway.Text, out byte resultAway))
                editedMatch.Score2 = resultAway;
            else
                editedMatch.Score2 = null;

            if (byte.TryParse(txtScoreHome.Text, out byte resultHome))
                editedMatch.Score1 = resultHome;
            else
                editedMatch.Score1 = null;

            editedMatch.MatchTime = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, dtpHour.Value.Hour, dtpHour.Value.Minute, dtpHour.Value.Second);

        }

        private void txtScoreHome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)8)
            { }
            else
            {
                e.Handled = true;
            }


        }

        private void txtScoreAway_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)8)
            { }
            else
            {
                e.Handled = true;
            }
        }
    }
}
