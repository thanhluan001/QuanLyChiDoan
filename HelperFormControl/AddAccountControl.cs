using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConstantLibrary;

namespace HelperFormControl
{
    public partial class AddAccountControl : UserControl
    {
        public AddAccountControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //validation
            if (!SQLCall.checkUniqueness(UsernameTxt.Text))
            {
                ErrorMsgTxt.Text = "Username already exists";
                ErrorMsgTxt.ForeColor = Color.Red;

                return;
            }

            if (PassTxt.Text != RetypePassTxt.Text)
            {
                ErrorMsgTxt.Text = "Passwords are not matched";
                ErrorMsgTxt.ForeColor = Color.Red;

                return;
            }

            //process 
            SQLCall.insertNewAccount(UsernameTxt.Text, PassTxt.Text);

            //house cleaning
            ErrorMsgTxt.Text = string.Empty;
            UsernameTxt.Text = string.Empty;
            PassTxt.Text = string.Empty;
            RetypePassTxt.Text = string.Empty;
        }
    }
}
