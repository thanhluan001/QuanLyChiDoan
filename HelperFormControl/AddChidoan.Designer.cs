namespace HelperFormControl
{
    partial class AddChidoan
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.regionTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.chidoanNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.parentCombobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // regionTxt
            // 
            this.regionTxt.Location = new System.Drawing.Point(174, 160);
            this.regionTxt.Name = "regionTxt";
            this.regionTxt.Size = new System.Drawing.Size(200, 20);
            this.regionTxt.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Địa bàn hoạt động";
            // 
            // toDatePicker
            // 
            this.toDatePicker.Location = new System.Drawing.Point(174, 116);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(200, 20);
            this.toDatePicker.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Đến";
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Location = new System.Drawing.Point(174, 74);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(200, 20);
            this.fromDatePicker.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Từ";
            // 
            // chidoanNameTxt
            // 
            this.chidoanNameTxt.Location = new System.Drawing.Point(174, 35);
            this.chidoanNameTxt.Name = "chidoanNameTxt";
            this.chidoanNameTxt.Size = new System.Drawing.Size(200, 20);
            this.chidoanNameTxt.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên*";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Chi đoàn cấp trên*";
            // 
            // parentCombobox
            // 
            this.parentCombobox.FormattingEnabled = true;
            this.parentCombobox.Location = new System.Drawing.Point(174, 201);
            this.parentCombobox.Name = "parentCombobox";
            this.parentCombobox.Size = new System.Drawing.Size(144, 21);
            this.parentCombobox.TabIndex = 19;
            // 
            // AddChidoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.parentCombobox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.regionTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toDatePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fromDatePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chidoanNameTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Name = "AddChidoan";
            this.Size = new System.Drawing.Size(436, 291);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox regionTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker toDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox chidoanNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox parentCombobox;

    }
}
