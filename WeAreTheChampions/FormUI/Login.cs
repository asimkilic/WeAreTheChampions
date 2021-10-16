using Business.Abstract;
using Business.DependencyResolvers.Autofac;
using Entities.Concrete;
using Entities.DTOs;
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
    public partial class Login : Form
    {
        private IAuthService _authService;
        public Login()
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
            var user = new UserForLoginDto { Email = txtEmail.Text, Password = txtPassword.Text };
            var result = _authService.Login(user);
            if (!result.Success)
            {
                lblWarning.Enabled = true;
                lblWarning.Text = result.Message == null || result.Message != "" ? result.Message : "Hatalı giriş";
            }
            //TODO: success redirect another page

            DateTime date = DateTime.Now;

            string a = date.ToString("HH:mm");

        }
    }
}
