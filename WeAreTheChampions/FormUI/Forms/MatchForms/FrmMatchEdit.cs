using Business.Abstract;
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

namespace FormUI.Forms.MatchForms
{
    public partial class FrmMatchEdit : Form
    {
        private IMatchService _matchService;
        private Match _match;

        public FrmMatchEdit(IMatchService matchService, int matchId)
        {
            InitializeComponent();
            _matchService = matchService;
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMatchEdit_Load(object sender, EventArgs e)
        {
           
        }
    }
}
