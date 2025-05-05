namespace GU2.Forms
{
    partial class NewJob
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.btnSaveJob = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtJobAdUrl = new System.Windows.Forms.TextBox();
            this.lblJobAdUrl = new System.Windows.Forms.Label();
            this.btnPasteJobAd = new System.Windows.Forms.Button();
            this.ClosingDateSelector = new System.Windows.Forms.DateTimePicker();
            this.lblClosingDate = new System.Windows.Forms.Label();
            this.numJobImportance = new System.Windows.Forms.NumericUpDown();
            this.lblJobImportance = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numJobImportance)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(8, 124);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(226, 18);
            this.lblStatus.TabIndex = 24;
            this.lblStatus.Text = "Select Status of application";
            // 
            // comboStatus
            // 
            this.comboStatus.BackColor = System.Drawing.Color.White;
            this.comboStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Location = new System.Drawing.Point(10, 145);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(316, 23);
            this.comboStatus.TabIndex = 23;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(8, 64);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(133, 18);
            this.lblCompanyName.TabIndex = 22;
            this.lblCompanyName.Text = "Company Name";
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobTitle.Location = new System.Drawing.Point(12, 25);
            this.txtJobTitle.Multiline = true;
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(315, 26);
            this.txtJobTitle.TabIndex = 1;
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobTitle.Location = new System.Drawing.Point(9, 4);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(75, 18);
            this.lblJobTitle.TabIndex = 20;
            this.lblJobTitle.Text = "Job Title";
            // 
            // btnSaveJob
            // 
            this.btnSaveJob.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSaveJob.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnSaveJob.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnSaveJob.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSaveJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveJob.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSaveJob.Location = new System.Drawing.Point(165, 532);
            this.btnSaveJob.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveJob.Name = "btnSaveJob";
            this.btnSaveJob.Size = new System.Drawing.Size(161, 35);
            this.btnSaveJob.TabIndex = 19;
            this.btnSaveJob.TabStop = false;
            this.btnSaveJob.Text = "Save Job";
            this.btnSaveJob.UseVisualStyleBackColor = false;
            this.btnSaveJob.Click += new System.EventHandler(this.btnSaveJob_Click);
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
            this.btnClose.Location = new System.Drawing.Point(12, 532);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 35);
            this.btnClose.TabIndex = 18;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.Location = new System.Drawing.Point(11, 85);
            this.txtCompanyName.Multiline = true;
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(315, 26);
            this.txtCompanyName.TabIndex = 2;
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(12, 202);
            this.txtSalary.Multiline = true;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(315, 26);
            this.txtSalary.TabIndex = 28;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(9, 181);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(125, 18);
            this.lblSalary.TabIndex = 27;
            this.lblSalary.Text = "Salary (Yearly)";
            // 
            // txtJobAdUrl
            // 
            this.txtJobAdUrl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobAdUrl.Location = new System.Drawing.Point(12, 261);
            this.txtJobAdUrl.Multiline = true;
            this.txtJobAdUrl.Name = "txtJobAdUrl";
            this.txtJobAdUrl.Size = new System.Drawing.Size(315, 26);
            this.txtJobAdUrl.TabIndex = 30;
            // 
            // lblJobAdUrl
            // 
            this.lblJobAdUrl.AutoSize = true;
            this.lblJobAdUrl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobAdUrl.Location = new System.Drawing.Point(9, 240);
            this.lblJobAdUrl.Name = "lblJobAdUrl";
            this.lblJobAdUrl.Size = new System.Drawing.Size(120, 18);
            this.lblJobAdUrl.TabIndex = 29;
            this.lblJobAdUrl.Text = "Link to Job Ad";
            // 
            // btnPasteJobAd
            // 
            this.btnPasteJobAd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPasteJobAd.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnPasteJobAd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnPasteJobAd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPasteJobAd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasteJobAd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasteJobAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPasteJobAd.Location = new System.Drawing.Point(334, 261);
            this.btnPasteJobAd.Margin = new System.Windows.Forms.Padding(4);
            this.btnPasteJobAd.Name = "btnPasteJobAd";
            this.btnPasteJobAd.Size = new System.Drawing.Size(59, 27);
            this.btnPasteJobAd.TabIndex = 31;
            this.btnPasteJobAd.TabStop = false;
            this.btnPasteJobAd.Text = "Paste";
            this.btnPasteJobAd.UseVisualStyleBackColor = false;
            this.btnPasteJobAd.Click += new System.EventHandler(this.btnPasteJobAd_Click);
            // 
            // ClosingDateSelector
            // 
            this.ClosingDateSelector.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClosingDateSelector.Location = new System.Drawing.Point(10, 323);
            this.ClosingDateSelector.Name = "ClosingDateSelector";
            this.ClosingDateSelector.Size = new System.Drawing.Size(212, 25);
            this.ClosingDateSelector.TabIndex = 33;
            this.ClosingDateSelector.Value = new System.DateTime(2025, 4, 29, 13, 26, 16, 0);
            // 
            // lblClosingDate
            // 
            this.lblClosingDate.AutoSize = true;
            this.lblClosingDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClosingDate.Location = new System.Drawing.Point(9, 302);
            this.lblClosingDate.Name = "lblClosingDate";
            this.lblClosingDate.Size = new System.Drawing.Size(109, 18);
            this.lblClosingDate.TabIndex = 34;
            this.lblClosingDate.Text = "Closing Date";
            // 
            // numJobImportance
            // 
            this.numJobImportance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numJobImportance.Location = new System.Drawing.Point(149, 365);
            this.numJobImportance.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numJobImportance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numJobImportance.Name = "numJobImportance";
            this.numJobImportance.Size = new System.Drawing.Size(35, 26);
            this.numJobImportance.TabIndex = 37;
            this.numJobImportance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblJobImportance
            // 
            this.lblJobImportance.AutoSize = true;
            this.lblJobImportance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobImportance.Location = new System.Drawing.Point(9, 367);
            this.lblJobImportance.Name = "lblJobImportance";
            this.lblJobImportance.Size = new System.Drawing.Size(142, 18);
            this.lblJobImportance.TabIndex = 38;
            this.lblJobImportance.Text = "Job Importance: ";
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNotes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(12, 432);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(315, 93);
            this.txtNotes.TabIndex = 40;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(9, 411);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(55, 18);
            this.lblNotes.TabIndex = 39;
            this.lblNotes.Text = "Notes";
            // 
            // NewJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(401, 580);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblJobImportance);
            this.Controls.Add(this.numJobImportance);
            this.Controls.Add(this.lblClosingDate);
            this.Controls.Add(this.ClosingDateSelector);
            this.Controls.Add(this.btnPasteJobAd);
            this.Controls.Add(this.txtJobAdUrl);
            this.Controls.Add(this.lblJobAdUrl);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.txtJobTitle);
            this.Controls.Add(this.lblJobTitle);
            this.Controls.Add(this.btnSaveJob);
            this.Controls.Add(this.btnClose);
            this.Name = "NewJob";
            this.Text = "NewJob";
            this.Load += new System.EventHandler(this.NewJob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numJobImportance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.Button btnSaveJob;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtJobAdUrl;
        private System.Windows.Forms.Label lblJobAdUrl;
        private System.Windows.Forms.Button btnPasteJobAd;
        private System.Windows.Forms.DateTimePicker ClosingDateSelector;
        private System.Windows.Forms.Label lblClosingDate;
        private System.Windows.Forms.NumericUpDown numJobImportance;
        private System.Windows.Forms.Label lblJobImportance;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
    }
}