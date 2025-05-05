/// John Coulter
/// Graded Unit 2 Project
/// Job Interviewing and Tracking Application
/// 04/05/2025
/// JobSimulation.cs
using GU2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GU2.Forms
{
    /// <summary>
    /// This form is for the job simulation, allowing users to customize their interview questions and start the simulation.
    /// </summary>
    public partial class JobSimulation : Form
    {
        // Variables to store the number of questions of each type
        int totalQuestions = 0;
        int strengthQuestions = 0;
        int pastEvidenceQuestions = 0;
        int situationalQuestions = 0;
        int technicalQuestions = 0;
        // Maximum number of questions allowed
        public const int MaxQuestions = 10;
        // Instance of the InterviewSimulation class
        private InterviewSimulation simulation = new InterviewSimulation();

        /// <summary>
        /// Constructor for the JobSimulation form.
        /// </summary>
        public JobSimulation()
        {
            InitializeComponent();
            // initialize the simulation object
            simulation = new InterviewSimulation();
        }

        /// <summary>
        /// Event handler for the "User Recommended" button. This method sets the number of questions to a recommended set and enables the start buttons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUserecommended_Click(object sender, EventArgs e)
        {
            numPastEvidence.Value = 2;
            numStrength.Value = 1;
            numSituational.Value = 2;
            numTechnical.Value = 0;

            chkIncludeIcebreaker.Checked = true;
            chkIncludeAnswered.Checked = false;

            SetNumberofQuestions();

        }

        /// <summary>
        /// Event handler for the "Reset" button. This method resets all the question counts to zero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            numPastEvidence.Value = 0;
            numStrength.Value = 0;
            numSituational.Value = 0;
            numTechnical.Value = 0;

            chkIncludeIcebreaker.Checked = true;
            chkIncludeAnswered.Checked = false;
        }

        /// <summary>
        /// Function to enable or disable the start buttons based on the number of questions selected.
        /// </summary>
        private void ButtonEnabling()
        {
            if (numPastEvidence.Value > 0 || numStrength.Value > 0 || numSituational.Value > 0 || numTechnical.Value > 0)
            {
                btnBeginCustom.Enabled = true;
                btnBeginRandom.Enabled = false;
                btnBeginRandom.BackColor = Color.Gray;
                btnBeginCustom.BackColor = Color.RoyalBlue;
                chkIncludeAnswered.Enabled = true;
                chkIncludeIcebreaker.Enabled = true;
                btnBeginRandom.Text = "Begin with 0 Random Questions";
            }
            else
            {
                btnBeginRandom.Enabled = false;
                btnBeginCustom.Enabled = false;
                chkIncludeAnswered.Enabled = true;
                chkIncludeIcebreaker.Enabled = true;
                btnBeginRandom.BackColor = Color.Gray;
                btnBeginCustom.BackColor = Color.Gray;

                btnBeginRandom.Text = "Begin with 0 Random Questions";
            }
            if (numPastEvidence.Value == 0 && numStrength.Value == 0 && numSituational.Value == 0 && numTechnical.Value == 0 && totalQuestions > 0)
            {
                btnBeginCustom.Enabled = false;
                btnBeginRandom.Enabled = true;
                btnBeginRandom.BackColor = Color.RoyalBlue;
                btnBeginCustom.BackColor = Color.Gray;
                chkIncludeAnswered.Enabled = false;
                chkIncludeIcebreaker.Enabled = false;
                chkIncludeAnswered.Checked = false;
                chkIncludeIcebreaker.Checked = false;
                btnBeginRandom.Text = $"Begin with {totalQuestions} Random Questions";
            }
           

        }

        /// <summary>
        /// Function to get the total number of questions selected by the user.
        /// </summary>
        /// <returns></returns>
        internal int GetTotalQuestions()
        {
            int total = 0;
            strengthQuestions = (int)numStrength.Value;
            pastEvidenceQuestions = (int)numPastEvidence.Value;
            situationalQuestions = (int)numSituational.Value;
            technicalQuestions = (int)numTechnical.Value;
            total = strengthQuestions + pastEvidenceQuestions + situationalQuestions + technicalQuestions;

            if (total <= MaxQuestions)
            {
                totalQuestions = total;
                numQuestions.Value = total;
            }

            // Check which button needs to be enabled
            ButtonEnabling();

            return total;
        }

        /// <summary>
        /// Function to set the number of questions based on the user's selection. It checks if the total number of questions exceeds the maximum allowed.
        /// </summary>
        /// <returns></returns>
        internal bool SetNumberofQuestions()
        {
            int total = GetTotalQuestions();

            // Check if the total number of questions exceeds the maximum allowed
            if (total > MaxQuestions)
            {
                MessageBox.Show($"The maximum allowed questions is {MaxQuestions}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }


        }

        /// <summary>
        /// Event handler for the numeric up-down control for strength questions. This method checks if the number of questions exceeds the maximum allowed and adjusts the value accordingly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numStrength_ValueChanged(object sender, EventArgs e)
        {
            int currentValue = (int)numStrength.Value;
            bool allowedToAdd = SetNumberofQuestions();
            if (!allowedToAdd)
            {
                currentValue--;
                numStrength.Value = currentValue;
            }
        }

        /// <summary>
        /// Event handler for the numeric up-down control for past evidence questions. This method checks if the number of questions exceeds the maximum allowed and adjusts the value accordingly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numPastEvidence_ValueChanged(object sender, EventArgs e)
        {
            int currentValue = (int)numPastEvidence.Value;
            bool allowedToAdd = SetNumberofQuestions();
            if (!allowedToAdd)
            {
                currentValue--;
                numPastEvidence.Value = currentValue;
            }
        }

        /// <summary>
        /// Event handler for the numeric up-down control for situational questions. This method checks if the number of questions exceeds the maximum allowed and adjusts the value accordingly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numSituational_ValueChanged(object sender, EventArgs e)
        {
            int currentValue = (int)numSituational.Value;
            bool allowedToAdd = SetNumberofQuestions();
            if (!allowedToAdd)
            {
                currentValue--;
                numSituational.Value = currentValue;
            }
        }

        /// <summary>
        /// Event handler for the numeric up-down control for technical questions. This method checks if the number of questions exceeds the maximum allowed and adjusts the value accordingly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numTechnical_ValueChanged(object sender, EventArgs e)
        {
            int currentValue = (int)numTechnical.Value;
            bool allowedToAdd = SetNumberofQuestions();
            if (!allowedToAdd)
            {
                currentValue--;
                numTechnical.Value = currentValue;
            }
        }

        /// <summary>
        /// Event handler for the form load event. Loads the 'setup' panel and sets the default button colors.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JobSimulation_Load(object sender, EventArgs e)
        {
            btnBeginRandom.BackColor = Color.Gray;
            btnBeginCustom.BackColor = Color.Gray;
            Panels("setup");

        }

        /// <summary>
        /// Function to switch between different panels based on the stage of the interview simulation.
        /// </summary>
        /// <param name="stage"></param>
        protected void Panels(string stage)
        {
            if (stage == "setup")
            {
                this.Size = new Size(608, 395);
                setupPanel.Location = new Point(12, 12);
                setupPanel.Visible = true;
                setupPanel.BringToFront();
                this.Text = "Interview Simulation [Setting up the interview]";
                btnClose.Location = new Point(207, 304);
                InterviewPanel.Visible = false;
            }
            else if (stage == "interview")
            {
                this.Size = new Size(1106, 752);
                InterviewPanel.Location = new Point(12, 12);
                InterviewPanel.Visible = true;
                InterviewPanel.BringToFront();
                this.Text = "Interview Simulation [Interview in progress]";
                btnClose.Location = new Point(36, 665);
                setupPanel.Visible = false;
            }
            else if (stage == "report")
            {
                btnSkip.Enabled = false;
                InterviewPanel.Visible = false;
                ReportPanel.Visible = true;
                ReportPanel.BringToFront();
                ReportPanel.Location = new Point(12, 12);
                this.Size = new Size(807, 402);
                this.Text = "Interview Simulation [Interview Finished]";                
                btnClose.Location = new Point(304, 315);
            }
        }

        /// <summary>
        /// Event handler for the numeric up-down control for the total number of questions. This method checks if the number of questions exceeds the maximum allowed and adjusts the value accordingly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numQuestions_ValueChanged(object sender, EventArgs e)
        {
            // Check if the number of questions exceeds the maximum allowed
            int customQuestions = (int)numPastEvidence.Value + (int)numStrength.Value + (int)numSituational.Value + (int)numTechnical.Value;
            if (customQuestions > 0)
            {
                return;
            }
            else
            {
                int currentValue = (int)numQuestions.Value;
                totalQuestions = currentValue;
                ButtonEnabling();
            }
        }

        /// <summary>
        /// Event handler for the "Begin Random" button. This method starts the interview simulation with random selection questions.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBeginRandom_Click(object sender, EventArgs e)
        {
            BeginSimulation("random");
            DisplayInterviewStatus();
        }

        /// <summary>
        /// Event handler for the "Begin Custom" button. This method starts the interview simulation with custom selection of questions.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBeginCustom_Click(object sender, EventArgs e)
        {
            BeginSimulation("custom");
            DisplayInterviewStatus();
        }

        /// <summary>
        /// Function to display the status of the interview simulation. It checks if the questions were loaded successfully and displays a message accordingly.
        /// Depending on the filters selected by the user, there might be less questions available than requested.
        /// </summary>
        private void DisplayInterviewStatus()
        {
            // The number of questions loaded is equal to the number of questions in the simulation list and proceed to interview stage
            if (Program.simulationList.Count() == totalQuestions)
            {
                MessageBox.Show($"The interview is ready\n" +
                    $"Questions Requested: {totalQuestions}\n" +
                    $"Questions Loaded: {Program.simulationList.Count()}");
                Panels("interview");
                
            }
            // Warn the user that some questions couldn't be loaded and proceed to interview stage
            else if (Program.simulationList.Count() < totalQuestions)
            {
                MessageBox.Show($"Warning: Some questions couldn't be loaded\n" +
                    $"Questions Requested: {totalQuestions}\n" +
                    $"Questions Loaded: {Program.simulationList.Count()}");
                Panels("interview");

            }
            // Warn the user that no questions were loaded and don't proceed to interview stage
            else
            {
                MessageBox.Show($"Error: No questions could be loaded\n" +
                    $"Questions Requested: {totalQuestions}\n" +
                    $"Questions Loaded: {Program.simulationList.Count()}");
            }
        }
        /// <summary>
        /// Function to start the interview simulation. It generates questions based on the user's selection and displays the first question.
        /// </summary>
        /// <param name="simulationType"></param>
        private void BeginSimulation(string simulationType)
        {
            bool includeIcebreaker = chkIncludeIcebreaker.Checked;

            // if the user wants an icebreaker question included, add 1 to the total number of questions
            if (includeIcebreaker)
            {
                this.totalQuestions++;
            }
            // variables to store the number of questions of each type
            bool includeAnswered = chkIncludeAnswered.Checked;
            int totalQuestions = (int)numQuestions.Value;
            int strengthQuestions = (int)numStrength.Value;
            int pastEvidenceQuestions = (int)numPastEvidence.Value;
            int situationalQuestions = (int)numSituational.Value;
            int technicalQuestions = (int)numTechnical.Value;
            
            // A custom set of question types needs to be loaded
            if(simulationType == "custom")
            {
                // Generate the questions based on the user's selection
                simulation.GenerateQuestions(strengthQuestions, pastEvidenceQuestions, situationalQuestions, technicalQuestions, includeIcebreaker, includeAnswered);
                
            }
            // A random set of questions needs to be loaded
            else if (simulationType == "random")
            {
                // Generate a random set of questions
                simulation.GenerateQuestions(totalQuestions);
                
            }
            // Display the first question
            DisplayQuestion();
   
        }

        /// <summary>
        /// Function to display the current question in the interview simulation. It retrieves the question and answer from the simulation object and updates the UI.
        /// </summary>
        private void DisplayQuestion()
        {
            // Create a new question object and retrieve the current question
            Question question = new Question();
            string answer = "";
            string answered = "";
            string username = "";
            int currentQuestion = 0;

            // Get the required question data
            (question, answer ,answered, username, currentQuestion)  = simulation.AskQuestion();

            // If the question has already been answered, display the answer
            if (answered == "Yes")
            {               
                lblAnswerPreview.Text = answer;
                lblAnswerPreview.Visible = true;
            }
            else
            {
                lblAnswerPreview.Visible = false;
            }


            // Display question data
            lblInterviewPanelTitle.Text = $"Interview Simulation [Interview in progress] - Question {currentQuestion} of {Program.simulationList.Count()} [QuestionId: {question.questionId}]";
            lblQuestionText.Text = question.question;
            lblSelectedQuestion.Text = $"Type: {question.questionType}\nBehaviour: {question.questionBehaviour}\r\nAnswered:{answered}\r\nAdded By:{username}\nAdded At: {question.addedAt}";
        }

        /// <summary>
        /// Function to end the interview simulation. It generates a report based on the user's answers and displays it in the report panel.
        /// </summary>
        private void EndInterview()
        {
            Panels("report");
            // The report needs to be generated by the simulation object
            lblReport.Text = simulation.GenerateReport();

        }

        /// <summary>
        /// Event handler for the "Skip" button. This method skips the current question and displays the next one.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSkip_Click(object sender, EventArgs e)
        {
            // Check if there are any questions left in the list
            if (simulation.GetCurrentQuestion() >= Program.simulationList.Count())
            {
                // End the interview if there are no questions left
                EndInterview();
                
            }
            else
            {
                // Skip the current question and display the next one
                DisplayQuestion();
            }
            
        }

        /// <summary>
        /// Event handler for the "Close" button. This method closes the form and returns to the dashboard.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }

        /// <summary>
        /// Event handler for the "Save" button. This method saves the user's answer to the current question and displays the next question.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            string answer = txtUserAnswer.Text;
            int questionId = Program.simulationList[simulation.GetCurrentQuestion() - 1].questionId; // Set questionId 
            // Save the answer to the current question to database
            simulation.AnswerQuestion(answer, questionId);

            // Check if there are any questions left in the list
            if (simulation.GetCurrentQuestion() >= Program.simulationList.Count())
            {
                // End the interview if there are no questions left
                EndInterview();

            }
            else
            {
                // Skip the current question and display the next one
                txtUserAnswer.Text = "";
                DisplayQuestion();
            }

        }
    }
}
