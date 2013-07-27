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
    public partial class ChidoanDetails : UserControl
    {
        private string chidoanName; 

        public ChidoanDetails()
        {
            InitializeComponent();

            //test: add chidoan name
            chidoanName = "TestAddChidoan";

            //populate the data
            ChidoanNameTxt.Text = chidoanName;

            int total = SQLCall.countDoanvien(Constant.chidoanID[chidoanName]);
            int male = SQLCall.countMale(Constant.chidoanID[chidoanName]);
                
            NumberOfDoanvienTxt.Text = total.ToString();
            NumberOfMaleTxt.Text = male.ToString();
            NumberOfFemaleTxt.Text = (total-male).ToString();
            
            PopulateGridView();
        }

        private void PopulateGridView()
        {
            dataGridView1.Rows.Clear();

            //populate the view
            List<ChidoanActivity> activityList = SQLCall.getAllActivityFromOneChidoan(Constant.chidoanID[chidoanName]);
            foreach (ChidoanActivity element in activityList)
            {
                dataGridView1.Rows.Add(element.time, element.description);
            }
        }

        public void changeChidoanName(string chidoanName)
        {
            this.chidoanName = chidoanName;
            ChidoanNameTxt.Text = chidoanName;
        }

        private void AddActivityBtn_Click(object sender, EventArgs e)
        {
            AddNewChidoanActivity dialog = new AddNewChidoanActivity();
            dialog.setChidoanID(chidoanName);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                PopulateGridView();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Add something to test here :D
            dataGridView1.Rows.Add(DateTime.Now, "some test here");
        }

        
    }
}
