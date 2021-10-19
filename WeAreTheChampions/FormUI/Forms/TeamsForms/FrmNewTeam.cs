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

        private bool isValidTeamName = true;
        public FrmNewTeam()
        {
            InitializeComponent();
            // Get Service Instances
            _teamService = InstanceFactory.GetInstance<ITeamService>();
            _playerService = InstanceFactory.GetInstance<IPlayerService>();
            _colorService = InstanceFactory.GetInstance<IColorService>();


            GetTeamList();
        }
        private void FrmNewTeam_Load(object sender, EventArgs e)
        {
            panelNewTeam.BringToFront();
        }
        private void GetTeamList()
        {
            AllTeams = _teamService.GetAll().Data;
        }
        private void GetColorList()
        {
            AllColors = _colorService.GetAll().Data;

        }
        private void GetPlayerList()
        {

            AllPlayers = _playerService.GetAll().Data;

        }
        #region CreateTeam
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
            var result = _teamService.Add(team);
            if (result.Success)
            {
                GetColorList();
                GetColorSectionActive();
            }
            else
            {
                MessageBox.Show("Bir hata oluştu. Lütfen tekrar deneyiniz.");
            }
        }

        #endregion

        #region Create and Select Color
        private void GetColorSectionActive()
        {
            lblCreateTeam.BackColor = System.Drawing.Color.FromArgb(31, 31, 31);
            lblCreateTeam.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            lblColors.BackColor=System.Drawing.Color.FromArgb(243, 124, 105);
            lblColors.ForeColor = System.Drawing.SystemColors.ButtonFace;
            panelColors.BringToFront();
        }

        #endregion

      
    }
}
