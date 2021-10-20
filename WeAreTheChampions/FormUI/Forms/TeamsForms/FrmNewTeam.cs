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

namespace FormUI.Forms.TeamsForms
{
    public partial class FrmNewTeam : Form
    {
        // Services
        private readonly IColorService _colorService;
        private readonly IPlayerService _playerService;
        private readonly ITeamService _teamService;
        private readonly ITeamColorService _teamColorService;

        // Lists
        private List<Entities.Concrete.Color> AllColors;
        private List<TeamColorDto> TeamColors;
        private List<Player> AllPlayers;
        private List<Team> AllTeams;
        private List<Player> NewTeamPlayers;

        private Team newTeam;

        private bool isValidTeamName = true;
        public FrmNewTeam()
        {
            InitializeComponent();
            PropertyChanges();
            // Get Service Instances
            _teamService = InstanceFactory.GetInstance<ITeamService>();
            _playerService = InstanceFactory.GetInstance<IPlayerService>();
            _colorService = InstanceFactory.GetInstance<IColorService>();
            _teamColorService = InstanceFactory.GetInstance<ITeamColorService>();


            GetTeamList();
        }
        private void PropertyChanges()
        {
            dgvColors.AutoGenerateColumns = false;
            dgvTeamColors.AutoGenerateColumns = false;
            dgvAllPlayers.AutoGenerateColumns = false;
            dgvPlayersOnTeam.AutoGenerateColumns = false;
        }
        private void FrmNewTeam_Load(object sender, EventArgs e)
        {
            panelNewTeam.BringToFront();
        }



