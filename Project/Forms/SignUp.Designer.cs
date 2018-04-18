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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.TB_Id = new System.Windows.Forms.TextBox();
            this.TB_password = new System.Windows.Forms.TextBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_phone = new System.Windows.Forms.TextBox();
            this.TB_address = new System.Windows.Forms.TextBox();
            this.btn_signup = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_Id
            // 
            this.TB_Id.Location = new System.Drawing.Point(347, 195);
            this.TB_Id.Name = "TB_Id";
            this.TB_Id.Size = new System.Drawing.Size(462, 21);
            this.TB_Id.TabIndex = 0;
            // 
            // TB_password
            // 
            this.TB_password.Location = new System.Drawing.Point(347, 275);
            this.TB_password.Name = "TB_password";
            this.TB_password.Size = new System.Drawing.Size(462, 21);
            this.TB_password.TabIndex = 1;
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(347, 361);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(462, 21);
            this.TB_Name.TabIndex = 2;
            // 
            // TB_phone
            // 
            this.TB_phone.Location = new System.Drawing.Point(347, 442);
            this.TB_phone.Name = "TB_phone";
            this.TB_phone.Size = new System.Drawing.Size(462, 21);
            this.TB_phone.TabIndex = 3;
            // 
            // TB_address
            // 
            this.TB_address.Location = new System.Drawing.Point(347, 535);
            this.TB_address.Name = "TB_address";
            this.TB_address.Size = new System.Drawing.Size(462, 21);
            this.TB_address.TabIndex = 4;
            // 
            // btn_signup
            // 
            this.btn_signup.Location = new System.Drawing.Point(313, 610);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(44, 68);
            this.btn_signup.TabIndex = 5;
            this.btn_signup.Text = "회원가입";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(768, 581);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(41, 68);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "뒤로가기";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(4, 359);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 36);
            this.panel1.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(951, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 36);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Paint += new System.Windows.Forms.PaintEventHandler(this.button3_Paint);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(1001, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 36);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1044, 756);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.TB_address);
            this.Controls.Add(this.TB_phone);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.TB_password);
            this.Controls.Add(this.TB_Id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}