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
    public partial class AddNewChidoan : Form
    {
        public AddNewChidoan()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //validation
            if (chidoanNameTxt.Text == string.Empty)
            {
                MessageBox.Show("Invalid chi doan ID", "Error");
                return;
            }

            SQLCall.insertChidoanInfo(chidoanNameTxt.Text, fromDatePicker.Value, toDatePicker.Value,
                                        SQLCall.ifEmptyThenNull(regionTxt.Text));

            // housing cleaning
            MessageBox.Show("Chi doan đã được đăng nhập", "Notification");
        }
    }
}