        #region CreateTeam
        private void GetTeamList()
        {
            AllTeams = _teamService.GetAll().Data;
        }
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
                newTeam = _teamService.GetTeamByName(txtTeamName.Text).Data;
                GetColorSectionActive();
            }
            else
            {
                MessageBox.Show("Bir hata oluştu. Lütfen tekrar deneyiniz.");
            }
        }

        #endregion

        #region Create and Select Color
        private void GetColorList()
        {
            AllColors = _colorService.GetAll().Data;
            dgvColors.DataSource = AllColors;

        }
        private void GetTeamColorList()
        {
            TeamColors = _teamColorService.GetAllDetailsWithAssociatedPropertiesByTeamId(newTeam.Id).Data;
            dgvTeamColors.DataSource = TeamColors;
        }
        private void GetColorSectionActive()
        {
            GetColorList();
            lblToolTipColors.Visible = true;
            lblCreateTeam.BackColor = System.Drawing.Color.FromArgb(31, 31, 31);
            lblCreateTeam.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            lblColors.BackColor = System.Drawing.Color.FromArgb(243, 124, 105);
            lblColors.ForeColor = System.Drawing.SystemColors.ButtonFace;
            panelColors.BringToFront();
        }

        private void btnAddNewColor_Click(object sender, EventArgs e)
        {
            var color = FillColor();
            if (color != null)
            {
                var result = _colorService.Add(color);
                if (result.Success)
                {
                    GetColorList();

                }
                else
                    MessageBox.Show(result.Message == null ? "Bir hata oluştu. Lütfen tekrar deneyiniz." : result.Message);
            }

        }
        private Entities.Concrete.Color FillColor()
        {

            if ((!byte.TryParse(txtRed.Text, out byte resultRed)) ||
                (!byte.TryParse(txtGreen.Text, out byte resultGreen)) ||
                (!byte.TryParse(txtBlue.Text, out byte resultBlue)) ||
                (txtColorName.Text.Trim() == string.Empty)
                )
            {
                lblValidateColors.Visible = true;
                return null;
            }
            else
                lblValidateColors.Visible = false;

            return new Entities.Concrete.Color()
            {
                Red = resultRed,
                Green = resultGreen,
                Blue = resultBlue,
                ColorName = txtColorName.Text.Trim()
            };

        }
        private void CheckKeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)8)
            { }
            else
            {
                e.Handled = true;
            }
        }
        private void dgvColors_DoubleClick(object sender, EventArgs e)
        {
            if (dgvColors.SelectedRows.Count != 1) return;
            AddColorToTeam();



        }
        private void AddColorToTeam()
        {
            var colorId = ((Entities.Concrete.Color)dgvColors.SelectedRows[0].DataBoundItem).Id;
            var result = _teamColorService.Add(new TeamColor { ColorId = colorId, TeamId = newTeam.Id });
            GetTeamColorList();
        }
        private void dgvTeamColors_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvTeamColors.SelectedRows.Count == 1 && e.KeyCode == Keys.Delete)
            {
                var deletedEntity = ((TeamColorDto)dgvTeamColors.SelectedRows[0].DataBoundItem);
                var result = _teamColorService.DeleteByColorIdTeamId(deletedEntity.ColorId, deletedEntity.TeamId);
                if (!result.Success)
                    MessageBox.Show("Bir hata oluştu. Tekrar deneyin");
                GetTeamColorList();
            }
            else
                return;

        }
        private void btnNextToPlayers_Click(object sender, EventArgs e)
        {
            lblToolTipColors.Visible = false;
            GetPlayerSectionActive();

        }
        #endregion

        #region Select Player
        private void GetPlayerList()
        {
            AllPlayers = _playerService.GetAllPlayersWithAssociatedProperties().Data;
            NewTeamPlayers = _playerService.GetPlayersByTeamId(newTeam.Id).Data;
            dgvAllPlayers.DataSource = AllPlayers;
            dgvPlayersOnTeam.DataSource = NewTeamPlayers;
        }
        private void GetPlayerSectionActive()
        {
            GetPlayerList();
            lblColors.BackColor = System.Drawing.Color.FromArgb(31, 31, 31);
            lblColors.ForeColor = System.Drawing.SystemColors.ActiveCaption;

            lblPlayers.BackColor = System.Drawing.Color.FromArgb(243, 124, 105);
            lblPlayers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            panelPlayers.BringToFront();

        }

        private void dgvAllPlayers_DoubleClick(object sender, EventArgs e)
        {
            if (dgvAllPlayers.SelectedRows.Count != 1) return;
            if (NewTeamPlayers.Any(x => x.Id == ((Player)dgvAllPlayers.SelectedRows[0].DataBoundItem).Id))
            {
                MessageBox.Show("Oyuncu zaten takımda");
                return;
            }
            DialogResult dr = MessageBox.Show("Seçilen oyuncuyu takımınıza eklemek istiyor musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                var updatedPlayer = ((Player)dgvAllPlayers.SelectedRows[0].DataBoundItem);
                updatedPlayer.TeamId = newTeam.Id;
                updatedPlayer.Team = newTeam;
                var result = _playerService.Update(updatedPlayer);
                if (!result.Success)
                    MessageBox.Show("Bir hata oluştu. Lütfen tekrar deneyiniz");
                GetPlayerList();
            }
        }

        private void dgvPlayersOnTeam_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvPlayersOnTeam.SelectedRows.Count == 1 && e.KeyCode == Keys.Delete)
            {
                var player = (Player)dgvPlayersOnTeam.SelectedRows[0].DataBoundItem;
                player.TeamId = null;
                var result = _playerService.Update(player);
                if (!result.Success)
                    MessageBox.Show("Oyuncu takımdan silinirken bir hata oluştu. Lütfen tekrar deneyin");
                GetPlayerList();
            }
        }
        private void btnAddNewPlayer_Click(object sender, EventArgs e)
        {
            if (txtNewPlayerName.Text == string.Empty) return;
            if (AllPlayers.Any(x => x.PlayerName.ToLower() == txtNewPlayerName.Text.ToLower()))
            {
                MessageBox.Show("Oyuncu zaten mevcut");
                return;
            }
            var result = _playerService.Add(new Player { PlayerName = txtNewPlayerName.Text.Trim(), TeamId = newTeam.Id });
            if (!result.Success)
            {
                MessageBox.Show("Oyuncu oluşturulurken bir hata oluştu. Tekrar deneyiniz");
            }
            else
            {
                GetPlayerList();
                txtNewPlayerName.Clear();
            }
        }
        #endregion

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
