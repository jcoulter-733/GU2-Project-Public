// Name: John Coulter
//Class: HND Software Development: Graded Unit 2
//Project description: Job Interviewing and Tracking Application
//Date: 04/05/2025
// NewQuestion.cs
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
    /// This form allows the user to add or edit a question.
    /// </summary>
    public partial class NewQuestion : Form
    {
        // Flag to indicate whether the form is in update mode or not
        private bool updating = false;
        // Question ID for the question being edited
        private int questionId = 0;

        /// <summary>
        /// Constructor for the NewQuestion form. This constructor is used when adding a new question.
        /// </summary>
        public NewQuestion()
        {
           
            InitializeComponent();
            updating = false;
        }
        /// <summary>
        /// Constructor for the NewQuestion form. This constructor is used when editing an existing question.
        /// </summary>
        /// <param name="questionId"></param>
        /// <param name="questionText"></param>
        /// <param name="questionType"></param>
        /// <param name="questionBehaviour"></param>
        public NewQuestion(int questionId, string questionText, string questionType, string questionBehaviour)
        {
            InitializeComponent();

            updating = true; // sets the form to update mode
            this.questionId = questionId; // sets the question ID to the one being edited

            // Set the text of the question, type, and behaviour in the form
            txtQuestion.Text = questionText;
            comboType.SelectedItem = questionType;
            comboBehaviour.SelectedItem = questionBehaviour;
            // Set the form title
            this.Text = "Edit Question";
        }
        /// <summary>
        /// Event handler for the form load event. This method loads data from the lists and updates the UI.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewQuestion_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        /// <summary>
        /// Loads data from the lists and updates the UI elements with the loaded data.
        /// </summary>
        private void LoadData()
        {
            // load data for combo boxes
            List<string> questionTypes = new List<string>();
            List<string> questionBehaviours = new List<string>();
            questionTypes.Add("No Type");
            questionTypes.Add("Strength");
            questionTypes.Add("Past Evidence");
            questionTypes.Add("Situational");
            questionTypes.Add("Technical");

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
            comboBehaviour.SelectedIndex = 0;
            comboType.SelectedIndex = 0;
        }

        /// <summary>
        /// Event handler for the "Add Question" button. This method adds or updates a question based on the user's input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            string question = "";
            string questionType = "";
            string questionBehaviour = "";

            // Check if the user has entered a question
            if (txtQuestion.Text == "")
            {
                MessageBox.Show("Please enter a question.");
            }
            else
            {
                // Set the question, type, and behaviour from the form
                question = txtQuestion.Text.Trim();
                questionType = comboType.SelectedItem.ToString();
                questionBehaviour = comboBehaviour.SelectedItem.ToString();
            }
            // Check if this is an update or add operation
            if (updating) // Try to update an existing question
            {
                Question.UpdateQuestion(this.questionId, question, questionType, questionBehaviour);
            }
            else // Try to add a new question
            {
                Question.AddQuestion(question, questionType, questionBehaviour);
                Question.CreateQuestionList(Program.userId);
            }

                QuestionView questionView = new QuestionView();
                questionView.Show();
                this.Close(); 
        }
        /// <summary>
        /// Event handler for the "Delete Question" button. This method deletes a question based on the user's input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            QuestionView questionView = new QuestionView();
            questionView.Show();
            
            this.Close();
        }
    }
}
