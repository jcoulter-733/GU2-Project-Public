namespace GU2.Forms
{
    partial class Dashboard
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
            this.btnViewQuestions = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnViewJobs = new System.Windows.Forms.Button();
            this.btnSimInterview = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblInfoPanel = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewQuestions
            // 
            this.btnViewQuestions.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnViewQuestions.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnViewQuestions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnViewQuestions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnViewQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewQuestions.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnViewQuestions.Location = new System.Drawing.Point(13, 83);
            this.btnViewQuestions.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewQuestions.Name = "btnViewQuestions";
            this.btnViewQuestions.Size = new System.Drawing.Size(268, 140);
            this.btnViewQuestions.TabIndex = 1;
            this.btnViewQuestions.TabStop = false;
            this.btnViewQuestions.Text = "View All Interview Questions";
            this.btnViewQuestions.UseVisualStyleBackColor = false;
            this.btnViewQuestions.Click += new System.EventHandler(this.btnViewQuestions_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(252, 32);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Hello, {Username}";
            // 
            // btnViewJobs
            // 
            this.btnViewJobs.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnViewJobs.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnViewJobs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnViewJobs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnViewJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewJobs.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewJobs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnViewJobs.Location = new System.Drawing.Point(289, 83);
            this.btnViewJobs.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewJobs.Name = "btnViewJobs";
            this.btnViewJobs.Size = new System.Drawing.Size(268, 140);
            this.btnViewJobs.TabIndex = 5;
            this.btnViewJobs.TabStop = false;
            this.btnViewJobs.Text = "View Your Saved Jobs";
            this.btnViewJobs.UseVisualStyleBackColor = false;
            this.btnViewJobs.Click += new System.EventHandler(this.btnViewJobs_Click);
            // 
            // btnSimInterview
            // 
            this.btnSimInterview.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSimInterview.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnSimInterview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnSimInterview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSimInterview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimInterview.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimInterview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSimInterview.Location = new System.Drawing.Point(13, 231);
            this.btnSimInterview.Margin = new System.Windows.Forms.Padding(4);
            this.btnSimInterview.Name = "btnSimInterview";
            this.btnSimInterview.Size = new System.Drawing.Size(268, 140);
            this.btnSimInterview.TabIndex = 6;
            this.btnSimInterview.TabStop = false;
            this.btnSimInterview.Text = "Simulate an Interview";
            this.btnSimInterview.UseVisualStyleBackColor = false;
            this.btnSimInterview.Click += new System.EventHandler(this.btnSimInterview_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSettings.Location = new System.Drawing.Point(289, 231);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(268, 140);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.TabStop = false;
            this.btnSettings.Text = "Account Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lblInfoPanel
            // 
            this.lblInfoPanel.AutoSize = true;
            this.lblInfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfoPanel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblInfoPanel.Location = new System.Drawing.Point(564, 83);
            this.lblInfoPanel.Name = "lblInfoPanel";
            this.lblInfoPanel.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.lblInfoPanel.Size = new System.Drawing.Size(256, 286);
            this.lblInfoPanel.TabIndex = 8;
            this.lblInfoPanel.Text = "Questions Loaded: 0\r\nUser Questions Loaded: 0\r\nJobs Loaded: 0\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n" +
    "";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLogout.Location = new System.Drawing.Point(454, 410);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(103, 48);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.TabStop = false;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnExit.Location = new System.Drawing.Point(13, 410);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(213, 48);
            this.btnExit.TabIndex = 10;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Close Application";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(890, 479);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblInfoPanel);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnSimInterview);
            this.Controls.Add(this.btnViewJobs);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnViewQuestions);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewQuestions;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnViewJobs;
        private System.Windows.Forms.Button btnSimInterview;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblInfoPanel;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnExit;
    }
}