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
    public partial class SearchDoanVien : UserControl
    {
        private string AllChidoanOption = "Tất cả chi đoàn";

        public SearchDoanVien()
        {
            InitializeComponent();

            //Populate Chidoan combo Box
            chidoanCombobox.Items.Add(AllChidoanOption);
            chidoanCombobox.Items.AddRange(Constant.chidoanID.Keys.ToArray());

            chidoanCombobox.SelectedIndex = 0;
        }

        private void SearchAllButton_Click(object sender, EventArgs e)
        {
            List<DoanVien> result = SQLCall.getAllDoanVien();
        }

        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            if (chidoanCombobox.SelectedItem.ToString() == AllChidoanOption)
            {
                // search all chidoan
                SQLCall.searchDoanVien(KeywordTxt.Text, -1);
            }
            else
            {
                // search selected chidoan
                SQLCall.searchDoanVien(KeywordTxt.Text,
                    Constant.chidoanID[chidoanCombobox.SelectedItem.ToString()]);
            }
        }

    }
}
