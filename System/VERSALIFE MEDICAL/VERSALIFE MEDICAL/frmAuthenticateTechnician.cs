﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VERSALIFE_MEDICAL
{
    public partial class frmAuthenticateTechnician : Form
    {
        public frmAuthenticateTechnician()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void frmAuthenticateTechnician_Load(object sender, EventArgs e)
        {
            //this.StartPosition = FormStartPosition.Manual;
        }
        //public static string btnHide;
        private void btnSignin_Click(object sender, EventArgs e)
        {
            frmLogin.ActiveForm.Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
