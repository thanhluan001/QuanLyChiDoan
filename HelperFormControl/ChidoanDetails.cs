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
            label2.Text = chidoanName;
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
