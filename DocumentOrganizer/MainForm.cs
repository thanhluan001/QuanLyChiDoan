using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Diagnostics;
using System.IO;
using MySql.Data.MySqlClient;

namespace QuanLyChiDoan
{
    public partial class MainForm : Form
    {
        public string homeFolder = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "DocumentOrganizer");

        private string currentDocumentToOpen = string.Empty;

        Dictionary<string, int> chidoanID = new Dictionary<string, int>();

        public MainForm()
        {
            InitializeComponent();

            string connStr = SQLCall.GetConnection();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand("select * from chidoan.`chidoaninfo`", conn))
                {
                    MySqlDataReader r = cmd.ExecuteReader();

                    bool count = true;
                    while (r.Read())
                    {
                        ChiDoanComboBox.Items.Add(r["name"]);
                        chidoanID.Add (r["name"].ToString(), Convert.ToInt32(r["chidoanID"]));
                        if (count)
                        {
                            string format = "MMM d yyyy"; 
                            TermFrom.Text =  ((DateTime)r["termFrom"]).ToString(format);
                            TermTo.Text = ((DateTime)r["termTo"]).ToString(format);
                            OperationalRegionLabel.Text = r["operationRegion"].ToString();

                            count = false;
                        }
                    }
                }
            }

            
            ChiDoanComboBox.SelectedIndex = 0;

            comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
            comboBox2.SelectedIndex = 0;

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand("select count(*) from chidoan.doanvienrecord where chidoanID=@chidoanID", conn))
                {
                    cmd.Parameters.AddWithValue("@chidoanID", chidoanID[ChiDoanComboBox.SelectedItem.ToString()]);

                    MySqlDataReader r = cmd.ExecuteReader();


                    bool count = true;
                    while (r.Read())
                    {
                        NumberOfMembersLabel.Text = r[0].ToString();
                    }
                }
            }

            ClearResultPage();
        }

        private void ClearResultPage()
        {
            dataGridView1.Rows.Clear();
        }

        private bool ValidateInput()
        {
            if (IncomingDocID.Text == string.Empty)
            {
                MessageBox.Show("ID Missing", "Error");
                return false;
            }

            return true;
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            //Check form completion
            if (!ValidateInput()) return;

            //Save file
            string SaveDirectory = SaveFileToArchive();

            if (SaveDirectory == string.Empty) return;
            
            //Enter this information to database
            string connStr = SQLCall.GetConnection();

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand("insert into Records (DocumentID, topic, category, full_path, time) values" +
                                                            "(@DocumentID, @topic, @category, @full_path, @time)", conn ))
                {
                    cmd.Parameters.AddWithValue("@DocumentID", IncomingDocID.Text );
                    cmd.Parameters.AddWithValue("@category", comboBox1.SelectedItem.ToString() );
                    cmd.Parameters.AddWithValue("@full_path", SaveDirectory);
                    cmd.Parameters.AddWithValue("@time", IncomingDocDatetime.Value);

                    cmd.ExecuteNonQuery();
                }
            }

            // Notification
            MessageBox.Show("Insert completed", "Notification");

            //housekeeping
            ClearField();
        }

        private void ClearField()
        {
            IncomingDocID.Text = string.Empty;
            comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
            IncomingDocDatetime.Value = DateTime.Now;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //Validation
            if (KeywordTxt.Text == string.Empty && IDTxt_Search.Text == string.Empty &&
                SearchDocVv.Text == string.Empty && NoDateRadioBtn.Checked &&
                comboBox2.SelectedIndex == 0)
            {
                MessageBox.Show("Enter some information to search", "Error");
                return;
            }

            //change tab
            tabControl1.SelectedIndex = 2;
            dataGridView1.Rows.Clear();

            //form query
            StringBuilder whereQuery = new StringBuilder();
            bool beforeQuery = false;

            if (KeywordTxt.Text != string.Empty)
            {
                whereQuery.Append("(DocumentID like @keyword OR topic like @keyword OR ")
                                .Append("category like @keyword OR full_path like @keyword) ");
                beforeQuery = true;
            }

            if (IDTxt_Search.Text != string.Empty)
            {
                //look up to see AND is needed
                if (beforeQuery)
                    whereQuery.Append(" AND ");

                whereQuery.Append("(DocumentID like @DocumentID)");
                beforeQuery = true;
            }

            if (SearchDocVv.Text != string.Empty)
            {
                // look up to see AND is needed
                if (beforeQuery)
                    whereQuery.Append(" AND ");

                whereQuery.Append("(topic like @topic)");
                beforeQuery = true;
            }

            if (comboBox2.SelectedIndex != 0)
            {
                if (beforeQuery)
                    whereQuery.Append(" AND ");
                whereQuery.Append("(category = @category)");
                beforeQuery = true;
            }

            if (SearchDoc_DateTimeFrom.Enabled)
            {
                if (beforeQuery)
                    whereQuery.Append(" AND ");
                whereQuery.Append("( time > @timeFrom)");
                beforeQuery = true;
            }

            if (SearchDoc_DateTimeTo.Enabled)
            {
                if (beforeQuery)
                    whereQuery.Append(" AND ");
                whereQuery.Append("( time < @timeTo)");
                beforeQuery = true;
            }

            // Make Database connection
            string connStr = SQLCall.GetConnection();

            //MySqlConnection conn = new MySqlConnection(connStr);

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand("select * from documentationorganizer.records where " + whereQuery.ToString(), conn))
                {
                    
                    if (KeywordTxt.Text != string.Empty)
                        cmd.Parameters.AddWithValue("@keyword", "%" + KeywordTxt.Text + "%");

                    if (IDTxt_Search.Text != string.Empty)
                        cmd.Parameters.AddWithValue("@DocumentID", "%" + IDTxt_Search.Text + "%");

                    if (SearchDocVv.Text != string.Empty)
                        cmd.Parameters.AddWithValue("@topic", "%" + SearchDocVv.Text + "%");

                    if (comboBox2.SelectedIndex != 0)
                    {
                        cmd.Parameters.AddWithValue("@category",  comboBox2.SelectedItem.ToString() );
                    }

                    if (SearchDoc_DateTimeFrom.Enabled)
                    {
                        cmd.Parameters.AddWithValue("@timeFrom", SearchDoc_DateTimeFrom.Value);
                    }

                    if (SearchDoc_DateTimeTo.Enabled)
                    {
                        cmd.Parameters.AddWithValue("@timeTo", SearchDoc_DateTimeTo.Value);
                    }

                    MySqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        dataGridView1.Rows.Add(r["ID"], r["DocumentID"], r["topic"], r["time"], r["category"], r["full_path"]);
                    }
                }
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = panel1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            switch (radioButton.Text)
            {
                case "No Date filter":
                    SearchDoc_DateTimeFrom.Enabled = false;
                    SearchDoc_DateTimeTo.Enabled = false;
                    break;
                case "Search Document from [date]":
                    SearchDoc_DateTimeFrom.Enabled = true;
                    SearchDoc_DateTimeTo.Enabled = false;
                    break;
                case "Search Document before [date]":
                    SearchDoc_DateTimeFrom.Enabled = false;
                    SearchDoc_DateTimeTo.Enabled = true;
                    break;
                case "Search Document from [date] to [date]":
                    SearchDoc_DateTimeFrom.Enabled = true;
                    SearchDoc_DateTimeTo.Enabled = true;
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private string SaveFileToArchive()
        {
            string result = string.Empty;

            string currentFolder = System.IO.Path.Combine(homeFolder, IncomingDocDatetime.Value.ToString("yyyy_MM_dd"));

            // create folder if not exists
            if (!File.Exists(currentFolder))
                Directory.CreateDirectory(currentFolder);

            //Process.Start(openFileDialog1.FileName);
            result = System.IO.Path.Combine(currentFolder, openFileDialog1.SafeFileName);
            File.Copy(openFileDialog1.FileName, System.IO.Path.Combine(result));

            return result;
        }

        private void SearchAllButton_Click(object sender, EventArgs e)
        {
            DisplayAllRecords();
        }

        private void DisplayAllRecords()
        {
            //populate the grid view
            dataGridView1.Rows.Clear();

            string connStr = SQLCall.GetConnection();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string sql = "select * from Records order by ID desc";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    dataGridView1.Rows.Add(r["ID"], r["DocumentID"], r["topic"], r["time"], r["category"], r["full_path"]);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            OpenDocButton.Enabled = true;
            DeleteButton.Enabled = true;
        }

        private void OpenDocButton_Click(object sender, EventArgs e)
        {
            string documentLocation = string.Empty;
            int selectedCellCount = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            int selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            
            if (selectedCellCount == 1)
            {
                documentLocation = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["Path"].Value.ToString();
            }
            else if (selectedRowCount == 1)
            {
                documentLocation = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["Path"].Value.ToString();
            }

            try
            {
                if (documentLocation != string.Empty)
                    Process.Start(documentLocation);
            }
            catch (Win32Exception ex)
            {
                MessageBox.Show("Win 32 Error. Check: \n" +
                                    "The file existed \n" +
                                    "The correct program to launch this", "Error");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string ID = string.Empty;
            int selectedCellCount = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            int selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            
            if (selectedCellCount == 1)
            {
                ID = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["DatabaseID"].Value.ToString();
            }
            else if (selectedRowCount == 1)
            {
                ID = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["DatabaseID"].Value.ToString();
            }

            string connStr = SQLCall.GetConnection();

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand("delete from documentationorganizer.records where ID = @ID", conn))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);

                    cmd.ExecuteNonQuery();
                }
            }
            // Notification
            MessageBox.Show("Document Deleted", "Notification");

            DisplayAllRecords();
        }

    }
}
