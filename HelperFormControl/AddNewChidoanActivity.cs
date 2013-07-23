using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConstantLibrary;

namespace HelperFormControl
{
    public partial class AddNewChidoanActivity : Form
    {
        private string chidoanNameStr;
        public AddNewChidoanActivity()
        {
            InitializeComponent();
        }

        public void setChidoanID(string chidoanName)
        {
            this.chidoanNameStr = chidoanName;
            chidoanNameLabel.Text = chidoanNameStr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chidoan.addNewChidoanActivity(Constant.chidoanID[chidoanNameStr],
                                        dateTimePicker1.Value, textBox1.Text);
        }
    }
}
