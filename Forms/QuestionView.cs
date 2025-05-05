/// John Coulter
/// Graded Unit 2 Project
/// Job Interviewing and Tracking Application
/// 04/05/2025
/// QuestionView.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GU2.Classes;

namespace GU2.Forms
{
    /// <summary>
    /// This form displays a list of questions and allows the user to add, edit, delete, or answer questions.
    /// </summary>
    public partial class QuestionView : Form
    {
        // Variables to store the selected question details
        int selectedQuestionId = 0;
        int selectedUserId = 0;
        string selectedUsername = "";
        string selectedQuestion = "";
        string selectedQuestionType = "";
        string selectedQuestionBehaviour = "";
        string selectedQuestionAnswered = "";
        DateTime selectedAddedAt = DateTime.Now;

        public QuestionView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for the form load event. This method loads data for the combo boxes and initializes the question list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuestionView_Load(object sender, EventArgs e)
        {
            // load data for combo boxes
            List<string> questionTypes = new List<string>();
            List<string> questionBehaviours = new List<string>();

            // comboType
            questionTypes.Add("");
            questionTypes.Add("No Type");
            questionTypes.Add("Strength");
            questionTypes.Add("Past Evidence");
            questionTypes.Add("Situational");
            questionTypes.Add("Technical");

            // comboBehaviour
            questionBehaviours.Add("");
            questionBehaviours.Add("No Type");
            questionBehaviours.Add("Leadership");
            questionBehaviours.Add("Communicating and Influencing");
            questionBehaviours.Add("Delivering at Pace");
            questionBehaviours.Add("Changing & Improving");
            questionBehaviours.Add("Making Effective Decisions");
            questionBehaviours.Add("Working Together");
            questionBehaviours.Add("Managing a Quality Service");
            questionBehaviours.Add("Developing Self and Others");
            questionBehaviours.Add("Reasoning");
            questionBehaviours.Add("Technical");
            questionBehaviours.Add("Seeing the Bigger Picture");
            questionBehaviours.Add("Icebreaker");


            comboBehaviour.DataSource = questionBehaviours;
            comboType.DataSource = questionTypes;

            // Load an unfiltered list of questions
            LoadData(false);
        }

        /// <summary>
        /// Loads the data into the DataGridView. This method creates list of questions based on the selected filters if filtered is true.
        /// </summary>
        /// <param name="filtered"></param>
        private void LoadData(bool filtered)
        {
            // Load the list of questions
            Question.CreateQuestionList(Program.userId);

            DataTable dt;
            // If the user has selected filters, create a filtered list of questions
            if (filtered)
            {
                // Create a filtered list of questions
                Question.CreateFilteredQuestionList(
                    type: comboType.SelectedItem.ToString(),
                    behaviour: comboBehaviour.SelectedItem.ToString(),                    
                    showSystemQuestions: chkShowSystemQuestions.Checked,
                    keyword: txtKeyword.Text.Trim(),
                    answered: chkShowAnswered.Checked
                );

                // Create the fltered data table
                dt = Question.PopulateFilteredDataTable(
                userId: Program.userId,
                type: comboType.SelectedItem.ToString(),
                behaviour: comboBehaviour.SelectedItem.ToString(),        
                includeSystem: chkShowSystemQuestions.Checked,
                keyword: txtKeyword.Text.Trim(),
                answered: chkShowAnswered.Checked
     );
            }
            else
            {
                // No filters requirted
                dt = Question.PopulateDataTable();
            }

            
            DataGridViewer.AutoGenerateColumns = true;
            DataGridViewer.DataSource = dt;

            // Hide the userId and questionId columns
            foreach (var col in new[] { "userId", "questionId" })
                if (DataGridViewer.Columns.Contains(col))
                    DataGridViewer.Columns[col].Visible = false;

            // Update the form title with the number of questions
            this.Text = $"Showing List of Questions [{DataGridViewer.RowCount} Questions]";

            // If the filtered list is empty, show a message
            if (filtered && DataGridViewer.RowCount == 0)
            {
                lblSelectedQuestion.Text =
                    "No questions found that matched your selected filters";
            }
            else
            {
                PopulateInfoLabel();
            }
        }

