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
    public partial class FrmTeams : Form
    {
        private readonly ITeamService _teamService;
        private readonly IPlayerService _playerService;
        public FrmTeams()
        {
            InitializeComponent();
            _teamService = InstanceFactory.GetInstance<ITeamService>();
            _playerService = InstanceFactory.GetInstance<IPlayerService>();

            PropertyChanges();
            ListAllTeams();
        }

        private void FrmTeams_Load(object sender, EventArgs e)
        {

        }
        private void PropertyChanges()
        {
            dgvTeams.AutoGenerateColumns = false;
            dgvPlayers.AutoGenerateColumns = false;
        }
        private void ListAllTeams()
        {
            var teams = _teamService.GetAll().Data;
            dgvTeams.DataSource = teams;
        }

        private void dgvTeams_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTeams.SelectedRows.Count != 1) return;
            ListTeamPlayers(((Team)dgvTeams.SelectedRows[0].DataBoundItem).Id);
        }

        private void ListTeamPlayers(int teamId)
        {
            dgvPlayers.DataSource = _playerService.GetPlayersByTeamId(teamId).Data;
        }

        private void btnNewTeam_Click(object sender, EventArgs e)
        {
            FrmNewTeam frmNewTeam = new FrmNewTeam();
            this.Hide();
            frmNewTeam.ShowDialog();
            ListAllTeams();
            this.Show();
        }
    }
}
