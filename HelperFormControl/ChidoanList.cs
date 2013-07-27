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
    public partial class ChidoanList : UserControl
    {
        public ChidoanList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Chidoan> listChidoan = SQLCall.getAllChidoan();
            foreach (Chidoan element in listChidoan)
            {
                dataGridView1.Rows.Add(element.name, element.fromTerm, element.toTerm, element.parent_chidoan);
            }
        }
    }
}