        /// <summary>
        /// Event handler for the DataGridView selection changed event. This method updates the selected question details when the user selects a different question.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewer_SelectionChanged(object sender, EventArgs e)
        {
            // Check if the DataGridView has any selected rows
            if (DataGridViewer.CurrentRow == null || DataGridViewer.CurrentRow.Index < 0)
                return;

            // Set the selected question variables
            selectedQuestionId = Convert.ToInt32(DataGridViewer.CurrentRow.Cells["questionId"].Value);
            selectedUserId = Convert.ToInt32(DataGridViewer.CurrentRow.Cells["userId"].Value);
            selectedQuestion = DataGridViewer.CurrentRow.Cells["question"].Value.ToString();
            selectedQuestionType = DataGridViewer.CurrentRow.Cells["questionType"].Value.ToString();
            selectedQuestionBehaviour = DataGridViewer.CurrentRow.Cells["questionBehaviour"].Value.ToString();
            selectedAddedAt = Convert.ToDateTime(DataGridViewer.CurrentRow.Cells["addedAt"].Value);

            // Set the selected username based on the userId
            selectedUsername = (selectedUserId == Program.userId)
                // if the userId's dont match, then it is a system question
                ? Program.username
                : "System";

            PopulateInfoLabel();
        }

        /// <summary>
        /// Populates the information label with the selected question details
        /// </summary>
        private void PopulateInfoLabel()
        {
            // If the AnswerRecord list contains the selected questionId, then the question has been answered
            if (Program.AnswerRecords.Contains(selectedQuestionId))
            {
                selectedQuestionAnswered = "Yes";
                string answerText = Answer.GetAnswer(selectedQuestionId); // Gets the answer text for selected question
                lblAnswerPreview.Text = answerText; 
                lblAnswerPreview.Visible = true;
                btnAnswer.Text = "Edit Answer";
            }
            else
            {
                selectedQuestionAnswered = "No";
                lblAnswerPreview.Text = "";
                lblAnswerPreview.Visible = false;
                btnAnswer.Text = "Answer Selected Question";
            }
            // The user can only edit their own questions
            // Edit button is only visible if the selected question is made by the logged in user
            if (selectedUserId == Program.userId)
            {
                btnAnswer.Size = new Size(301, 35);
                btnAnswer.Location = new Point(725, 159);
                btnEdit.Visible = true;
                btnEdit.Enabled = true;
            }
            else
            {
                btnAnswer.Size = new Size(547, 35);
                btnAnswer.Location = new Point(479, 159);
                btnEdit.Visible = false;
                btnEdit.Enabled = false;
            }

            // Display the selected question details in the label
            lblQuestionText.Text = selectedQuestion;
            lblSelectedQuestion.Text =                
                $"Type: {selectedQuestionType}\n" +
                $"Behaviour: {selectedQuestionBehaviour}\n" +
                $"Answered: {selectedQuestionAnswered}\n" +
                $"Added By: {selectedUsername}\n" +
                $"Added At: {selectedAddedAt.ToString("yyyy-MM-dd HH:mm")}";
        }

        /// <summary>
        /// Event handler for the Add Question button click event. This method opens the NewQuestion form to add a new question.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            NewQuestion newQuestion = new NewQuestion();
            newQuestion.Show();
            this.Close();
        }

