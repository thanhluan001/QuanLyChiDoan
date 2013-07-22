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
    public partial class AddChidoanActivity : UserControl
    {
        private int chidoanID;

        public AddChidoanActivity()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chidoan.addNewChidoanActivity(chidoanID, dateTimePicker1.Value, textBox1.Text);
        }
    }
}
