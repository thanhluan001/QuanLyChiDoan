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
using ConstantLibrary;


namespace QuanLyChiDoan
{
    public partial class MainForm : Form
    {
        private Dictionary<string, int> chidoanID;

        public int currentDoanVienID
        {
            get; 
            set;
        }

        public MainForm()
        {
            InitializeComponent();

            //validation, sign in
            SignIn signin = new SignIn();

            while ( signin.ShowDialog() != DialogResult.OK)
            {
                
            }

            //initialize
            GenderComboBox.SelectedIndex = 1;

            chidoanID = SQLCall.getChidoanInfo();

            ((Control)NewMemberTab.TabPages[1]).Enabled = false;
            ((Control)NewMemberTab.TabPages[2]).Enabled = false;

            ChiDoanComboBox.Items.AddRange(chidoanID.Keys.ToArray());
            PersonalInfoChidoanComboBox.Items.AddRange(chidoanID.Keys.ToArray());

            ChiDoanComboBox.SelectedIndex = 0;
            PersonalInfoChidoanComboBox.SelectedIndex = 0;

            GenderComboBox.SelectedIndex = GenderComboBox.Items.Count - 1;
            comboBox2.SelectedIndex = 0;

            NumberOfMembersLabel.Text = SQLCall.getDoanVienCountFromChiDoan(chidoanID[ChiDoanComboBox.SelectedItem.ToString()]).ToString();

            NewMemberTab.Enabled = false;
            //housecleaning
            ClearResultPage();
        }

        private void ClearResultPage()
        {
            dataGridView1.Rows.Clear();
        }

        private bool ValidateInputPersonalInfo()
        {

            if (NameTxt.Text == string.Empty)
            {
                MessageBox.Show("Thiếu họ và tên", "Error");
                return false;
            }

            return true;
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            //Check form completion
            if (!ValidateInputPersonalInfo()) return;
            
            //Enter this information to database
            SQLCall.insertDoanVienPersonalInfo(chidoanID[PersonalInfoChidoanComboBox.SelectedItem.ToString()], 
                                            NameTxt.Text, dateOfBirthDrp.Value, 
                                            GenderComboBox.SelectedItem.ToString(),
                                            SQLCall.ifEmptyThenNull(ReligionTxt.Text),
                                            SQLCall.ifEmptyThenNull(RaceTxt.Text));

            currentDoanVienID = SQLCall.getIDDoanVien();

            if (AvataPic.ImageLocation != "noPhoto.png")
                SQLCall.saveBlob(currentDoanVienID, openFileDialog2.FileName);

            // Notification
            MessageBox.Show("Insert completed", "Notification");

            //housekeeping
            ClearField();
            

            ((Control)NewMemberTab.TabPages[1]).Enabled = true;
            ((Control)NewMemberTab.TabPages[2]).Enabled = true;

            NewMemberTab.SelectedIndex = 1; //change tab when finished
        }

        private void ContactButton_Click(object sender, EventArgs e)
        {
            //validation
            if (currentDoanVienID == -1)
            {
                MessageBox.Show("Invalid doan vien ID", "Error");
                return;
            }

            //process
            SQLCall.insertDoanVienContactInfo(currentDoanVienID, 
                                SQLCall.ifEmptyThenNull(currentAddressTxt.Text), 
                                SQLCall.ifEmptyThenNull(telephoneTxt.Text), 
                                SQLCall.ifEmptyThenNull(emailTxt.Text));

            // feedback
            MessageBox.Show("Insert completed", "Notification");
        }

        private void ClearField()
        {
            NameTxt.Text = string.Empty;
            GenderComboBox.SelectedIndex = GenderComboBox.Items.Count - 1;
            dateOfBirthDrp.Value = DateTime.Now;
            AvataPic.ImageLocation = "noPhoto.png";
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

        private void button5_Click(object sender, EventArgs e)
        {
            //notification 
            MessageBox.Show("ID mới cho đoàn viên", "Notification");

            NewMemberTab.Enabled = true;            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //validation

            //process
            SQLCall.insertEducationLevel(currentDoanVienID,
                SQLCall.ifEmptyThenNull(EducationTxt.Text),
                SQLCall.ifEmptyThenNull(ProfessionalLevelTxt.Text),
                SQLCall.ifEmptyThenNull(PoliticalLevelTxt.Text),
                SQLCall.ifEmptyThenNull(ResponsibilityTxt.Text),
                DoanEntryDateDrp.Value, DangEntryDateDrp.Value);

            //housecleaning
            MessageBox.Show("Insert completed", "Notification" );
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            string filePath = openFileDialog2.FileName;

            //insert into database
            SQLCall.saveBlob(currentDoanVienID, filePath);

            //set picture
            AvataPic.ImageLocation = filePath;
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AddNewChidoan form2 = new AddNewChidoan();

            if (form2.ShowDialog() == DialogResult.OK)
            {

            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            List<DoanVien> result = DoanVien.getAllDoanvien();
        }
    }
}
