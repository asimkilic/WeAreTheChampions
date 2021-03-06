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
    public partial class FrmRegister : Form
    {
        private IAuthService _authService;
        public event EventHandler WorksDone;

        public FrmRegister()
        {
            InitializeComponent();
            _authService = InstanceFactory.GetInstance<IAuthService>();

        }
        void Splash()
        {
            frmSplashScreen frm = new frmSplashScreen();
            WorksDone += frm.WorksDone;
            Application.Run(frm);


        }
        private void btnSignup_Click(object sender, EventArgs e)
        {
            // Thread t = new Thread(new ThreadStart(Splash));
            //  t.Start();

            var registerUser = new UserForRegisterDto
            {
                Email = txtEmail.KLCText,
                FirstName = txtFirstName.KLCText,
                LastName = txtLastName.KLCText,
                Password = txtPassword.KLCText
            };
            // IDataResult<User> result = null;
            // try
            // {
            var result = _authService.Register(registerUser, registerUser.Password);
            // }
            //  catch (Exception)
            //  {
            //     t.Abort();

            //  }
            //  WorksDone?.Invoke(null, EventArgs.Empty);





            // if (result is null) return;
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
