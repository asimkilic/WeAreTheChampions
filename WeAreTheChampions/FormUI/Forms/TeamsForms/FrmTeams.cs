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
            lblWelcome.Text = KLCCache.KLCCacheManager.NameSurname;
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

            frmNewTeam.ShowDialog();
            ListAllTeams();

        }

        private void btnDeleteSelectedTeam_Click(object sender, EventArgs e)
        {
            if (dgvTeams.SelectedRows.Count == 1)
            {
                DeleteTeam();
            }
        }
        private void dgvTeams_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvTeams.SelectedRows.Count == 1 && e.KeyCode == Keys.Delete)
            {
                DeleteTeam();
            }
        }
        private void DeleteTeam()
        {
            var deletedTeam = (Team)dgvTeams.SelectedRows[0].DataBoundItem;
            var result = _teamService.DeleteTeamAndSetPlayerTeamsNull(deletedTeam.Id);
            if (result.Success)
            {
                MessageBox.Show("Takım silindi, takıma ait oyuncular artık herhangi bir takıma ait değiller.");
            }
            else
                MessageBox.Show("Bir sorun oluştu. Lütfen tekrar deneyin.");
            ListAllTeams();
        }

        private void btnDeleteSelectedPlayer_Click(object sender, EventArgs e)
        {
            if (dgvPlayers.SelectedRows.Count == 1)
            {
                DeletePlayer();
            }
        }
        private void DeletePlayer()
        {

            var deletedPlayer = (Player)dgvPlayers.SelectedRows[0].DataBoundItem;
            var result = _playerService.Delete(deletedPlayer);
            if (!result.Success)
                MessageBox.Show(result.Message == null ? "Bir hata oluştu. Lütfen tekrar deneyiniz" : result.Message);
            else
                MessageBox.Show("Oyuncu başarıyla silindi");
            ListAllTeams();



        }

        private void dgvPlayers_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvPlayers.SelectedRows.Count == 1 && e.KeyCode == Keys.Delete)
            {
                DeletePlayer();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
