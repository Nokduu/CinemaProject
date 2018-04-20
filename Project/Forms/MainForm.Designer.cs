namespace Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.CinemaCheck = new System.Windows.Forms.RadioButton();
            this.MovieCheck = new System.Windows.Forms.RadioButton();
            this.MainCheck = new System.Windows.Forms.RadioButton();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PanelLeft.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.Silver;
            this.PanelLeft.Controls.Add(this.panel1);
            this.PanelLeft.Controls.Add(this.button1);
            this.PanelLeft.Controls.Add(this.CinemaCheck);
            this.PanelLeft.Controls.Add(this.MovieCheck);
            this.PanelLeft.Controls.Add(this.MainCheck);
            this.PanelLeft.Location = new System.Drawing.Point(9, 9);
            this.PanelLeft.Margin = new System.Windows.Forms.Padding(0);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(323, 777);
            this.PanelLeft.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "내 정보? (미정)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CinemaCheck
            // 
            this.CinemaCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.CinemaCheck.BackColor = System.Drawing.Color.Transparent;
            this.CinemaCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CinemaCheck.BackgroundImage")));
            this.CinemaCheck.FlatAppearance.BorderSize = 0;
            this.CinemaCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CinemaCheck.Location = new System.Drawing.Point(50, 535);
            this.CinemaCheck.Name = "CinemaCheck";
            this.CinemaCheck.Size = new System.Drawing.Size(215, 70);
            this.CinemaCheck.TabIndex = 2;
            this.CinemaCheck.UseVisualStyleBackColor = false;
            // 
            // MovieCheck
            // 
            this.MovieCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.MovieCheck.BackColor = System.Drawing.Color.Transparent;
            this.MovieCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MovieCheck.BackgroundImage")));
            this.MovieCheck.FlatAppearance.BorderSize = 0;
            this.MovieCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MovieCheck.Location = new System.Drawing.Point(55, 440);
            this.MovieCheck.Name = "MovieCheck";
            this.MovieCheck.Size = new System.Drawing.Size(210, 65);
            this.MovieCheck.TabIndex = 1;
            this.MovieCheck.UseVisualStyleBackColor = false;
            this.MovieCheck.CheckedChanged += new System.EventHandler(this.btn_CheckedChanged);
            // 
            // MainCheck
            // 
            this.MainCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.MainCheck.BackColor = System.Drawing.Color.Transparent;
            this.MainCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainCheck.BackgroundImage")));
            this.MainCheck.Checked = true;
            this.MainCheck.FlatAppearance.BorderSize = 0;
            this.MainCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainCheck.Location = new System.Drawing.Point(60, 360);
            this.MainCheck.Name = "MainCheck";
            this.MainCheck.Size = new System.Drawing.Size(195, 45);
            this.MainCheck.TabIndex = 0;
            this.MainCheck.TabStop = true;
            this.MainCheck.UseVisualStyleBackColor = false;
            this.MainCheck.CheckedChanged += new System.EventHandler(this.btn_CheckedChanged);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Location = new System.Drawing.Point(9, 9);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(323, 777);
            this.ContentPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(70, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 170);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1037, 36);
            this.panel2.TabIndex = 7;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(240)))), ((int)(((byte)(229)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1060, 795);
            this.Controls.Add(this.PanelLeft);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.PanelLeft.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.RadioButton CinemaCheck;
        private System.Windows.Forms.RadioButton MovieCheck;
        private System.Windows.Forms.RadioButton MainCheck;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}