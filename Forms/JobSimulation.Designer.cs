namespace GU2.Forms
{
    partial class JobSimulation
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
            this.lblQuestionAmount = new System.Windows.Forms.Label();
            this.numQuestions = new System.Windows.Forms.NumericUpDown();
            this.setupPanel = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.chkIncludeAnswered = new System.Windows.Forms.CheckBox();
            this.chkIncludeIcebreaker = new System.Windows.Forms.CheckBox();
            this.btnBeginCustom = new System.Windows.Forms.Button();
            this.btnBeginRandom = new System.Windows.Forms.Button();
            this.btnUserecommended = new System.Windows.Forms.Button();
            this.gbTypes = new System.Windows.Forms.GroupBox();
            this.lblTechnical = new System.Windows.Forms.Label();
            this.lblSituational = new System.Windows.Forms.Label();
            this.numTechnical = new System.Windows.Forms.NumericUpDown();
            this.numSituational = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numPastEvidence = new System.Windows.Forms.NumericUpDown();
            this.lblStrengths = new System.Windows.Forms.Label();
            this.numStrength = new System.Windows.Forms.NumericUpDown();
            this.btnClose = new System.Windows.Forms.Button();
            this.InterviewPanel = new System.Windows.Forms.Panel();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtUserAnswer = new System.Windows.Forms.RichTextBox();
            this.lblAnswerPreview = new System.Windows.Forms.Label();
            this.lblSelectedQuestion = new System.Windows.Forms.Label();
            this.lblInterviewPanelTitle = new System.Windows.Forms.Label();
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.ReportPanel = new System.Windows.Forms.Panel();
            this.lblReportTitle = new System.Windows.Forms.Label();
            this.lblReport = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numQuestions)).BeginInit();
            this.setupPanel.SuspendLayout();
            this.gbTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTechnical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSituational)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPastEvidence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStrength)).BeginInit();
            this.InterviewPanel.SuspendLayout();
            this.ReportPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestionAmount
            // 
            this.lblQuestionAmount.AutoSize = true;
            this.lblQuestionAmount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionAmount.Location = new System.Drawing.Point(301, 14);
            this.lblQuestionAmount.Name = "lblQuestionAmount";
            this.lblQuestionAmount.Size = new System.Drawing.Size(235, 18);
            this.lblQuestionAmount.TabIndex = 13;
            this.lblQuestionAmount.Text = "How many questions to add?";
            // 
            // numQuestions
            // 
            this.numQuestions.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuestions.Location = new System.Drawing.Point(395, 45);
            this.numQuestions.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numQuestions.Name = "numQuestions";
            this.numQuestions.Size = new System.Drawing.Size(42, 26);
            this.numQuestions.TabIndex = 14;
            this.numQuestions.ValueChanged += new System.EventHandler(this.numQuestions_ValueChanged);
            // 
            // setupPanel
            // 
            this.setupPanel.Controls.Add(this.btnReset);
            this.setupPanel.Controls.Add(this.chkIncludeAnswered);
            this.setupPanel.Controls.Add(this.chkIncludeIcebreaker);
            this.setupPanel.Controls.Add(this.btnBeginCustom);
            this.setupPanel.Controls.Add(this.btnBeginRandom);
            this.setupPanel.Controls.Add(this.btnUserecommended);
            this.setupPanel.Controls.Add(this.gbTypes);
            this.setupPanel.Controls.Add(this.lblQuestionAmount);
            this.setupPanel.Controls.Add(this.numQuestions);
            this.setupPanel.Location = new System.Drawing.Point(34, 421);
            this.setupPanel.Name = "setupPanel";
            this.setupPanel.Size = new System.Drawing.Size(564, 285);
            this.setupPanel.TabIndex = 15;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnReset.Location = new System.Drawing.Point(13, 243);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(114, 28);
            this.btnReset.TabIndex = 23;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // chkIncludeAnswered
            // 
            this.chkIncludeAnswered.AutoSize = true;
            this.chkIncludeAnswered.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncludeAnswered.Location = new System.Drawing.Point(309, 103);
            this.chkIncludeAnswered.Name = "chkIncludeAnswered";
            this.chkIncludeAnswered.Size = new System.Drawing.Size(217, 19);
            this.chkIncludeAnswered.TabIndex = 21;
            this.chkIncludeAnswered.Text = "Include Answered Questions?";
            this.chkIncludeAnswered.UseVisualStyleBackColor = true;
            // 
            // chkIncludeIcebreaker
            // 
            this.chkIncludeIcebreaker.AutoSize = true;
            this.chkIncludeIcebreaker.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncludeIcebreaker.Location = new System.Drawing.Point(309, 78);
            this.chkIncludeIcebreaker.Name = "chkIncludeIcebreaker";
            this.chkIncludeIcebreaker.Size = new System.Drawing.Size(216, 19);
            this.chkIncludeIcebreaker.TabIndex = 20;
            this.chkIncludeIcebreaker.Text = "Include Icebreaker Question?";
            this.chkIncludeIcebreaker.UseVisualStyleBackColor = true;
            // 
            // btnBeginCustom
            // 
            this.btnBeginCustom.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBeginCustom.Enabled = false;
            this.btnBeginCustom.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnBeginCustom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnBeginCustom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBeginCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeginCustom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeginCustom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBeginCustom.Location = new System.Drawing.Point(309, 187);
            this.btnBeginCustom.Margin = new System.Windows.Forms.Padding(4);
            this.btnBeginCustom.Name = "btnBeginCustom";
            this.btnBeginCustom.Size = new System.Drawing.Size(227, 48);
            this.btnBeginCustom.TabIndex = 19;
            this.btnBeginCustom.TabStop = false;
            this.btnBeginCustom.Text = "Begin ";
            this.btnBeginCustom.UseVisualStyleBackColor = false;
            this.btnBeginCustom.Click += new System.EventHandler(this.btnBeginCustom_Click);
            // 
            // btnBeginRandom
            // 
            this.btnBeginRandom.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBeginRandom.Enabled = false;
            this.btnBeginRandom.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnBeginRandom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnBeginRandom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBeginRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeginRandom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeginRandom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBeginRandom.Location = new System.Drawing.Point(309, 131);
            this.btnBeginRandom.Margin = new System.Windows.Forms.Padding(4);
            this.btnBeginRandom.Name = "btnBeginRandom";
            this.btnBeginRandom.Size = new System.Drawing.Size(227, 48);
            this.btnBeginRandom.TabIndex = 18;
            this.btnBeginRandom.TabStop = false;
            this.btnBeginRandom.Text = "Begin With 0 Random Questions";
            this.btnBeginRandom.UseVisualStyleBackColor = false;
            this.btnBeginRandom.Click += new System.EventHandler(this.btnBeginRandom_Click);
            // 
            // btnUserecommended
            // 
            this.btnUserecommended.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUserecommended.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnUserecommended.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnUserecommended.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUserecommended.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserecommended.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserecommended.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnUserecommended.Location = new System.Drawing.Point(13, 200);
            this.btnUserecommended.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserecommended.Name = "btnUserecommended";
            this.btnUserecommended.Size = new System.Drawing.Size(238, 35);
            this.btnUserecommended.TabIndex = 17;
            this.btnUserecommended.TabStop = false;
            this.btnUserecommended.Text = "Use Recommended Setup";
            this.btnUserecommended.UseVisualStyleBackColor = false;
            this.btnUserecommended.Click += new System.EventHandler(this.btnUserecommended_Click);
            // 
            // gbTypes
            // 
            this.gbTypes.Controls.Add(this.lblTechnical);
            this.gbTypes.Controls.Add(this.lblSituational);
            this.gbTypes.Controls.Add(this.numTechnical);
            this.gbTypes.Controls.Add(this.numSituational);
            this.gbTypes.Controls.Add(this.label1);
            this.gbTypes.Controls.Add(this.numPastEvidence);
            this.gbTypes.Controls.Add(this.lblStrengths);
            this.gbTypes.Controls.Add(this.numStrength);
            this.gbTypes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTypes.Location = new System.Drawing.Point(13, 14);
            this.gbTypes.Name = "gbTypes";
            this.gbTypes.Size = new System.Drawing.Size(238, 177);
            this.gbTypes.TabIndex = 16;
            this.gbTypes.TabStop = false;
            this.gbTypes.Text = "Select how many of question type";
            // 
            // lblTechnical
            // 
            this.lblTechnical.AutoSize = true;
            this.lblTechnical.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechnical.Location = new System.Drawing.Point(54, 127);
            this.lblTechnical.Name = "lblTechnical";
            this.lblTechnical.Size = new System.Drawing.Size(86, 18);
            this.lblTechnical.TabIndex = 20;
            this.lblTechnical.Text = "Technical";
            // 
            // lblSituational
            // 
            this.lblSituational.AutoSize = true;
            this.lblSituational.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituational.Location = new System.Drawing.Point(54, 95);
            this.lblSituational.Name = "lblSituational";
            this.lblSituational.Size = new System.Drawing.Size(93, 18);
            this.lblSituational.TabIndex = 20;
            this.lblSituational.Text = "Situational";
            // 
            // numTechnical
            // 
            this.numTechnical.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTechnical.Location = new System.Drawing.Point(6, 125);
            this.numTechnical.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTechnical.Name = "numTechnical";
            this.numTechnical.Size = new System.Drawing.Size(42, 26);
            this.numTechnical.TabIndex = 21;
            this.numTechnical.ValueChanged += new System.EventHandler(this.numTechnical_ValueChanged);
            // 
            // numSituational
            // 
            this.numSituational.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSituational.Location = new System.Drawing.Point(6, 93);
            this.numSituational.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSituational.Name = "numSituational";
            this.numSituational.Size = new System.Drawing.Size(42, 26);
            this.numSituational.TabIndex = 21;
            this.numSituational.ValueChanged += new System.EventHandler(this.numSituational_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Past Evidence";
            // 
            // numPastEvidence
            // 
            this.numPastEvidence.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPastEvidence.Location = new System.Drawing.Point(6, 61);
            this.numPastEvidence.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPastEvidence.Name = "numPastEvidence";
            this.numPastEvidence.Size = new System.Drawing.Size(42, 26);
            this.numPastEvidence.TabIndex = 19;
            this.numPastEvidence.ValueChanged += new System.EventHandler(this.numPastEvidence_ValueChanged);
            // 
            // lblStrengths
            // 
            this.lblStrengths.AutoSize = true;
            this.lblStrengths.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrengths.Location = new System.Drawing.Point(54, 31);
            this.lblStrengths.Name = "lblStrengths";
            this.lblStrengths.Size = new System.Drawing.Size(87, 18);
            this.lblStrengths.TabIndex = 17;
            this.lblStrengths.Text = "Strengths";
            // 
            // numStrength
            // 
            this.numStrength.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numStrength.Location = new System.Drawing.Point(6, 29);
            this.numStrength.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numStrength.Name = "numStrength";
            this.numStrength.Size = new System.Drawing.Size(42, 26);
            this.numStrength.TabIndex = 17;
            this.numStrength.ValueChanged += new System.EventHandler(this.numStrength_ValueChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnClose.Location = new System.Drawing.Point(304, 315);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(153, 39);
            this.btnClose.TabIndex = 22;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // InterviewPanel
            // 
            this.InterviewPanel.Controls.Add(this.btnSkip);
            this.InterviewPanel.Controls.Add(this.btnSave);
            this.InterviewPanel.Controls.Add(this.txtUserAnswer);
            this.InterviewPanel.Controls.Add(this.lblAnswerPreview);
            this.InterviewPanel.Controls.Add(this.lblSelectedQuestion);
            this.InterviewPanel.Controls.Add(this.lblInterviewPanelTitle);
            this.InterviewPanel.Controls.Add(this.lblQuestionText);
            this.InterviewPanel.Location = new System.Drawing.Point(645, 421);
            this.InterviewPanel.Name = "InterviewPanel";
            this.InterviewPanel.Size = new System.Drawing.Size(1061, 643);
            this.InterviewPanel.TabIndex = 23;
            // 
            // btnSkip
            // 
            this.btnSkip.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSkip.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnSkip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnSkip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkip.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSkip.Location = new System.Drawing.Point(902, 585);
            this.btnSkip.Margin = new System.Windows.Forms.Padding(4);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(136, 39);
            this.btnSkip.TabIndex = 28;
            this.btnSkip.TabStop = false;
            this.btnSkip.Text = "Skip >>";
            this.btnSkip.UseVisualStyleBackColor = false;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSave.Location = new System.Drawing.Point(24, 585);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(870, 39);
            this.btnSave.TabIndex = 27;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save Answer";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtUserAnswer
            // 
            this.txtUserAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtUserAnswer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserAnswer.Location = new System.Drawing.Point(24, 292);
            this.txtUserAnswer.MaxLength = 500;
            this.txtUserAnswer.Name = "txtUserAnswer";
            this.txtUserAnswer.Size = new System.Drawing.Size(1014, 276);
            this.txtUserAnswer.TabIndex = 24;
            this.txtUserAnswer.Text = "";
            // 
            // lblAnswerPreview
            // 
            this.lblAnswerPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblAnswerPreview.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerPreview.Location = new System.Drawing.Point(493, 199);
            this.lblAnswerPreview.Name = "lblAnswerPreview";
            this.lblAnswerPreview.Size = new System.Drawing.Size(545, 90);
            this.lblAnswerPreview.TabIndex = 26;
            this.lblAnswerPreview.Text = "If Question is answered, Text Appears here";
            this.lblAnswerPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnswerPreview.Visible = false;
            // 
            // lblSelectedQuestion
            // 
            this.lblSelectedQuestion.AutoSize = true;
            this.lblSelectedQuestion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedQuestion.Location = new System.Drawing.Point(21, 199);
            this.lblSelectedQuestion.Name = "lblSelectedQuestion";
            this.lblSelectedQuestion.Size = new System.Drawing.Size(95, 90);
            this.lblSelectedQuestion.TabIndex = 25;
            this.lblSelectedQuestion.Text = "Type:\r\nBehaviour:\r\nAnswered:\r\nAdded By:\r\nAdded At: ";
            // 
            // lblInterviewPanelTitle
            // 
            this.lblInterviewPanelTitle.AutoSize = true;
            this.lblInterviewPanelTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterviewPanelTitle.Location = new System.Drawing.Point(21, 14);
            this.lblInterviewPanelTitle.Name = "lblInterviewPanelTitle";
            this.lblInterviewPanelTitle.Size = new System.Drawing.Size(399, 18);
            this.lblInterviewPanelTitle.TabIndex = 24;
            this.lblInterviewPanelTitle.Text = "Interview Simulation in Progress (Question 0 of 0)";
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblQuestionText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionText.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblQuestionText.Location = new System.Drawing.Point(18, 44);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(1019, 146);
            this.lblQuestionText.TabIndex = 13;
            this.lblQuestionText.Text = "Question text";
            this.lblQuestionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReportPanel
            // 
            this.ReportPanel.Controls.Add(this.lblReport);
            this.ReportPanel.Controls.Add(this.lblReportTitle);
            this.ReportPanel.Location = new System.Drawing.Point(34, 742);
            this.ReportPanel.Name = "ReportPanel";
            this.ReportPanel.Size = new System.Drawing.Size(752, 296);
            this.ReportPanel.TabIndex = 24;
            // 
            // lblReportTitle
            // 
            this.lblReportTitle.AutoSize = true;
            this.lblReportTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportTitle.Location = new System.Drawing.Point(19, 18);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Size = new System.Drawing.Size(386, 18);
            this.lblReportTitle.TabIndex = 25;
            this.lblReportTitle.Text = "Interview Simulation Complete (Viewing Report)";
            // 
            // lblReport
            // 
            this.lblReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblReport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblReport.Location = new System.Drawing.Point(16, 45);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(697, 220);
            this.lblReport.TabIndex = 26;
            this.lblReport.Text = "Question text";
            this.lblReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JobSimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1378, 870);
            this.Controls.Add(this.InterviewPanel);
            this.Controls.Add(this.ReportPanel);
            this.Controls.Add(this.setupPanel);
            this.Controls.Add(this.btnClose);
            this.Name = "JobSimulation";
            this.Text = "Job Simulation [Stage]";
            this.Load += new System.EventHandler(this.JobSimulation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQuestions)).EndInit();
            this.setupPanel.ResumeLayout(false);
            this.setupPanel.PerformLayout();
            this.gbTypes.ResumeLayout(false);
            this.gbTypes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTechnical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSituational)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPastEvidence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStrength)).EndInit();
            this.InterviewPanel.ResumeLayout(false);
            this.InterviewPanel.PerformLayout();
            this.ReportPanel.ResumeLayout(false);
            this.ReportPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblQuestionAmount;
        private System.Windows.Forms.NumericUpDown numQuestions;
        private System.Windows.Forms.Panel setupPanel;
        private System.Windows.Forms.GroupBox gbTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numPastEvidence;
        private System.Windows.Forms.Label lblStrengths;
        private System.Windows.Forms.NumericUpDown numStrength;
        private System.Windows.Forms.Label lblTechnical;
        private System.Windows.Forms.Label lblSituational;
        private System.Windows.Forms.NumericUpDown numTechnical;
        private System.Windows.Forms.NumericUpDown numSituational;
        private System.Windows.Forms.Button btnBeginRandom;
        private System.Windows.Forms.Button btnUserecommended;
        private System.Windows.Forms.Button btnBeginCustom;
        private System.Windows.Forms.CheckBox chkIncludeAnswered;
        private System.Windows.Forms.CheckBox chkIncludeIcebreaker;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel InterviewPanel;
        private System.Windows.Forms.Label lblInterviewPanelTitle;
        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.Label lblSelectedQuestion;
        private System.Windows.Forms.Label lblAnswerPreview;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox txtUserAnswer;
        private System.Windows.Forms.Panel ReportPanel;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.Label lblReportTitle;
    }
}