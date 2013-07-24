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
    public partial class AddUserControl : UserControl
    {
        public bool isInsertMode = true;

        public AddUserControl()
        {
            InitializeComponent();

            dateOfBirthDrp.Value = DateTime.Now.AddYears(-25);
            GenderComboBox.SelectedIndex = 0;
            Constant.refreshChidoanList();
            PersonalInfoChidoanComboBox.Items.AddRange(Constant.chidoanID.Keys.ToArray());
        }

        public void changeInsertMode()
        {
            isInsertMode = false;
        }

        public void PrepareEditMode(int userID)
        {

        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            //Check form completion
            if (!ValidateInputPersonalInfo()) return;

            //check image is empty or not 
            string imageID = string.Empty ;
            if (AvataPic.ImageLocation != "noPhoto.png" && AvataPic.ImageLocation != string.Empty && AvataPic.ImageLocation != null)
                imageID = SQLCall.getImageID().ToString();

            //Enter this information to database
            if (isInsertMode)
                SQLCall.insertDoanVienPersonalInfo(Constant.chidoanID[PersonalInfoChidoanComboBox.SelectedItem.ToString()],
                                            NameTxt.Text, dateOfBirthDrp.Value,
                                            GenderComboBox.SelectedItem.ToString(),
                                            SQLCall.ifEmptyThenNull(ReligionTxt.Text),
                                            SQLCall.ifEmptyThenNull(RaceTxt.Text),
                                            SQLCall.ifEmptyThenNull(imageID));
            else
                SQLCall.updateDoanVienPersonalInfo(Constant.currentDoanVienID,
                                            Constant.chidoanID[PersonalInfoChidoanComboBox.SelectedItem.ToString()],
                                            NameTxt.Text, dateOfBirthDrp.Value,
                                            GenderComboBox.SelectedItem.ToString(),
                                            SQLCall.ifEmptyThenNull(ReligionTxt.Text),
                                            SQLCall.ifEmptyThenNull(RaceTxt.Text),
                                            SQLCall.ifEmptyThenNull(imageID));

            if (isInsertMode)
                Constant.currentDoanVienID = SQLCall.getIDDoanVien();

            // Notification
            MessageBox.Show("Insert completed", "Notification");

            //housekeeping
            //ClearField();

            ((Control)NewMemberTab.TabPages[1]).Enabled = true;
            ((Control)NewMemberTab.TabPages[2]).Enabled = true;

            NewMemberTab.SelectedIndex = 1; //change tab when finished
            isInsertMode = false;
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

        private void ClearField()
        {
            NameTxt.Text = string.Empty;
            GenderComboBox.SelectedIndex = GenderComboBox.Items.Count - 1;
            dateOfBirthDrp.Value = DateTime.Now.AddYears(-25) ;
            AvataPic.ImageLocation = "noPhoto.png";
        }

        private void ChangePicButton_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            string filePath = openFileDialog2.FileName;

            //insert into database
            SQLCall.saveBlob( Constant.currentDoanVienID, filePath);

            //set picture
            AvataPic.ImageLocation = filePath;
        }

        private void ContactButton_Click(object sender, EventArgs e)
        {
            //validation
            if (Constant.currentDoanVienID == -1)
            {
                MessageBox.Show("Invalid doan vien ID", "Error");
                return;
            }

            //process
            SQLCall.updateDoanVienContactInfo(Constant.currentDoanVienID,
                                SQLCall.ifEmptyThenNull(currentAddressTxt.Text),
                                SQLCall.ifEmptyThenNull(telephoneTxt.Text),
                                SQLCall.ifEmptyThenNull(emailTxt.Text));

            // feedback
            MessageBox.Show("Insert completed", "Notification");

            ((Control)NewMemberTab.TabPages[1]).Enabled = true;
            ((Control)NewMemberTab.TabPages[2]).Enabled = true;

            NewMemberTab.SelectedIndex = 2; //change tab when finished
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //validation

            //process
            SQLCall.updateEducationLevel(Constant.currentDoanVienID,
                SQLCall.ifEmptyThenNull(EducationTxt.Text),
                SQLCall.ifEmptyThenNull(ProfessionalLevelTxt.Text),
                SQLCall.ifEmptyThenNull(PoliticalLevelTxt.Text),
                SQLCall.ifEmptyThenNull(ResponsibilityTxt.Text),
                DoanEntryDateDrp.Value, DangEntryDateDrp.Value);

            //housecleaning
            MessageBox.Show("Insert completed", "Notification");
        }

    }
}
