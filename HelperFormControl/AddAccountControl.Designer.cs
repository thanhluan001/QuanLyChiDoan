namespace HelperFormControl
{
    partial class AddAccountControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.RetypePassTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ErrorMsgTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Retype password";
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Location = new System.Drawing.Point(150, 62);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(158, 20);
            this.UsernameTxt.TabIndex = 3;
            // 
            // PassTxt
            // 
            this.PassTxt.Location = new System.Drawing.Point(150, 98);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.PasswordChar = '●';
            this.PassTxt.Size = new System.Drawing.Size(158, 20);
            this.PassTxt.TabIndex = 4;
            // 
            // RetypePassTxt
            // 
            this.RetypePassTxt.Location = new System.Drawing.Point(150, 135);
            this.RetypePassTxt.Name = "RetypePassTxt";
            this.RetypePassTxt.PasswordChar = '●';
            this.RetypePassTxt.Size = new System.Drawing.Size(158, 20);
            this.RetypePassTxt.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ErrorMsgTxt
            // 
            this.ErrorMsgTxt.AutoSize = true;
            this.ErrorMsgTxt.Location = new System.Drawing.Point(46, 25);
            this.ErrorMsgTxt.Name = "ErrorMsgTxt";
            this.ErrorMsgTxt.Size = new System.Drawing.Size(0, 13);
            this.ErrorMsgTxt.TabIndex = 7;
            // 
            // AddAccountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ErrorMsgTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RetypePassTxt);
            this.Controls.Add(this.PassTxt);
            this.Controls.Add(this.UsernameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddAccountControl";
            this.Size = new System.Drawing.Size(361, 250);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.TextBox PassTxt;
        private System.Windows.Forms.TextBox RetypePassTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ErrorMsgTxt;
    }
}
