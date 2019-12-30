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

namespace Project
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
                /*Thread t = new Thread(new ThreadStart(startForm));
                t.Start();
                Thread.Sleep(12000);*/
                InitializeComponent();
                //t.Abort();
        }
        public void startForm()
        {
            Application.Run(new frmSplashScreen());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnNewPrj_Click(object sender, EventArgs e)
        {
            frmWorkSpace fws = new frmWorkSpace();
            fws.Show();
            this.Hide();
        }
    }
}
