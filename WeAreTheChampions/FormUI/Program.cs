using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using FormUI.Forms;
using FormUI.Forms.MatchForms;
using FormUI.Forms.TeamsForms;
using FormUI.Forms.ColorForms;
using FormUI.Forms.PlayerForms;

namespace FormUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // REF: https://stackoverflow.com/questions/8148156/winforms-global-exception-handling
            // REF: https://blogs.msmvps.com/deborahk/global-exception-handler-winforms/
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(MyHandler);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }

        static void MyHandler(object sender, UnhandledExceptionEventArgs args)
        {
            Exception e = (Exception)args.ExceptionObject;
            // REF: https://stackoverflow.com/questions/9270023/how-to-determine-if-an-exception-is-of-a-particular-type
            if (e.GetType() == typeof(System.Threading.ThreadAbortException))
            {
                // MessageBox.Show("type çalıştı");
                return;
            }

            Console.WriteLine("MyHandler caught : " + e.Message + " " + e.InnerException);
            MessageBox.Show(e.Message + e.InnerException);

        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            // Do logging
            MessageBox.Show(e.Exception.Message);


        }

    }
}
