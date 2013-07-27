namespace HelperFormControl
{
    partial class ChidoanDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.ChidoanNameTxt = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddActivityBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberOfDoanvienTxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberOfMaleTxt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NumberOfFemaleTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên chi đoàn";
            // 
            // ChidoanNameTxt
            // 
            this.ChidoanNameTxt.AutoSize = true;
            this.ChidoanNameTxt.Location = new System.Drawing.Point(162, 35);
            this.ChidoanNameTxt.Name = "ChidoanNameTxt";
            this.ChidoanNameTxt.Size = new System.Drawing.Size(35, 13);
            this.ChidoanNameTxt.TabIndex = 1;
            this.ChidoanNameTxt.Text = "label2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(58, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(416, 245);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ngày";
            this.Column1.Name = "Column1";
            this.Column1.Width = 110;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Mô tả";
            this.Column2.Name = "Column2";
            // 
            // AddActivityBtn
            // 
            this.AddActivityBtn.Location = new System.Drawing.Point(191, 359);
            this.AddActivityBtn.Name = "AddActivityBtn";
            this.AddActivityBtn.Size = new System.Drawing.Size(109, 23);
            this.AddActivityBtn.TabIndex = 3;
            this.AddActivityBtn.Text = "Thêm hoạt động";
            this.AddActivityBtn.UseVisualStyleBackColor = true;
            this.AddActivityBtn.Click += new System.EventHandler(this.AddActivityBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tổng số đoàn viên";
            // 
            // NumberOfDoanvienTxt
            // 
            this.NumberOfDoanvienTxt.AutoSize = true;
            this.NumberOfDoanvienTxt.Location = new System.Drawing.Point(162, 62);
            this.NumberOfDoanvienTxt.Name = "NumberOfDoanvienTxt";
            this.NumberOfDoanvienTxt.Size = new System.Drawing.Size(35, 13);
            this.NumberOfDoanvienTxt.TabIndex = 6;
            this.NumberOfDoanvienTxt.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tổng số nam";
            // 
            // NumberOfMaleTxt
            // 
            this.NumberOfMaleTxt.AutoSize = true;
            this.NumberOfMaleTxt.Location = new System.Drawing.Point(162, 89);
            this.NumberOfMaleTxt.Name = "NumberOfMaleTxt";
            this.NumberOfMaleTxt.Size = new System.Drawing.Size(35, 13);
            this.NumberOfMaleTxt.TabIndex = 8;
            this.NumberOfMaleTxt.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tổng số nữ";
            // 
            // NumberOfFemaleTxt
            // 
            this.NumberOfFemaleTxt.AutoSize = true;
            this.NumberOfFemaleTxt.Location = new System.Drawing.Point(356, 89);
            this.NumberOfFemaleTxt.Name = "NumberOfFemaleTxt";
            this.NumberOfFemaleTxt.Size = new System.Drawing.Size(35, 13);
            this.NumberOfFemaleTxt.TabIndex = 10;
            this.NumberOfFemaleTxt.Text = "label6";
            // 
            // ChidoanDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NumberOfFemaleTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NumberOfMaleTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumberOfDoanvienTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddActivityBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ChidoanNameTxt);
            this.Controls.Add(this.label1);
            this.Name = "ChidoanDetails";
            this.Size = new System.Drawing.Size(508, 385);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ChidoanNameTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddActivityBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NumberOfDoanvienTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NumberOfMaleTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label NumberOfFemaleTxt;
    }
}
