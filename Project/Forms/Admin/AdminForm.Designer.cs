namespace Project
{
    partial class AdminForm
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
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.CinemaCheck = new System.Windows.Forms.RadioButton();
            this.MovieCheck = new System.Windows.Forms.RadioButton();
            this.MainCheck = new System.Windows.Forms.RadioButton();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.PanelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLeft
            // 
            this.PanelLeft.Controls.Add(this.CinemaCheck);
            this.PanelLeft.Controls.Add(this.MovieCheck);
            this.PanelLeft.Controls.Add(this.MainCheck);
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.Location = new System.Drawing.Point(0, 0);
            this.PanelLeft.Margin = new System.Windows.Forms.Padding(0);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(200, 451);
            this.PanelLeft.TabIndex = 0;
            // 
            // CinemaCheck
            // 
            this.CinemaCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.CinemaCheck.Dock = System.Windows.Forms.DockStyle.Top;
            this.CinemaCheck.Location = new System.Drawing.Point(0, 48);
            this.CinemaCheck.Name = "CinemaCheck";
            this.CinemaCheck.Size = new System.Drawing.Size(200, 24);
            this.CinemaCheck.TabIndex = 2;
            this.CinemaCheck.Text = "radioButton3";
            this.CinemaCheck.UseVisualStyleBackColor = true;
            // 
            // MovieCheck
            // 
            this.MovieCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.MovieCheck.Dock = System.Windows.Forms.DockStyle.Top;
            this.MovieCheck.Location = new System.Drawing.Point(0, 24);
            this.MovieCheck.Name = "MovieCheck";
            this.MovieCheck.Size = new System.Drawing.Size(200, 24);
            this.MovieCheck.TabIndex = 1;
            this.MovieCheck.Text = "radioButton2";
            this.MovieCheck.UseVisualStyleBackColor = true;
            this.MovieCheck.CheckedChanged += new System.EventHandler(this.btn_CheckedChanged);
            // 
            // MainCheck
            // 
            this.MainCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.MainCheck.Checked = true;
            this.MainCheck.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainCheck.Location = new System.Drawing.Point(0, 0);
            this.MainCheck.Name = "MainCheck";
            this.MainCheck.Size = new System.Drawing.Size(200, 24);
            this.MainCheck.TabIndex = 0;
            this.MainCheck.TabStop = true;
            this.MainCheck.Text = "radioButton1";
            this.MainCheck.UseVisualStyleBackColor = true;
            this.MainCheck.CheckedChanged += new System.EventHandler(this.btn_CheckedChanged);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.Location = new System.Drawing.Point(200, 0);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(584, 450);
            this.ContentPanel.TabIndex = 1;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 451);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.PanelLeft);
            this.Name = "AdminForm";
            this.Text = "MainForm";
            this.PanelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.RadioButton CinemaCheck;
        private System.Windows.Forms.RadioButton MovieCheck;
        private System.Windows.Forms.RadioButton MainCheck;
        private System.Windows.Forms.Panel ContentPanel;
    }
}