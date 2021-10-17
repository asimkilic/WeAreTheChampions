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

namespace FormUI.Forms
{
    public partial class FrmMatches : Form
    {
        private IMatchService _matchService;
        public FrmMatches()
        {
            InitializeComponent();
            _matchService = InstanceFactory.GetInstance<IMatchService>();
        }

        private void FrmMatches_Load(object sender, EventArgs e)
        {
            var matches = _matchService.GetAllWithAssociatedProperties();
            dgvMatches.DataSource = matches.Data;
        }

        private void btnNewMatch_Click(object sender, EventArgs e)
        {
            var newMatch = new Match
            {
                MatchTime = DateTime.Now,
                AwayTeamId = 4,
                HomeTeamId = 6
            };
            var newMatch2 = new Match
            {
                MatchTime = DateTime.Now.AddDays(10),
                AwayTeamId = 12,
                HomeTeamId = 3
            };

            var result1=_matchService.Add(newMatch);
            var result2=_matchService.Add(newMatch2);

            if(result1.Success)
            {
                MessageBox.Show("1 çalıştı");
                dgvMatches.DataSource = _matchService.GetAllWithAssociatedProperties().Data;
            }
           // if (result2.Success)
            {
                MessageBox.Show("2 çalıştı");
                dgvMatches.DataSource = null;
                dgvMatches.DataSource = _matchService.GetAllWithAssociatedProperties().Data;
            }

        }
    }
}
