using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyChiDoan
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        public void setErrorMessage(string errMsg)
        {
            ErrorMsg.Text = errMsg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLCall.isSignInSucessful(loginTxt.Text, passTxt.Text);
        }


    }
}
