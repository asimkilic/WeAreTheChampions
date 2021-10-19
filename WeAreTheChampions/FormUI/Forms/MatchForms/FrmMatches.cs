using Business.Abstract;
using Business.DependencyResolvers.Autofac;
using Entities.Concrete;
using Entities.DTOs;
using FormUI.Forms.MatchForms;
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

            FrmNewMatch frmNewMatch = new FrmNewMatch();
            this.Hide();
            frmNewMatch.ShowDialog();
            ListAllMatches();
            this.Show();
        }

        private void ListAllMatchesWithoutPlayed()
        {

            dgvMatches.DataSource = _matchService.GetAllWithAssociatedPropertiesWithoutPlayed().Data;

        }
        private void ListAllMatches()
        {
            cbxHidePlayedMatches.Checked = false;
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
            if (dgvMatches.SelectedRows.Count != 1)
            {
                return;
            }
            EditMatch(((MatchesListDto)dgvMatches.SelectedRows[0].DataBoundItem).MatchId);

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

        private void btnEditMatch_Click(object sender, EventArgs e)
        {
            if (dgvMatches.SelectedRows.Count != 1)
            {
                return;
            }
            EditMatch(((MatchesListDto)dgvMatches.SelectedRows[0].DataBoundItem).MatchId);

        }

        private void EditMatch(int matchId)
        {
            FrmMatchEdit frmMatchEdit = new FrmMatchEdit(matchId);
            this.Hide();
            frmMatchEdit.ShowDialog();
            ListAllMatches();
            this.Show();

        }

    }
}
