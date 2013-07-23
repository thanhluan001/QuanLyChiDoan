namespace HelperFormControl
{
    partial class SearchDoanVien
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
            this.chidoanCombobox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.KeywordTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chidoanCombobox
            // 
            this.chidoanCombobox.FormattingEnabled = true;
            this.chidoanCombobox.Location = new System.Drawing.Point(153, 108);
            this.chidoanCombobox.Name = "chidoanCombobox";
            this.chidoanCombobox.Size = new System.Drawing.Size(210, 21);
            this.chidoanCombobox.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(77, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Chi Đoàn";
            // 
            // KeywordTxt
            // 
            this.KeywordTxt.Location = new System.Drawing.Point(153, 61);
            this.KeywordTxt.Name = "KeywordTxt";
            this.KeywordTxt.Size = new System.Drawing.Size(210, 20);
            this.KeywordTxt.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Keyword";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(108, 158);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 20;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tìm kiếm đoàn viên";
            // 
            // SearchAllButton
            // 
            this.SearchAllButton.Location = new System.Drawing.Point(230, 158);
            this.SearchAllButton.Name = "SearchAllButton";
            this.SearchAllButton.Size = new System.Drawing.Size(133, 23);
            this.SearchAllButton.TabIndex = 33;
            this.SearchAllButton.Text = "Search All Doanvien";
            this.SearchAllButton.UseVisualStyleBackColor = true;
            this.SearchAllButton.Click += new System.EventHandler(this.SearchAllButton_Click);
            // 
            // SearchDoanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SearchAllButton);
            this.Controls.Add(this.chidoanCombobox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.KeywordTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label4);
            this.Name = "SearchDoanVien";
            this.Size = new System.Drawing.Size(402, 210);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox chidoanCombobox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox KeywordTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SearchAllButton;
    }
}
