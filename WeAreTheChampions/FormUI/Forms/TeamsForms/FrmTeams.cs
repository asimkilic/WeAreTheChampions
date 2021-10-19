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
        }
        private void ListAllTeams()
        {
            var teams = _teamService.GetAll().Data;
            dgvTeams.DataSource = teams;
        }
        private void GetAllPlayers()
        {
            
        }
    }
}
