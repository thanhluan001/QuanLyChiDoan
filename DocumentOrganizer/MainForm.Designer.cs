namespace QuanLyChiDoan
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EnterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ChiDoanComboBox = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TermTo = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.TermFrom = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.NewItem = new System.Windows.Forms.TabPage();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.IncomingDocDatetime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.IncomingDocID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.KeywordTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SearchDoc_DateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.SearchDoc_DateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NoDateRadioBtn = new System.Windows.Forms.RadioButton();
            this.FromDateToDateRadioBtn = new System.Windows.Forms.RadioButton();
            this.ToDateRadioBtn = new System.Windows.Forms.RadioButton();
            this.FromDateRadioBtn = new System.Windows.Forms.RadioButton();
            this.SearchDocVv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.IDTxt_Search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.TabPage();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SearchAllButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DatabaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.OpenDocButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OperationalRegionLabel = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.NumberOfMembersLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.NewItem.SuspendLayout();
            this.Search.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(90, 438);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(83, 27);
            this.EnterButton.TabIndex = 0;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Điền thông tin về đoàn viên mới";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.NewItem);
            this.tabControl1.Controls.Add(this.Search);
            this.tabControl1.Controls.Add(this.Result);
            this.tabControl1.Location = new System.Drawing.Point(6, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(522, 512);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.NumberOfMembersLabel);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.OperationalRegionLabel);
            this.tabPage1.Controls.Add(this.ChiDoanComboBox);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.TermTo);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.TermFrom);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(514, 486);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Thông tin chi đoàn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ChiDoanComboBox
            // 
            this.ChiDoanComboBox.FormattingEnabled = true;
            this.ChiDoanComboBox.Location = new System.Drawing.Point(138, 24);
            this.ChiDoanComboBox.Name = "ChiDoanComboBox";
            this.ChiDoanComboBox.Size = new System.Drawing.Size(121, 21);
            this.ChiDoanComboBox.TabIndex = 11;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(44, 97);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(44, 13);
            this.label23.TabIndex = 10;
            this.label23.Text = "Địa bàn";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(103, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Thêm chi đoàn mới";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Thông tin về chi đoàn";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TermTo
            // 
            this.TermTo.AutoSize = true;
            this.TermTo.Location = new System.Drawing.Point(262, 66);
            this.TermTo.Name = "TermTo";
            this.TermTo.Size = new System.Drawing.Size(42, 13);
            this.TermTo.TabIndex = 7;
            this.TermTo.Text = "Nodate";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(195, 66);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(29, 13);
            this.label27.TabIndex = 6;
            this.label27.Text = "đến ";
            // 
            // TermFrom
            // 
            this.TermFrom.AutoSize = true;
            this.TermFrom.Location = new System.Drawing.Point(122, 66);
            this.TermFrom.Name = "TermFrom";
            this.TermFrom.Size = new System.Drawing.Size(42, 13);
            this.TermFrom.TabIndex = 5;
            this.TermFrom.Text = "Nodate";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(41, 66);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(51, 13);
            this.label25.TabIndex = 4;
            this.label25.Text = "Nhiệm kỳ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(38, 33);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "Tên chi đoàn";
            // 
            // NewItem
            // 
            this.NewItem.Controls.Add(this.textBox6);
            this.NewItem.Controls.Add(this.label21);
            this.NewItem.Controls.Add(this.dateTimePicker2);
            this.NewItem.Controls.Add(this.label20);
            this.NewItem.Controls.Add(this.dateTimePicker1);
            this.NewItem.Controls.Add(this.label19);
            this.NewItem.Controls.Add(this.textBox5);
            this.NewItem.Controls.Add(this.textBox4);
            this.NewItem.Controls.Add(this.textBox3);
            this.NewItem.Controls.Add(this.label18);
            this.NewItem.Controls.Add(this.textBox2);
            this.NewItem.Controls.Add(this.comboBox3);
            this.NewItem.Controls.Add(this.label17);
            this.NewItem.Controls.Add(this.label16);
            this.NewItem.Controls.Add(this.label15);
            this.NewItem.Controls.Add(this.textBox1);
            this.NewItem.Controls.Add(this.label10);
            this.NewItem.Controls.Add(this.IncomingDocDatetime);
            this.NewItem.Controls.Add(this.label7);
            this.NewItem.Controls.Add(this.comboBox1);
            this.NewItem.Controls.Add(this.label11);
            this.NewItem.Controls.Add(this.IncomingDocID);
            this.NewItem.Controls.Add(this.label3);
            this.NewItem.Controls.Add(this.label2);
            this.NewItem.Controls.Add(this.EnterButton);
            this.NewItem.Controls.Add(this.label1);
            this.NewItem.Location = new System.Drawing.Point(4, 22);
            this.NewItem.Name = "NewItem";
            this.NewItem.Padding = new System.Windows.Forms.Padding(3);
            this.NewItem.Size = new System.Drawing.Size(514, 486);
            this.NewItem.TabIndex = 0;
            this.NewItem.Text = "Thêm thông tin đoàn viên";
            this.NewItem.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(128, 400);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 35;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(26, 400);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 13);
            this.label21.TabIndex = 34;
            this.label21.Text = "Chức vụ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(128, 369);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 33;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(24, 369);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(81, 13);
            this.label20.TabIndex = 32;
            this.label20.Text = "Ngày vào đảng";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(128, 342);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(21, 342);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 13);
            this.label19.TabIndex = 30;
            this.label19.Text = "Ngày vào đoàn";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(128, 313);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 29;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(100, 272);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 28;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(90, 173);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 27;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(24, 173);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 26;
            this.label18.Text = "Tôn giáo";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 205);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 25;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(90, 32);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(23, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "Chi Đoàn";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 313);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "Trình độ học vấn";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 272);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Nơi ở hiện nay";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 240);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 20);
            this.textBox1.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Thành phần";
            // 
            // IncomingDocDatetime
            // 
            this.IncomingDocDatetime.Location = new System.Drawing.Point(90, 129);
            this.IncomingDocDatetime.Name = "IncomingDocDatetime";
            this.IncomingDocDatetime.Size = new System.Drawing.Size(200, 20);
            this.IncomingDocDatetime.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ngày sinh";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBox1.Location = new System.Drawing.Point(90, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Giới tính";
            // 
            // IncomingDocID
            // 
            this.IncomingDocID.Location = new System.Drawing.Point(90, 59);
            this.IncomingDocID.Name = "IncomingDocID";
            this.IncomingDocID.Size = new System.Drawing.Size(121, 20);
            this.IncomingDocID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Họ và tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dân tộc";
            // 
            // Search
            // 
            this.Search.Controls.Add(this.comboBox2);
            this.Search.Controls.Add(this.label9);
            this.Search.Controls.Add(this.KeywordTxt);
            this.Search.Controls.Add(this.label8);
            this.Search.Controls.Add(this.label14);
            this.Search.Controls.Add(this.label13);
            this.Search.Controls.Add(this.SearchDoc_DateTimeTo);
            this.Search.Controls.Add(this.SearchDoc_DateTimeFrom);
            this.Search.Controls.Add(this.label12);
            this.Search.Controls.Add(this.panel1);
            this.Search.Controls.Add(this.SearchDocVv);
            this.Search.Controls.Add(this.label6);
            this.Search.Controls.Add(this.SearchButton);
            this.Search.Controls.Add(this.IDTxt_Search);
            this.Search.Controls.Add(this.label5);
            this.Search.Controls.Add(this.label4);
            this.Search.Location = new System.Drawing.Point(4, 22);
            this.Search.Name = "Search";
            this.Search.Padding = new System.Windows.Forms.Padding(3);
            this.Search.Size = new System.Drawing.Size(514, 486);
            this.Search.TabIndex = 1;
            this.Search.Text = "Tìm kiếm đoàn viên";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Không chọn",
            "Công Văn",
            "Tờ Trình",
            "Chỉ Thị",
            "Quyết Định",
            "Báo Cáo",
            "Thông Báo",
            "Giấy mời họp",
            "Khác "});
            this.comboBox2.Location = new System.Drawing.Point(100, 236);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(146, 21);
            this.comboBox2.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Category";
            // 
            // KeywordTxt
            // 
            this.KeywordTxt.Location = new System.Drawing.Point(100, 52);
            this.KeywordTxt.Name = "KeywordTxt";
            this.KeywordTxt.Size = new System.Drawing.Size(341, 20);
            this.KeywordTxt.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Keyword";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(103, 409);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "To";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(103, 382);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "From";
            // 
            // SearchDoc_DateTimeTo
            // 
            this.SearchDoc_DateTimeTo.Enabled = false;
            this.SearchDoc_DateTimeTo.Location = new System.Drawing.Point(143, 408);
            this.SearchDoc_DateTimeTo.Name = "SearchDoc_DateTimeTo";
            this.SearchDoc_DateTimeTo.Size = new System.Drawing.Size(200, 20);
            this.SearchDoc_DateTimeTo.TabIndex = 10;
            // 
            // SearchDoc_DateTimeFrom
            // 
            this.SearchDoc_DateTimeFrom.Enabled = false;
            this.SearchDoc_DateTimeFrom.Location = new System.Drawing.Point(143, 382);
            this.SearchDoc_DateTimeFrom.Name = "SearchDoc_DateTimeFrom";
            this.SearchDoc_DateTimeFrom.Size = new System.Drawing.Size(200, 20);
            this.SearchDoc_DateTimeFrom.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 278);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Date";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NoDateRadioBtn);
            this.panel1.Controls.Add(this.FromDateToDateRadioBtn);
            this.panel1.Controls.Add(this.ToDateRadioBtn);
            this.panel1.Controls.Add(this.FromDateRadioBtn);
            this.panel1.Location = new System.Drawing.Point(100, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 98);
            this.panel1.TabIndex = 7;
            // 
            // NoDateRadioBtn
            // 
            this.NoDateRadioBtn.AutoSize = true;
            this.NoDateRadioBtn.Checked = true;
            this.NoDateRadioBtn.Location = new System.Drawing.Point(20, 9);
            this.NoDateRadioBtn.Name = "NoDateRadioBtn";
            this.NoDateRadioBtn.Size = new System.Drawing.Size(87, 17);
            this.NoDateRadioBtn.TabIndex = 9;
            this.NoDateRadioBtn.TabStop = true;
            this.NoDateRadioBtn.Text = "No Date filter";
            this.NoDateRadioBtn.UseVisualStyleBackColor = true;
            this.NoDateRadioBtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // FromDateToDateRadioBtn
            // 
            this.FromDateToDateRadioBtn.AutoSize = true;
            this.FromDateToDateRadioBtn.Location = new System.Drawing.Point(20, 78);
            this.FromDateToDateRadioBtn.Name = "FromDateToDateRadioBtn";
            this.FromDateToDateRadioBtn.Size = new System.Drawing.Size(206, 17);
            this.FromDateToDateRadioBtn.TabIndex = 8;
            this.FromDateToDateRadioBtn.Text = "Search Document from [date] to [date]";
            this.FromDateToDateRadioBtn.UseVisualStyleBackColor = true;
            this.FromDateToDateRadioBtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ToDateRadioBtn
            // 
            this.ToDateRadioBtn.AutoSize = true;
            this.ToDateRadioBtn.Location = new System.Drawing.Point(20, 55);
            this.ToDateRadioBtn.Name = "ToDateRadioBtn";
            this.ToDateRadioBtn.Size = new System.Drawing.Size(174, 17);
            this.ToDateRadioBtn.TabIndex = 7;
            this.ToDateRadioBtn.Text = "Search Document before [date]";
            this.ToDateRadioBtn.UseVisualStyleBackColor = true;
            this.ToDateRadioBtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // FromDateRadioBtn
            // 
            this.FromDateRadioBtn.AutoSize = true;
            this.FromDateRadioBtn.Location = new System.Drawing.Point(20, 32);
            this.FromDateRadioBtn.Name = "FromDateRadioBtn";
            this.FromDateRadioBtn.Size = new System.Drawing.Size(164, 17);
            this.FromDateRadioBtn.TabIndex = 6;
            this.FromDateRadioBtn.Text = "Search Document from [date]";
            this.FromDateRadioBtn.UseVisualStyleBackColor = true;
            this.FromDateRadioBtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // SearchDocVv
            // 
            this.SearchDocVv.Location = new System.Drawing.Point(100, 137);
            this.SearchDocVv.Multiline = true;
            this.SearchDocVv.Name = "SearchDocVv";
            this.SearchDocVv.Size = new System.Drawing.Size(341, 20);
            this.SearchDocVv.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "V/v";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(100, 434);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // IDTxt_Search
            // 
            this.IDTxt_Search.Location = new System.Drawing.Point(100, 94);
            this.IDTxt_Search.Name = "IDTxt_Search";
            this.IDTxt_Search.Size = new System.Drawing.Size(341, 20);
            this.IDTxt_Search.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Search Documents";
            // 
            // Result
            // 
            this.Result.Controls.Add(this.DeleteButton);
            this.Result.Controls.Add(this.SearchAllButton);
            this.Result.Controls.Add(this.dataGridView1);
            this.Result.Controls.Add(this.button2);
            this.Result.Controls.Add(this.OpenDocButton);
            this.Result.Location = new System.Drawing.Point(4, 22);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(514, 486);
            this.Result.TabIndex = 2;
            this.Result.Text = "Kết quả tìm kiếm";
            this.Result.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(305, 381);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SearchAllButton
            // 
            this.SearchAllButton.Location = new System.Drawing.Point(401, 381);
            this.SearchAllButton.Name = "SearchAllButton";
            this.SearchAllButton.Size = new System.Drawing.Size(75, 23);
            this.SearchAllButton.TabIndex = 4;
            this.SearchAllButton.Text = "Search All";
            this.SearchAllButton.UseVisualStyleBackColor = true;
            this.SearchAllButton.Click += new System.EventHandler(this.SearchAllButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DatabaseID,
            this.ID,
            this.Vv,
            this.Date,
            this.Category,
            this.Path});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(505, 371);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // DatabaseID
            // 
            this.DatabaseID.HeaderText = "Database ID";
            this.DatabaseID.Name = "DatabaseID";
            this.DatabaseID.Width = 92;
            // 
            // ID
            // 
            this.ID.HeaderText = "DocumentID";
            this.ID.Name = "ID";
            // 
            // Vv
            // 
            this.Vv.HeaderText = "Ve Viec";
            this.Vv.Name = "Vv";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // Path
            // 
            this.Path.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Path.HeaderText = "Full Path";
            this.Path.Name = "Path";
            this.Path.Width = 73;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(185, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Open Container";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // OpenDocButton
            // 
            this.OpenDocButton.Enabled = false;
            this.OpenDocButton.Location = new System.Drawing.Point(89, 380);
            this.OpenDocButton.Name = "OpenDocButton";
            this.OpenDocButton.Size = new System.Drawing.Size(75, 23);
            this.OpenDocButton.TabIndex = 1;
            this.OpenDocButton.Text = "Open Doc";
            this.OpenDocButton.UseVisualStyleBackColor = true;
            this.OpenDocButton.Click += new System.EventHandler(this.OpenDocButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // OperationalRegionLabel
            // 
            this.OperationalRegionLabel.AutoSize = true;
            this.OperationalRegionLabel.Location = new System.Drawing.Point(125, 97);
            this.OperationalRegionLabel.Name = "OperationalRegionLabel";
            this.OperationalRegionLabel.Size = new System.Drawing.Size(41, 13);
            this.OperationalRegionLabel.TabIndex = 12;
            this.OperationalRegionLabel.Text = "label24";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(47, 207);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(71, 13);
            this.label24.TabIndex = 13;
            this.label24.Text = "Số đoàn viên";
            // 
            // NumberOfMembersLabel
            // 
            this.NumberOfMembersLabel.AutoSize = true;
            this.NumberOfMembersLabel.Location = new System.Drawing.Point(155, 207);
            this.NumberOfMembersLabel.Name = "NumberOfMembersLabel";
            this.NumberOfMembersLabel.Size = new System.Drawing.Size(41, 13);
            this.NumberOfMembersLabel.TabIndex = 14;
            this.NumberOfMembersLabel.Text = "label26";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 516);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.NewItem.ResumeLayout(false);
            this.NewItem.PerformLayout();
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Result.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage NewItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage Search;
        private System.Windows.Forms.TextBox IncomingDocID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IDTxt_Search;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SearchDocVv;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage Result;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button OpenDocButton;
        private System.Windows.Forms.DateTimePicker IncomingDocDatetime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton FromDateRadioBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton FromDateToDateRadioBtn;
        private System.Windows.Forms.RadioButton ToDateRadioBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker SearchDoc_DateTimeTo;
        private System.Windows.Forms.DateTimePicker SearchDoc_DateTimeFrom;
        private System.Windows.Forms.RadioButton NoDateRadioBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button SearchAllButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatabaseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.TextBox KeywordTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox ChiDoanComboBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TermTo;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label TermFrom;
        private System.Windows.Forms.Label OperationalRegionLabel;
        private System.Windows.Forms.Label NumberOfMembersLabel;
        private System.Windows.Forms.Label label24;
    }
}

