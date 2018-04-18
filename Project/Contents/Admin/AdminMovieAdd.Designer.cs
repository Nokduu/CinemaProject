namespace Project.Contents.Admin
{
    partial class AdminMovieAdd
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
            this.TB_MovieNo = new System.Windows.Forms.TextBox();
            this.TB_MovieTitle = new System.Windows.Forms.TextBox();
            this.TB_MovieGenre = new System.Windows.Forms.TextBox();
            this.DTP_playdate = new System.Windows.Forms.DateTimePicker();
            this.DTP_time = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BTN_image = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_MovieNo
            // 
            this.TB_MovieNo.Location = new System.Drawing.Point(321, 12);
            this.TB_MovieNo.Name = "TB_MovieNo";
            this.TB_MovieNo.Size = new System.Drawing.Size(100, 21);
            this.TB_MovieNo.TabIndex = 0;
            // 
            // TB_MovieTitle
            // 
            this.TB_MovieTitle.Location = new System.Drawing.Point(321, 39);
            this.TB_MovieTitle.Name = "TB_MovieTitle";
            this.TB_MovieTitle.Size = new System.Drawing.Size(100, 21);
            this.TB_MovieTitle.TabIndex = 1;
            // 
            // TB_MovieGenre
            // 
            this.TB_MovieGenre.Location = new System.Drawing.Point(321, 66);
            this.TB_MovieGenre.Name = "TB_MovieGenre";
            this.TB_MovieGenre.Size = new System.Drawing.Size(100, 21);
            this.TB_MovieGenre.TabIndex = 2;
            // 
            // DTP_playdate
            // 
            this.DTP_playdate.CustomFormat = "";
            this.DTP_playdate.Location = new System.Drawing.Point(321, 93);
            this.DTP_playdate.Name = "DTP_playdate";
            this.DTP_playdate.Size = new System.Drawing.Size(100, 21);
            this.DTP_playdate.TabIndex = 3;
            this.DTP_playdate.Value = new System.DateTime(2018, 4, 17, 0, 0, 0, 0);
            // 
            // DTP_time
            // 
            this.DTP_time.CustomFormat = "";
            this.DTP_time.Location = new System.Drawing.Point(321, 120);
            this.DTP_time.Name = "DTP_time";
            this.DTP_time.ShowUpDown = true;
            this.DTP_time.Size = new System.Drawing.Size(100, 21);
            this.DTP_time.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources.NoImage;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 289);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.AddExtension = false;
            this.openFileDialog1.Filter = "Images|*.png;*.jpg;*.jpeg;*.bmp;";
            // 
            // BTN_image
            // 
            this.BTN_image.Location = new System.Drawing.Point(321, 147);
            this.BTN_image.Name = "BTN_image";
            this.BTN_image.Size = new System.Drawing.Size(100, 25);
            this.BTN_image.TabIndex = 6;
            this.BTN_image.Text = "등록";
            this.BTN_image.UseVisualStyleBackColor = true;
            this.BTN_image.Click += new System.EventHandler(this.BTN_image_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "영화 번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "영화 제목";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "영화 장르";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "영화 개봉일";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "영화 상영시간";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "영화 이미지";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "등록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Insert_Movie);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(341, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "취소";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Exit_Click);
            // 
            // AdminMovieAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 313);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_image);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DTP_time);
            this.Controls.Add(this.DTP_playdate);
            this.Controls.Add(this.TB_MovieGenre);
            this.Controls.Add(this.TB_MovieTitle);
            this.Controls.Add(this.TB_MovieNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMovieAdd";
            this.Text = "AdminMovieAdd";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_MovieNo;
        private System.Windows.Forms.TextBox TB_MovieTitle;
        private System.Windows.Forms.TextBox TB_MovieGenre;
        private System.Windows.Forms.DateTimePicker DTP_playdate;
        private System.Windows.Forms.DateTimePicker DTP_time;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BTN_image;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}