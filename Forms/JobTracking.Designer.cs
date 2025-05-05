namespace GU2.Forms
{
    partial class JobTracking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobTracking));
            this.DataGridViewer = new System.Windows.Forms.DataGridView();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.chkHideAppliedJobs = new System.Windows.Forms.CheckBox();
            this.chkShowUpcoming = new System.Windows.Forms.CheckBox();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.lblSelectedJob = new System.Windows.Forms.Label();
            this.btnViewJobAd = new System.Windows.Forms.Button();
            this.btnDeleteJob = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditJob = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewer)).BeginInit();
            this.gbFilters.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridViewer
            // 
            this.DataGridViewer.AllowUserToAddRows = false;
            this.DataGridViewer.AllowUserToDeleteRows = false;
            this.DataGridViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DataGridViewer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridViewer.BackgroundColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewer.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewer.EnableHeadersVisualStyles = false;
            this.DataGridViewer.GridColor = System.Drawing.Color.DimGray;
            this.DataGridViewer.Location = new System.Drawing.Point(12, 48);
            this.DataGridViewer.MultiSelect = false;
            this.DataGridViewer.Name = "DataGridViewer";
            this.DataGridViewer.ReadOnly = true;
            this.DataGridViewer.RowHeadersVisible = false;
            this.DataGridViewer.RowHeadersWidth = 72;
            this.DataGridViewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewer.Size = new System.Drawing.Size(1053, 316);
            this.DataGridViewer.TabIndex = 8;
            this.DataGridViewer.SelectionChanged += new System.EventHandler(this.DataGridViewer_SelectionChanged);
            // 
            // btnAddJob
            // 
            this.btnAddJob.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddJob.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnAddJob.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnAddJob.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddJob.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAddJob.Location = new System.Drawing.Point(13, 6);
            this.btnAddJob.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(193, 35);
            this.btnAddJob.TabIndex = 12;
            this.btnAddJob.TabStop = false;
            this.btnAddJob.Text = "Add a new Job";
            this.btnAddJob.UseVisualStyleBackColor = false;
            this.btnAddJob.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.chkHideAppliedJobs);
            this.gbFilters.Controls.Add(this.chkShowUpcoming);
            this.gbFilters.Controls.Add(this.lblKeyword);
            this.gbFilters.Controls.Add(this.txtKeyword);
            this.gbFilters.Controls.Add(this.btnClearFilters);
            this.gbFilters.Controls.Add(this.btnFilter);
            this.gbFilters.Controls.Add(this.lblStatus);
            this.gbFilters.Controls.Add(this.comboStatus);
            this.gbFilters.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilters.Location = new System.Drawing.Point(1071, 48);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(209, 211);
            this.gbFilters.TabIndex = 13;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filters";
            // 
            // chkHideAppliedJobs
            // 
            this.chkHideAppliedJobs.AutoSize = true;
            this.chkHideAppliedJobs.Location = new System.Drawing.Point(6, 81);
            this.chkHideAppliedJobs.Name = "chkHideAppliedJobs";
            this.chkHideAppliedJobs.Size = new System.Drawing.Size(162, 19);
            this.chkHideAppliedJobs.TabIndex = 21;
            this.chkHideAppliedJobs.Text = "Hide Applied for Jobs";
            this.chkHideAppliedJobs.UseVisualStyleBackColor = true;
            // 
            // chkShowUpcoming
            // 
            this.chkShowUpcoming.AutoSize = true;
            this.chkShowUpcoming.Location = new System.Drawing.Point(6, 62);
            this.chkShowUpcoming.Name = "chkShowUpcoming";
            this.chkShowUpcoming.Size = new System.Drawing.Size(196, 19);
            this.chkShowUpcoming.TabIndex = 20;
            this.chkShowUpcoming.Text = "Show Upcoming Jobs Only";
            this.chkShowUpcoming.UseVisualStyleBackColor = true;
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyword.Location = new System.Drawing.Point(8, 115);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(133, 15);
            this.lblKeyword.TabIndex = 18;
            this.lblKeyword.Text = "Keyword (Job Title)";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(9, 133);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(195, 23);
            this.txtKeyword.TabIndex = 12;
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClearFilters.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnClearFilters.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnClearFilters.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnClearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilters.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFilters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnClearFilters.Location = new System.Drawing.Point(7, 158);
            this.btnClearFilters.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(62, 35);
            this.btnClearFilters.TabIndex = 17;
            this.btnClearFilters.TabStop = false;
            this.btnClearFilters.Text = "Reset";
            this.btnClearFilters.UseVisualStyleBackColor = false;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnFilter.Location = new System.Drawing.Point(140, 158);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(62, 35);
            this.btnFilter.TabIndex = 12;
            this.btnFilter.TabStop = false;
            this.btnFilter.Text = "Go";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(3, 19);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 15);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status";
            // 
            // comboStatus
            // 
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Location = new System.Drawing.Point(6, 37);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(197, 23);
            this.comboStatus.TabIndex = 10;
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblJobTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblJobTitle.Location = new System.Drawing.Point(4, 4);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(1050, 60);
            this.lblJobTitle.TabIndex = 14;
            this.lblJobTitle.Text = "Job Title at Company Name";
            this.lblJobTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectedJob
            // 
            this.lblSelectedJob.BackColor = System.Drawing.Color.Gray;
            this.lblSelectedJob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSelectedJob.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedJob.Location = new System.Drawing.Point(4, 64);
            this.lblSelectedJob.Name = "lblSelectedJob";
            this.lblSelectedJob.Size = new System.Drawing.Size(1049, 166);
            this.lblSelectedJob.TabIndex = 15;
            this.lblSelectedJob.Text = resources.GetString("lblSelectedJob.Text");
            // 
            // btnViewJobAd
            // 
            this.btnViewJobAd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnViewJobAd.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnViewJobAd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnViewJobAd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnViewJobAd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewJobAd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewJobAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnViewJobAd.Location = new System.Drawing.Point(895, 68);
            this.btnViewJobAd.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewJobAd.Name = "btnViewJobAd";
            this.btnViewJobAd.Size = new System.Drawing.Size(149, 35);
            this.btnViewJobAd.TabIndex = 16;
            this.btnViewJobAd.TabStop = false;
            this.btnViewJobAd.Text = "View Job Ad";
            this.btnViewJobAd.UseVisualStyleBackColor = false;
            this.btnViewJobAd.Visible = false;
            this.btnViewJobAd.Click += new System.EventHandler(this.btnViewJobAd_Click);
            // 
            // btnDeleteJob
            // 
            this.btnDeleteJob.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDeleteJob.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteJob.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteJob.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDeleteJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteJob.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDeleteJob.Location = new System.Drawing.Point(13, 617);
            this.btnDeleteJob.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteJob.Name = "btnDeleteJob";
            this.btnDeleteJob.Size = new System.Drawing.Size(149, 35);
            this.btnDeleteJob.TabIndex = 17;
            this.btnDeleteJob.TabStop = false;
            this.btnDeleteJob.Text = "Delete Job";
            this.btnDeleteJob.UseVisualStyleBackColor = false;
            this.btnDeleteJob.Visible = false;
            this.btnDeleteJob.Click += new System.EventHandler(this.btnDeleteJob_Click);
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
            this.btnClose.Location = new System.Drawing.Point(1130, 617);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(149, 35);
            this.btnClose.TabIndex = 18;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnEditJob);
            this.panel1.Controls.Add(this.btnViewJobAd);
            this.panel1.Controls.Add(this.lblSelectedJob);
            this.panel1.Controls.Add(this.lblJobTitle);
            this.panel1.Location = new System.Drawing.Point(11, 370);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(1060, 236);
            this.panel1.TabIndex = 19;
            
            // 
            // btnEditJob
            // 
            this.btnEditJob.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditJob.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnEditJob.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnEditJob.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEditJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditJob.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnEditJob.Location = new System.Drawing.Point(895, 181);
            this.btnEditJob.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditJob.Name = "btnEditJob";
            this.btnEditJob.Size = new System.Drawing.Size(149, 35);
            this.btnEditJob.TabIndex = 17;
            this.btnEditJob.TabStop = false;
            this.btnEditJob.Text = "Edit";
            this.btnEditJob.UseVisualStyleBackColor = false;
            this.btnEditJob.Visible = false;
            this.btnEditJob.Click += new System.EventHandler(this.btnEditJob_Click);
            // 
            // JobTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1292, 665);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteJob);
            this.Controls.Add(this.gbFilters);
            this.Controls.Add(this.btnAddJob);
            this.Controls.Add(this.DataGridViewer);
            this.Controls.Add(this.panel1);
            this.Name = "JobTracking";
            this.Text = "Job Tracking";
            this.Load += new System.EventHandler(this.JobTracking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewer)).EndInit();
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewer;
        private System.Windows.Forms.Button btnAddJob;
        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.CheckBox chkHideAppliedJobs;
        private System.Windows.Forms.CheckBox chkShowUpcoming;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.Label lblSelectedJob;
        private System.Windows.Forms.Button btnViewJobAd;
        private System.Windows.Forms.Button btnDeleteJob;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditJob;
    }
}