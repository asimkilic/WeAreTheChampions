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
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            FrmMatches frmMatches = new FrmMatches();
            frmMatches.MdiParent = this;
            frmMatches.FormBorderStyle = FormBorderStyle.None;
            panelMdi.Controls.Add(frmMatches);
            frmMatches.Show();
        }
    }
}
