using Business.Abstract;
using Business.DependencyResolvers.Autofac;
using Entities.Concrete;
using Entities.DTOs;
using FormUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class FrmLogin : Form
    {
        private IAuthService _authService;
        public FrmLogin()
        {
            InitializeComponent();
            _authService = InstanceFactory.GetInstance<IAuthService>();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var result = _colorService.GetAll();
            //foreach (var item in result)
            //{
            //    MessageBox.Show(item.ColorName);
            //}
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblWarning.Visible = false;
            var user = new UserForLoginDto { Email = txtEmail.Text, Password = txtPassword.Text };
            var result = _authService.Login(user);
            if (!result.Success)
            {
                lblWarning.Visible = true;
                lblWarning.Text = result.Message == null || result.Message != "" ? result.Message : "Hatalı giriş";
            }
            //TODO: success redirect another page


        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegister register = new FrmRegister();
            register.ShowDialog();
            this.Show();
        }
    }
}
