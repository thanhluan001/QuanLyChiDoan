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
    public partial class AddChidoan : UserControl
    {
        public AddChidoan()
        {
            InitializeComponent();

            Constant constant = new Constant();
            parentCombobox.Items.AddRange(Constant.chidoanID.Keys.ToArray());
            parentCombobox.SelectedIndex = 0;   //set default value
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
                                        SQLCall.ifEmptyThenNull(regionTxt.Text), 
                                        Constant.chidoanID[parentCombobox.SelectedItem.ToString()] );

            // housing cleaning
            MessageBox.Show("Chi doan đã được đăng nhập", "Notification");
            Constant.refreshChidoanList();  // refresh the list of chidoanID
        }
    }
}