        /// <summary>
        /// Event handler for the Filter button click event. This method filters the questions based on the selected criteria.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilter_Click(object sender, EventArgs e)
        {
            // Set the selected filter values
            try
            {
                string type = comboType.SelectedItem.ToString();
                string behaviour = comboBehaviour.SelectedItem.ToString();
                bool answered = chkShowAnswered.Checked;
                bool showSystemQuestions = chkShowSystemQuestions.Checked;
                string keyword = txtKeyword.Text.Trim();

                // Try to filter the questions
                Question.CreateFilteredQuestionList(type, behaviour, showSystemQuestions, keyword, answered);

                // Load the filtered data
                LoadData(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


           
        }

        /// <summary>
        /// Event handler for the Clear Filters button click event. This method clears the selected filters and reloads the data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            chkShowSystemQuestions.Checked = true;
            chkShowAnswered.Checked = true;
            txtKeyword.Text = "";
            comboType.SelectedIndex = 0;
            comboBehaviour.SelectedIndex = 0;
            LoadData(false);
        }

        /// <summary>
        /// Event handler for the Close button click event. This method closes the QuestionView form and opens the Dashboard form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }
        /// <summary>
        /// Event handler for the Delete Question button click event. This method deletes the selected question.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Set the selected question variables
            int selectedQuestionId = Convert.ToInt32(DataGridViewer.CurrentRow.Cells["questionId"].Value);
            string selectedQuestion = DataGridViewer.CurrentRow.Cells["question"].Value.ToString();

            // Warn user that the selected question will be deleted
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete this question? This action cannot be undone.\n\nID: {selectedQuestionId}\nQuestion: {selectedQuestion}",
                "Delete Question",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            // If the user confirms, delete the question
            if ( result == DialogResult.Yes )
            {
                Question.DeleteQuestion(selectedQuestionId);
                LoadData(false);
            }
            
        }
        /// <summary>
        /// This Function handles which buttons are visible and enabled based on the action parameter.
        /// </summary>
        /// <param name="action"></param>
        private void ButtonSwitching(string action)
        {
            // The user is answering a selected question
            if (action == "answer")
            {
                DataGridViewer.Visible = false;
                txtUserAnswer.Visible = true;
                btnCancel.Visible = true;
                btnSaveAnswer.Visible = true;
                btnDelete.Visible = false;
                btnClearFilters.Enabled = false;
                btnFilter.Enabled = false;
                btnAddQuestion.Enabled = false;
                btnAnswer.Enabled = false;
                gbFilters.Visible = false;
            }
            // The user is viewing the questions
            else if (action == "view")
            {
                DataGridViewer.Visible = true;
                txtUserAnswer.Visible = false;
                btnCancel.Visible = false;
                btnSaveAnswer.Visible = false;
                btnDelete.Visible = true;
                btnClearFilters.Enabled = true;
                btnFilter.Enabled = true;
                btnAddQuestion.Enabled = true;
                btnAnswer.Enabled = true;
                gbFilters.Visible = true;
            }
        }
        /// <summary>
        /// Event handler for the Answer button click event. This method allows the user to answer a selected question.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnswer_Click(object sender, EventArgs e)
        {
            // Check if an answer already exists for the selected question
            if (Program.AnswerRecords.Contains(selectedQuestionId))
            {
                string answerText = Answer.GetAnswer(selectedQuestionId);// Get the answer text for the selected question
                Answer.GetAnswer(selectedQuestionId);
                txtUserAnswer.Text = answerText;
            }
            // Display buttons in answer mode
            ButtonSwitching("answer");

        }

        /// <summary>
        /// Event handler for the Cancel button click event. This method cancels the answer input and switches back to the view mode.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ButtonSwitching("view");
            txtUserAnswer.Text = "";
        }

        /// <summary>
        /// Event handler for the Save Answer button click event. This method saves the user's answer to the selected question.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveAnswer_Click(object sender, EventArgs e)
        {
            // Save the answer to the database
            Answer.AnswerQuestion(txtUserAnswer.Text.Trim(), selectedQuestionId);

            // Return to the view mode and Load an unfiltered list of questions
            ButtonSwitching("view");
            txtUserAnswer.Text = "";
            LoadData(false);
        }

        /// <summary>
        /// Event handler for the Edit Question button click event. This method opens the NewQuestion form to edit an existing question.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(selectedUserId != 0)// Check that this question is not a system question
            {
                NewQuestion editQuestion = new NewQuestion(selectedQuestionId, selectedQuestion, selectedQuestionType, selectedQuestionBehaviour);
                editQuestion.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error: You cannot edit a system question.","Error");
            }


        }
    }
}
