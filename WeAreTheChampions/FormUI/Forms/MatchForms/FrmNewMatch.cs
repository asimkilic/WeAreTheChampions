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
        }

        private void FrmNewMatch_Load(object sender, EventArgs e)
        {
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
    }
}
