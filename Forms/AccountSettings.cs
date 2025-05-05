/// John Coulter
/// Graded Unit 2 Project
/// Job Interviewing and Tracking Application
/// 04/05/2025
/// AccountSettings.cs
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
    /// This form allows the user to manage their account settings, including deleting their account, changing their password, and restoring deleted questions.
    /// </summary>
    public partial class AccountSettings : Form
    {
        
        public AccountSettings()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for the "Delete Account" button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            // Check if the user really wants to delete their account
            DialogResult result = MessageBox.Show("Are you sure you want to delete your account? This action cannot be undone.", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Delete the user account
                // and all associated data
                User.DeleteUser();
                // Return to login form               
                Login splash = new Login();
                splash.Show();
                this.Close();
            }
        }

        /// <summary>
        /// Event handler for the "Delete All Answers" button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteAllAnswers_Click(object sender, EventArgs e)
        {
            
            // Check if the user really wants to delete their answers
            DialogResult result = MessageBox.Show("Are you sure you want to delete your answers? This action cannot be undone.", "Delete Answers", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                List<int> questionIds = Program.AnswerRecords.ToList();
                Answer.DeleteAnswer();
            }            
        }

        /// <summary>
        /// Event handler for the "Delete All Questions" button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteAllQuestions_Click(object sender, EventArgs e)
        {
            // Check if the user really wants to delete their questions
            DialogResult result = MessageBox.Show("Are you sure you want to delete your questions? This action cannot be undone.", "Delete Questions", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {                
                Answer.DeleteAnswer();
            }
        }

        /// <summary>
        /// Event handler for the "Delete All Jobs" button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteAllJobs_Click(object sender, EventArgs e)
        {
            // Check if the user really wants to delete their jobs
            DialogResult result = MessageBox.Show("Are you sure you want to delete your jobs? This action cannot be undone.", "Delete Jobs", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Job.DeleteJob();
            }
        }

        /// <summary>
        /// Event handler for the "Restore System Questions" button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRestoreQuestions_Click(object sender, EventArgs e)
        {
            // Check if the user really wants to restore deleted system questions
            DialogResult result = MessageBox.Show("This will restore all system questions that you deleted? This action cannot be undone.", "Restore System Questions", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Question.RestoreSystemQuestions();
            }
        }

        /// <summary>
        /// Event handler for the "Delete All Data" button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteAllData_Click(object sender, EventArgs e)
        {
            // Check if the user really wants to restore deleted system questions
            DialogResult result = MessageBox.Show("This will delete all of your data? This action cannot be undone.", "Deleting All User Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                User.DeleteAllData();
            }           
        }

        /// <summary>
        /// Event handler for the "Close" button.
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
        /// Event handler for the "Change Password" button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            // Check if the user has entered a new password and current password
            if (txtNewPassword.Text == "" || txtCurrentPassword.Text == "")
            {
                MessageBox.Show("Error: Both fields are required.","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            else
            {
                // Try to change the password
                User.UpdatePassword(txtCurrentPassword.Text.Trim(), txtNewPassword.Text.Trim());
                // Clear the password fields
                txtCurrentPassword.Text = "";
                txtNewPassword.Text = "";
            }

        }

        /// <summary>
        /// Event handler for the form load event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AccountSettings_Load(object sender, EventArgs e)
        {
            lblTitle.Text = $"Hello, {Program.username}";
        }
    }
}
