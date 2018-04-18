namespace Project
{
    partial class LoginForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.TB_id = new System.Windows.Forms.TextBox();
            this.BT_login = new System.Windows.Forms.Button();
            this.TB_pw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TB_id
            // 
            this.TB_id.Location = new System.Drawing.Point(316, 179);
            this.TB_id.Name = "TB_id";
            this.TB_id.Size = new System.Drawing.Size(100, 21);
            this.TB_id.TabIndex = 0;
            // 
            // BT_login
            // 
            this.BT_login.Location = new System.Drawing.Point(422, 179);
            this.BT_login.Name = "BT_login";
            this.BT_login.Size = new System.Drawing.Size(75, 48);
            this.BT_login.TabIndex = 2;
            this.BT_login.Text = "button1";
            this.BT_login.UseVisualStyleBackColor = true;
            this.BT_login.Click += new System.EventHandler(this.BT_login_Click);
            // 
            // TB_pw
            // 
            this.TB_pw.Location = new System.Drawing.Point(316, 206);
            this.TB_pw.Name = "TB_pw";
            this.TB_pw.Size = new System.Drawing.Size(100, 21);
            this.TB_pw.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "회원가입";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 4;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_pw);
            this.Controls.Add(this.BT_login);
            this.Controls.Add(this.TB_id);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_id;
        private System.Windows.Forms.Button BT_login;
        private System.Windows.Forms.TextBox TB_pw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

