namespace GU2.Forms
{
    partial class AccountSettings
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
            this.btnDeleteAllAnswers = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDeleteAllQuestions = new System.Windows.Forms.Button();
            this.btnDeleteAllJobs = new System.Windows.Forms.Button();
            this.btnDeleteAllData = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnRestoreQuestions = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDeleteAllAnswers
            // 
            this.btnDeleteAllAnswers.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDeleteAllAnswers.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteAllAnswers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteAllAnswers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDeleteAllAnswers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAllAnswers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAllAnswers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDeleteAllAnswers.Location = new System.Drawing.Point(409, 64);
            this.btnDeleteAllAnswers.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteAllAnswers.Name = "btnDeleteAllAnswers";
            this.btnDeleteAllAnswers.Size = new System.Drawing.Size(351, 35);
            this.btnDeleteAllAnswers.TabIndex = 13;
            this.btnDeleteAllAnswers.TabStop = false;
            this.btnDeleteAllAnswers.Text = "Delete All My Answers";
            this.btnDeleteAllAnswers.UseVisualStyleBackColor = false;
            this.btnDeleteAllAnswers.Click += new System.EventHandler(this.btnDeleteAllAnswers_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(252, 32);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Hello, {Username}";
            // 
            // btnDeleteAllQuestions
            // 
            this.btnDeleteAllQuestions.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDeleteAllQuestions.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteAllQuestions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteAllQuestions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDeleteAllQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAllQuestions.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAllQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDeleteAllQuestions.Location = new System.Drawing.Point(409, 116);
            this.btnDeleteAllQuestions.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteAllQuestions.Name = "btnDeleteAllQuestions";
            this.btnDeleteAllQuestions.Size = new System.Drawing.Size(351, 35);
            this.btnDeleteAllQuestions.TabIndex = 15;
            this.btnDeleteAllQuestions.TabStop = false;
            this.btnDeleteAllQuestions.Text = "Delete All My Questions";
            this.btnDeleteAllQuestions.UseVisualStyleBackColor = false;
            this.btnDeleteAllQuestions.Click += new System.EventHandler(this.btnDeleteAllQuestions_Click);
            // 
            // btnDeleteAllJobs
            // 
            this.btnDeleteAllJobs.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDeleteAllJobs.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteAllJobs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteAllJobs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDeleteAllJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAllJobs.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAllJobs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDeleteAllJobs.Location = new System.Drawing.Point(409, 170);
            this.btnDeleteAllJobs.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteAllJobs.Name = "btnDeleteAllJobs";
            this.btnDeleteAllJobs.Size = new System.Drawing.Size(351, 35);
            this.btnDeleteAllJobs.TabIndex = 16;
            this.btnDeleteAllJobs.TabStop = false;
            this.btnDeleteAllJobs.Text = "Delete All My Jobs";
            this.btnDeleteAllJobs.UseVisualStyleBackColor = false;
            this.btnDeleteAllJobs.Click += new System.EventHandler(this.btnDeleteAllJobs_Click);
            // 
            // btnDeleteAllData
            // 
            this.btnDeleteAllData.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDeleteAllData.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteAllData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteAllData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDeleteAllData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAllData.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAllData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDeleteAllData.Location = new System.Drawing.Point(409, 227);
            this.btnDeleteAllData.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteAllData.Name = "btnDeleteAllData";
            this.btnDeleteAllData.Size = new System.Drawing.Size(351, 35);
            this.btnDeleteAllData.TabIndex = 17;
            this.btnDeleteAllData.TabStop = false;
            this.btnDeleteAllData.Text = "Delete All My Data";
            this.btnDeleteAllData.UseVisualStyleBackColor = false;
            this.btnDeleteAllData.Click += new System.EventHandler(this.btnDeleteAllData_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnChangePassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnChangePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnChangePassword.Location = new System.Drawing.Point(18, 199);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(351, 35);
            this.btnChangePassword.TabIndex = 18;
            this.btnChangePassword.TabStop = false;
            this.btnChangePassword.Text = "Change My Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(18, 143);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(351, 32);
            this.txtNewPassword.TabIndex = 19;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDeleteAccount.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDeleteAccount.Location = new System.Drawing.Point(409, 280);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(351, 35);
            this.btnDeleteAccount.TabIndex = 20;
            this.btnDeleteAccount.TabStop = false;
            this.btnDeleteAccount.Text = "Delete My Account";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnRestoreQuestions
            // 
            this.btnRestoreQuestions.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRestoreQuestions.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnRestoreQuestions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnRestoreQuestions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRestoreQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreQuestions.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoreQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRestoreQuestions.Location = new System.Drawing.Point(18, 281);
            this.btnRestoreQuestions.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestoreQuestions.Name = "btnRestoreQuestions";
            this.btnRestoreQuestions.Size = new System.Drawing.Size(351, 35);
            this.btnRestoreQuestions.TabIndex = 21;
            this.btnRestoreQuestions.TabStop = false;
            this.btnRestoreQuestions.Text = "Restore System Questions";
            this.btnRestoreQuestions.UseVisualStyleBackColor = false;
            this.btnRestoreQuestions.Click += new System.EventHandler(this.btnRestoreQuestions_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(15, 122);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(174, 18);
            this.lblPassword.TabIndex = 25;
            this.lblPassword.Text = "Enter New Password";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnClose.Location = new System.Drawing.Point(211, 339);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(245, 35);
            this.btnClose.TabIndex = 26;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPassword.Location = new System.Drawing.Point(15, 57);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(219, 18);
            this.lblCurrentPassword.TabIndex = 28;
            this.lblCurrentPassword.Text = "Confirm Current Password";
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPassword.Location = new System.Drawing.Point(18, 78);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '*';
            this.txtCurrentPassword.Size = new System.Drawing.Size(351, 32);
            this.txtCurrentPassword.TabIndex = 27;
            // 
            // AccountSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(783, 392);
            this.Controls.Add(this.lblCurrentPassword);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnRestoreQuestions);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnDeleteAllData);
            this.Controls.Add(this.btnDeleteAllJobs);
            this.Controls.Add(this.btnDeleteAllQuestions);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnDeleteAllAnswers);
            this.Name = "AccountSettings";
            this.Text = "AccountSettings";
            this.Load += new System.EventHandler(this.AccountSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteAllAnswers;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDeleteAllQuestions;
        private System.Windows.Forms.Button btnDeleteAllJobs;
        private System.Windows.Forms.Button btnDeleteAllData;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnRestoreQuestions;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
    }
}