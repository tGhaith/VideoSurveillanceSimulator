﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            
            InitializeComponent();
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            vidLogo.URL = "C:/Users/DELL/Downloads/logo.mp4";
            vidLogo.Ctlcontrols.play();
        }
    }
}
