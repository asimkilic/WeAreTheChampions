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

namespace FormUI.Forms.PlayerForms
{
    public partial class FrmNewPlayer : Form
    {
        // Services
        private readonly IPlayerService _playerService;

        // Lists
        private List<Player> AllPlayers;
        public FrmNewPlayer()
        {
            InitializeComponent();
            _playerService = InstanceFactory.GetInstance<IPlayerService>();
        }

        private void FrmNewPlayer_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = KLCCache.KLCCacheManager.NameSurname;
            dgvAllPlayers.EnableHeadersVisualStyles = false;
            dgvAllPlayers.AutoGenerateColumns = false;
            GetPlayerList();
        }
        private void GetPlayerList()
        {
            AllPlayers = _playerService.GetAllPlayersWithAssociatedProperties().Data;

            dgvAllPlayers.DataSource = AllPlayers;

        }

        private void btnAddNewPlayer_Click(object sender, EventArgs e)
        {
            if (txtNewPlayerName.Text == string.Empty) return;
            if (AllPlayers.Any(x => x.PlayerName.ToLower() == txtNewPlayerName.Text.ToLower()))
            {
                MessageBox.Show("Oyuncu zaten mevcut");
                return;
            }
            var result = _playerService.Add(new Player { PlayerName = txtNewPlayerName.Text.Trim() });
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

        private void dgvAllPlayers_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvAllPlayers.SelectedRows.Count == 1 && e.KeyCode == Keys.Delete)
            {
                var deletedPlayer = (Player)dgvAllPlayers.SelectedRows[0].DataBoundItem;
                var result=_playerService.Delete(deletedPlayer);
                if (!result.Success)
                    MessageBox.Show(result.Message==null?"Bir hata oluştu. Lütfen tekrar deneyiniz":result.Message);
                else
                    MessageBox.Show("Oyuncu başarıyla silindi");
                GetPlayerList();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
