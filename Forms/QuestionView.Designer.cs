namespace GU2.Forms
{
    partial class QuestionView
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
            this.btnAnswer = new System.Windows.Forms.Button();
            this.lblSelectedQuestion = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.DataGridViewer = new System.Windows.Forms.DataGridView();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.chkShowSystemQuestions = new System.Windows.Forms.CheckBox();
            this.chkShowAnswered = new System.Windows.Forms.CheckBox();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblBehaviour = new System.Windows.Forms.Label();
            this.comboBehaviour = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.txtUserAnswer = new System.Windows.Forms.RichTextBox();
            this.btnSaveAnswer = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAnswerPreview = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewer)).BeginInit();
            this.gbFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnswer
            // 
            this.btnAnswer.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAnswer.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnAnswer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnAnswer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAnswer.Location = new System.Drawing.Point(725, 159);
            this.btnAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(301, 35);
            this.btnAnswer.TabIndex = 2;
            this.btnAnswer.TabStop = false;
            this.btnAnswer.Text = "Answer Selected Question";
            this.btnAnswer.UseVisualStyleBackColor = false;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // lblSelectedQuestion
            // 
            this.lblSelectedQuestion.AutoSize = true;
            this.lblSelectedQuestion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedQuestion.Location = new System.Drawing.Point(12, 155);
            this.lblSelectedQuestion.Name = "lblSelectedQuestion";
            this.lblSelectedQuestion.Size = new System.Drawing.Size(95, 90);
            this.lblSelectedQuestion.TabIndex = 5;
            this.lblSelectedQuestion.Text = "Type:\r\nBehaviour:\r\nAnswered:\r\nAdded By:\r\nAdded At: ";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDelete.Location = new System.Drawing.Point(15, 614);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(310, 35);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Delete Selected Question";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.DataGridViewer.Location = new System.Drawing.Point(15, 291);
            this.DataGridViewer.MultiSelect = false;
            this.DataGridViewer.Name = "DataGridViewer";
            this.DataGridViewer.ReadOnly = true;
            this.DataGridViewer.RowHeadersVisible = false;
            this.DataGridViewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewer.Size = new System.Drawing.Size(1227, 316);
            this.DataGridViewer.TabIndex = 7;
            this.DataGridViewer.SelectionChanged += new System.EventHandler(this.DataGridViewer_SelectionChanged);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddQuestion.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnAddQuestion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnAddQuestion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQuestion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAddQuestion.Location = new System.Drawing.Point(15, 249);
            this.btnAddQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(228, 35);
            this.btnAddQuestion.TabIndex = 8;
            this.btnAddQuestion.TabStop = false;
            this.btnAddQuestion.Text = "Add a new question";
            this.btnAddQuestion.UseVisualStyleBackColor = false;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
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
            this.btnClose.Location = new System.Drawing.Point(1098, 614);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 35);
            this.btnClose.TabIndex = 9;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.Close_Click);
            // 
            // comboType
            // 
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(6, 37);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(197, 23);
            this.comboType.TabIndex = 10;
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.chkShowSystemQuestions);
            this.gbFilters.Controls.Add(this.chkShowAnswered);
            this.gbFilters.Controls.Add(this.lblKeyword);
            this.gbFilters.Controls.Add(this.txtKeyword);
            this.gbFilters.Controls.Add(this.btnClearFilters);
            this.gbFilters.Controls.Add(this.btnFilter);
            this.gbFilters.Controls.Add(this.lblBehaviour);
            this.gbFilters.Controls.Add(this.comboBehaviour);
            this.gbFilters.Controls.Add(this.lblType);
            this.gbFilters.Controls.Add(this.comboType);
            this.gbFilters.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilters.Location = new System.Drawing.Point(1033, 9);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(209, 275);
            this.gbFilters.TabIndex = 11;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filters";
            // 
            // chkShowSystemQuestions
            // 
            this.chkShowSystemQuestions.AutoSize = true;
            this.chkShowSystemQuestions.Checked = true;
            this.chkShowSystemQuestions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowSystemQuestions.Location = new System.Drawing.Point(6, 154);
            this.chkShowSystemQuestions.Name = "chkShowSystemQuestions";
            this.chkShowSystemQuestions.Size = new System.Drawing.Size(181, 19);
            this.chkShowSystemQuestions.TabIndex = 21;
            this.chkShowSystemQuestions.Text = "Show System Questions";
            this.chkShowSystemQuestions.UseVisualStyleBackColor = true;
            // 
            // chkShowAnswered
            // 
            this.chkShowAnswered.AutoSize = true;
            this.chkShowAnswered.Checked = true;
            this.chkShowAnswered.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowAnswered.Location = new System.Drawing.Point(6, 129);
            this.chkShowAnswered.Name = "chkShowAnswered";
            this.chkShowAnswered.Size = new System.Drawing.Size(198, 19);
            this.chkShowAnswered.TabIndex = 20;
            this.chkShowAnswered.Text = "Show Answered Questions";
            this.chkShowAnswered.UseVisualStyleBackColor = true;
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyword.Location = new System.Drawing.Point(6, 185);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(65, 15);
            this.lblKeyword.TabIndex = 18;
            this.lblKeyword.Text = "Keyword";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(7, 203);
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
            this.btnClearFilters.Location = new System.Drawing.Point(7, 233);
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
            this.btnFilter.Location = new System.Drawing.Point(139, 233);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(62, 35);
            this.btnFilter.TabIndex = 12;
            this.btnFilter.TabStop = false;
            this.btnFilter.Text = "Go";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblBehaviour
            // 
            this.lblBehaviour.AutoSize = true;
            this.lblBehaviour.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBehaviour.Location = new System.Drawing.Point(3, 73);
            this.lblBehaviour.Name = "lblBehaviour";
            this.lblBehaviour.Size = new System.Drawing.Size(134, 15);
            this.lblBehaviour.TabIndex = 14;
            this.lblBehaviour.Text = "Question Behaviour";
            // 
            // comboBehaviour
            // 
            this.comboBehaviour.FormattingEnabled = true;
            this.comboBehaviour.Location = new System.Drawing.Point(6, 91);
            this.comboBehaviour.Name = "comboBehaviour";
            this.comboBehaviour.Size = new System.Drawing.Size(197, 23);
            this.comboBehaviour.TabIndex = 13;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(3, 19);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(99, 15);
            this.lblType.TabIndex = 12;
            this.lblType.Text = "Question Type";
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblQuestionText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionText.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblQuestionText.Location = new System.Drawing.Point(8, 9);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(1019, 146);
            this.lblQuestionText.TabIndex = 12;
            this.lblQuestionText.Text = "Question text";
            this.lblQuestionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserAnswer
            // 
            this.txtUserAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtUserAnswer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserAnswer.Location = new System.Drawing.Point(14, 291);
            this.txtUserAnswer.MaxLength = 500;
            this.txtUserAnswer.Name = "txtUserAnswer";
            this.txtUserAnswer.Size = new System.Drawing.Size(1227, 276);
            this.txtUserAnswer.TabIndex = 13;
            this.txtUserAnswer.Text = "";
            this.txtUserAnswer.Visible = false;
            // 
            // btnSaveAnswer
            // 
            this.btnSaveAnswer.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSaveAnswer.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnSaveAnswer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnSaveAnswer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSaveAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAnswer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSaveAnswer.Location = new System.Drawing.Point(15, 249);
            this.btnSaveAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveAnswer.Name = "btnSaveAnswer";
            this.btnSaveAnswer.Size = new System.Drawing.Size(228, 35);
            this.btnSaveAnswer.TabIndex = 14;
            this.btnSaveAnswer.TabStop = false;
            this.btnSaveAnswer.Text = "Save Answer";
            this.btnSaveAnswer.UseVisualStyleBackColor = false;
            this.btnSaveAnswer.Visible = false;
            this.btnSaveAnswer.Click += new System.EventHandler(this.btnSaveAnswer_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancel.Location = new System.Drawing.Point(251, 249);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(228, 35);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblAnswerPreview
            // 
            this.lblAnswerPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblAnswerPreview.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerPreview.Location = new System.Drawing.Point(482, 198);
            this.lblAnswerPreview.Name = "lblAnswerPreview";
            this.lblAnswerPreview.Size = new System.Drawing.Size(545, 90);
            this.lblAnswerPreview.TabIndex = 16;
            this.lblAnswerPreview.Text = "If Question is answered, Text Appears here";
            this.lblAnswerPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnswerPreview.Visible = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnEdit.Location = new System.Drawing.Point(479, 159);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(238, 35);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "Edit Selected Question";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // QuestionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1249, 661);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblAnswerPreview);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveAnswer);
            this.Controls.Add(this.txtUserAnswer);
            this.Controls.Add(this.lblQuestionText);
            this.Controls.Add(this.gbFilters);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.DataGridViewer);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblSelectedQuestion);
            this.Controls.Add(this.btnAnswer);
            this.Name = "QuestionView";
            this.Text = "Showing List of Questions";
            this.Load += new System.EventHandler(this.QuestionView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewer)).EndInit();
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Label lblSelectedQuestion;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView DataGridViewer;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.Label lblBehaviour;
        private System.Windows.Forms.ComboBox comboBehaviour;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.CheckBox chkShowAnswered;
        private System.Windows.Forms.CheckBox chkShowSystemQuestions;
        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.RichTextBox txtUserAnswer;
        private System.Windows.Forms.Button btnSaveAnswer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAnswerPreview;
        private System.Windows.Forms.Button btnEdit;
    }
}