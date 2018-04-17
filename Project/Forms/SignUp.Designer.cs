namespace Project.Forms
{
    partial class SignUp
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
            this.TB_Id = new System.Windows.Forms.TextBox();
            this.TB_password = new System.Windows.Forms.TextBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_phone = new System.Windows.Forms.TextBox();
            this.TB_address = new System.Windows.Forms.TextBox();
            this.btn_signup = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_Id
            // 
            this.TB_Id.Location = new System.Drawing.Point(190, 77);
            this.TB_Id.Name = "TB_Id";
            this.TB_Id.Size = new System.Drawing.Size(100, 21);
            this.TB_Id.TabIndex = 0;
            // 
            // TB_password
            // 
            this.TB_password.Location = new System.Drawing.Point(190, 104);
            this.TB_password.Name = "TB_password";
            this.TB_password.Size = new System.Drawing.Size(100, 21);
            this.TB_password.TabIndex = 1;
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(190, 131);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(100, 21);
            this.TB_Name.TabIndex = 2;
            // 
            // TB_phone
            // 
            this.TB_phone.Location = new System.Drawing.Point(190, 158);
            this.TB_phone.Name = "TB_phone";
            this.TB_phone.Size = new System.Drawing.Size(100, 21);
            this.TB_phone.TabIndex = 3;
            // 
            // TB_address
            // 
            this.TB_address.Location = new System.Drawing.Point(190, 185);
            this.TB_address.Name = "TB_address";
            this.TB_address.Size = new System.Drawing.Size(100, 21);
            this.TB_address.TabIndex = 4;
            // 
            // btn_signup
            // 
            this.btn_signup.Location = new System.Drawing.Point(190, 233);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(44, 68);
            this.btn_signup.TabIndex = 5;
            this.btn_signup.Text = "회원가입";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(249, 233);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(41, 68);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "뒤로가기";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.TB_address);
            this.Controls.Add(this.TB_phone);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.TB_password);
            this.Controls.Add(this.TB_Id);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Id;
        private System.Windows.Forms.TextBox TB_password;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TextBox TB_phone;
        private System.Windows.Forms.TextBox TB_address;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Button btn_back;
    }
}