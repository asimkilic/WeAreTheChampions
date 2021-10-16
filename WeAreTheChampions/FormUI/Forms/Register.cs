using Business.Abstract;
using Business.DependencyResolvers.Autofac;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.DTOs;
using FormUI.Forms.SplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI.Forms
{
    public partial class Register : Form
    {
        private IAuthService _authService;
       
        public Register()
        {
            InitializeComponent();
            _authService = InstanceFactory.GetInstance<IAuthService>();

        }
         void Splash()
        {
            frmSplashScreen frm = new frmSplashScreen();
            try
            {
                Application.Run(frm);
            }
            catch (Exception)
            {

               
            }
           
        }
        private void btnSignup_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(Splash));
            t.Start();
            var registerUser = new UserForRegisterDto
            {
                Email = txtEmail.KLCText,
                FirstName = txtFirstName.KLCText,
                LastName = txtLastName.KLCText,
                Password = txtPassword.KLCText
            };
            var result = _authService.Register(registerUser, registerUser.Password);
            try
            {
                t.Abort();
                
            }
            catch (Exception)
            {

                
            }
            if (result.Success)
            {
                // return login form
                Close();
            }

            Clean();
            MessageBox.Show(result.Message);


        }
        private void Clean()
        {
            txtPassword.KLCText = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

    
    }
}
