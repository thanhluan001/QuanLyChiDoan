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
        public AddUserControl()
        {
            InitializeComponent();

            PersonalInfoChidoanComboBox.Items.AddRange(Constant.chidoanID.Keys.ToArray());
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            //Check form completion
            if (!ValidateInputPersonalInfo()) return;

            //Enter this information to database
            SQLCall.insertDoanVienPersonalInfo(Constant.chidoanID[PersonalInfoChidoanComboBox.SelectedItem.ToString()],
                                            NameTxt.Text, dateOfBirthDrp.Value,
                                            GenderComboBox.SelectedItem.ToString(),
                                            SQLCall.ifEmptyThenNull(ReligionTxt.Text),
                                            SQLCall.ifEmptyThenNull(RaceTxt.Text));

            
            Constant.currentDoanVienID = SQLCall.getIDDoanVien();

            /*
            if (AvataPic.ImageLocation != "noPhoto.png")
                SQLCall.saveBlob(Constant.currentDoanVienID, openFileDialog2.FileName);
            */
            // Notification
            MessageBox.Show("Insert completed", "Notification");

            //housekeeping
            ClearField();

            
            ((Control)NewMemberTab.TabPages[1]).Enabled = true;
            ((Control)NewMemberTab.TabPages[2]).Enabled = true;

            NewMemberTab.SelectedIndex = 1; //change tab when finished
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
            dateOfBirthDrp.Value = DateTime.Now;
            AvataPic.ImageLocation = "noPhoto.png";
        }

    }
}
