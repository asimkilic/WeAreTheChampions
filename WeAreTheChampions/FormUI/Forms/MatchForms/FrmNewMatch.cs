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

namespace FormUI.Forms.MatchForms
{
    public partial class FrmNewMatch : Form
    {
        private readonly IMatchService _matchService;
        private readonly ITeamService _teamService;
        private List<Team> AllTeams;
        public FrmNewMatch()
        {
            InitializeComponent();
            _matchService = InstanceFactory.GetInstance<IMatchService>();
            _teamService = InstanceFactory.GetInstance<ITeamService>();
            PropertyChanges();
            GetAllTeams();
           
        }

        private void PropertyChanges()
        {
            dgvAwayTeam.AutoGenerateColumns = false;
            dgvHomeTeam.AutoGenerateColumns = false;
            lblTodaysDate.Text = DateTime.Now.ToShortDateString();
        }

        private void FrmNewMatch_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = KLCCache.KLCCacheManager.NameSurname;
            BindHomeTeam();
            BindAwayTeam();
        }

        private void GetAllTeams()
        {
            AllTeams = _teamService.GetAll().Data;
        }
        private void BindHomeTeam()
        {
            dgvHomeTeam.DataSource = AllTeams;
        }
        private void BindAwayTeam()
        {
            if (dgvHomeTeam.SelectedRows.Count != 1)
                dgvAwayTeam.DataSource = null;
            else
                dgvAwayTeam.DataSource = AllTeams.Where(x => x != (Team)dgvHomeTeam.SelectedRows[0].DataBoundItem).ToList();
        }

        private void dgvHomeTeam_SelectionChanged(object sender, EventArgs e)
        {
            BindAwayTeam();
        }

        private void btnSaveMatch_Click(object sender, EventArgs e)
        {
            if (dgvHomeTeam.SelectedRows.Count != 1 && dgvAwayTeam.SelectedRows.Count != 1) return;
            FillNewMatch(out Match newMatch);
            var result = _matchService.Add(newMatch);
            if (result.Success)
                SuccessMessage();
            else
                ErrorMessage();
        }

        private void FillNewMatch(out Match newMatch)
        {
            newMatch = new Match
            {
                AwayTeamId = ((Team)dgvAwayTeam.SelectedRows[0].DataBoundItem).Id,
                HomeTeamId = ((Team)dgvHomeTeam.SelectedRows[0].DataBoundItem).Id,
                MatchTime = new DateTime(dtpMatchDate.Value.Year, dtpMatchDate.Value.Month, dtpMatchDate.Value.Day, dtpMatchHour.Value.Hour, dtpMatchHour.Value.Minute, dtpMatchHour.Value.Second),
            };
        }

        private void SuccessMessage()
        {
            MessageBox.Show("Maç başarıyla oluşturuldu");
            Close();
        }
        private void ErrorMessage()
        {
            MessageBox.Show("Bir hata oluştu. Tekrar deneyiniz.");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
