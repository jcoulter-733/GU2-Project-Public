// Name: John Coulter
//Class: HND Software Development: Graded Unit 2
//Project description: Job Interviewing and Tracking Application
//Date: 04/05/2025
// Dashboard.cs
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
    /// This formis thhe main dashboard for the application, allowing navigation to other forms.
    /// </summary>
    public partial class Dashboard : Form
    {
        
        public Dashboard()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for the form load event. This method loads data from the lists and updates the UI.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dashboard_Load(object sender, EventArgs e)
        {

            LoadData();
        }

        /// <summary>
        /// Loads data from the lists and updates the UI elements with the loaded data.
        /// </summary>
        private void LoadData()
        {
            int questionsLoaded = 0;
            int questionsAnswered = 0;
            int userQuestionsLoaded = 0;
            int jobsLoaded = 0;
            int deadlinesApproaching = 0;

            questionsLoaded = Program.questions.Count();
            userQuestionsLoaded = Question.CountUserQuestions();
            questionsAnswered = Program.AnswerRecords.Count();
            jobsLoaded = Program.jobs.Count();
            // Count the number of jobs with closing date within 7 days
            deadlinesApproaching = Job.DeadlinesApproaching();


            lblTitle.Text = $"Hello, {Program.username}";
            lblInfoPanel.Text = 
                $"Questions Loaded: {questionsLoaded}\n\n" +
                $"User Added Questions: {userQuestionsLoaded}\n\n" +
                $"Questions Answered: {questionsAnswered}\n\n" +
                $"Jobs Loaded: {jobsLoaded}\n";
            if (deadlinesApproaching > 0)
            {
                lblInfoPanel.Text += $"({deadlinesApproaching} Job";
            }
            if (deadlinesApproaching > 1)
            {
                lblInfoPanel.Text += $"s closing soon.)\n";
            }
            else if (deadlinesApproaching == 1)
            {
                lblInfoPanel.Text += $" closing soon.)\n";
            }
            
        }

        /// <summary>
        /// Event handler for the "Exit" button. This method closes the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Event handler for the "Logout" button. This method logs out the user and shows the login form again.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // logout the user
            User.LogoutUser();
          
            // Show the login form again
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        /// <summary>
        /// Event handler for the "View Questions" button. This method opens the QuestionView form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewQuestions_Click(object sender, EventArgs e)
        {
            QuestionView questionView = new QuestionView();
            questionView.Show();
            this.Close();
        }

        /// <summary>
        /// Event handler for the "View Answers" button. This method opens the AnswerView form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewJobs_Click(object sender, EventArgs e)
        {
            JobTracking jobTracking = new JobTracking();
            jobTracking.Show();
            this.Close();
        }

        /// <summary>
        /// Event handler for the "View Answers" button. This method opens the AnswerView form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSimInterview_Click(object sender, EventArgs e)
        {
            JobSimulation jobSimulation = new JobSimulation();
            jobSimulation.Show();
            this.Close();
        }

        /// <summary>
        /// Event handler for the "View Answers" button. This method opens the AnswerView form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSettings_Click(object sender, EventArgs e)
        {
            AccountSettings settings = new AccountSettings();
            settings.Show();
            this.Close();


        }
    }
}
