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
            ErrorLabel.ForeColor = Color.Red;
            ErrorLabel.Text = errMsg;
        }

        private void SigninBtn_Click(object sender, EventArgs e)
        {
            if (SQLCall.isSignInSucessful(loginTxt.Text, passTxt.Text))
                DialogResult = DialogResult.OK;
            else
                setErrorMessage("Usernam or password is not correct");
            
        }



    }
}
