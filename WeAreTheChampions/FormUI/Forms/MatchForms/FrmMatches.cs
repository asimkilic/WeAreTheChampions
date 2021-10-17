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

namespace FormUI.Forms
{
    public partial class FrmMatches : Form
    {
        private IMatchService _matchService;
        public FrmMatches()
        {
            InitializeComponent();
            dgvMatches.AutoGenerateColumns = false;
            _matchService = InstanceFactory.GetInstance<IMatchService>();
        }

        private void FrmMatches_Load(object sender, EventArgs e)
        {
            ListAllMatches();
        }

        private void btnNewMatch_Click(object sender, EventArgs e)
        {
            //var newMatch = new Match
            //{
            //    MatchTime = DateTime.Now,
            //    AwayTeamId = 4,
            //    HomeTeamId = 6
            //};
            //var newMatch2 = new Match
            //{
            //    MatchTime = DateTime.Now.AddDays(10),
            //    AwayTeamId = 12,
            //    HomeTeamId = 3
            //};


        }

        private void ListAllMatchesWithoutPlayed()
        {
            var a= _matchService.GetAllWithAssociatedPropertiesWithoutPlayed().Data;
            dgvMatches.DataSource = a;
        }
        private void ListAllMatches()
        {
            dgvMatches.DataSource = _matchService.GetAllWithAssociatedProperties().Data;
        }

        private void DeleteMatch(int matchId)
        {
            var result = _matchService.DeleteById(matchId);
            if (result.Success)
            {
                MessageBox.Show("Maç başarıyla silindi.");
                ListAllMatches();
            }
        }
        private void btnDeleteMatch_Click(object sender, EventArgs e)
        {
            if (dgvMatches.SelectedRows.Count != 1)
            {
                return;
            }
            DeleteMatch(((MatchesListDto)dgvMatches.SelectedRows[0].DataBoundItem).MatchId);

        }

        private void dgvMatches_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvMatches.SelectedRows.Count != 1 || e.KeyCode != Keys.Delete)
            {
                return;
            }
            DeleteMatch(((MatchesListDto)dgvMatches.SelectedRows[0].DataBoundItem).MatchId);

        }

        private void dgvMatches_DoubleClick(object sender, EventArgs e)
        {

        }

        private void cbxHidePlayedMatches_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHidePlayedMatches.Checked)
            {
                ListAllMatchesWithoutPlayed();
            }
            else
            {
                ListAllMatches();
            }
        }
    }
}
