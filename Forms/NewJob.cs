/// John Coulter
/// Graded Unit 2 Project
/// Job Interviewing and Tracking Application
/// 04/05/2025
/// NewJob.cs
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
    /// This form allows the user to add or edit a job.
    /// </summary>
    public partial class NewJob : Form
    {
        // Flag to indicate whether the form is in update mode or not
        private bool updating = false;
        // Job ID for the job being edited
        private int jobId = 0;

        /// <summary>
        /// Constructor for the NewJob form. This constructor is used when adding a new job.
        /// </summary>
        public NewJob()
        {
            InitializeComponent();
            updating = false;
        }

        /// <summary>
        /// Constructor for the NewJob form. This constructor is used when editing an existing job.
        /// </summary>
        /// <param name="selectedJobId"></param>
        /// <param name="selectedUserId"></param>
        /// <param name="selectedCompanyName"></param>
        /// <param name="selectedJobImportance"></param>
        /// <param name="selectedJobTitle"></param>
        /// <param name="selectedJobStatus"></param>
        /// <param name="selectedClosingDate"></param>
        /// <param name="selectedJobAdUrl"></param>
        /// <param name="selectedJobSalary"></param>
        /// <param name="selectedJobNotes"></param>
        public NewJob(int selectedJobId, int selectedUserId, string selectedCompanyName, int selectedJobImportance, string selectedJobTitle, string selectedJobStatus, DateTime selectedClosingDate, string selectedJobAdUrl, float selectedJobSalary, string selectedJobNotes)
        {
            InitializeComponent();

            // Set updating to true to indicate that we are editing an existing job
            updating = true;


            // Set the form title
            this.Text = "Edit Job";

            // Populate the fields with the selected job details
            this.jobId = selectedJobId;
            txtCompanyName.Text = selectedCompanyName;
            txtJobTitle.Text = selectedJobTitle;
            txtJobAdUrl.Text = selectedJobAdUrl;
            txtSalary.Text = Convert.ToString(selectedJobSalary);
            txtNotes.Text = selectedJobNotes;
            numJobImportance.Value = selectedJobImportance;
            comboStatus.SelectedItem = selectedJobStatus;

            ClosingDateSelector.Value = selectedClosingDate;
            Console.WriteLine($"Variable Value: {selectedClosingDate}");
            Console.WriteLine($"Selector Value: {selectedClosingDate}");
        }

        /// <summary>
        /// Event handler for the form load event. This method loads data into the form when it is opened.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewJob_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        /// <summary>
        /// Loads data into the form. This method populates the combo boxes and sets default values for the date selector.
        /// </summary>
        private void LoadData()
        {
            // load data for combo boxes
            List<string> jobStatuses = new List<string>();
            
            jobStatuses.Add("Interested");
            jobStatuses.Add("Applied");
            jobStatuses.Add("Interviewing");
            jobStatuses.Add("Successful");
            jobStatuses.Add("Unsuccessful");

            if (!updating)
            {
                ClosingDateSelector.Value = DateTime.Now.AddDays(7); // Set default closing date to 7 days from now
            }

            comboStatus.DataSource = jobStatuses;
            comboStatus.SelectedIndex = 0;            
        }


        /// <summary>
        /// Event handler for the "Paste" button. This method pastes the text from the clipboard into the job ad URL text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPasteJobAd_Click(object sender, EventArgs e)
        {
            txtJobAdUrl.Text = "";
            txtJobAdUrl.Text = Clipboard.GetText();
        }

        /// <summary>
        /// Event handler for the "Close" button. This method closes the form when the button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {           
            this.Close();
        }

        /// <summary>
        /// Event handler for the "Save Job" button. This method saves the job details when the button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveJob_Click(object sender, EventArgs e)
        {
            string jobStatus = comboStatus.SelectedItem.ToString();
            string companyName = txtCompanyName.Text.Trim();
            string jobTitle = txtJobTitle.Text.Trim();
            string jobAdUrl = txtJobAdUrl.Text.Trim();

            // Check if the URL is empty or not
            if (jobAdUrl == "")
            {
                jobAdUrl = "";// Leave it empty
            }
            else if (jobAdUrl != "" && jobAdUrl.StartsWith("http://") || jobAdUrl.StartsWith("https://"))
            {
                 // Leave it as is
            }
            else
            {
                jobAdUrl = "http://" + jobAdUrl; // Add http:// to the URL
            }

            string notes = txtNotes.Text.Trim();
            DateTime closingDate = ClosingDateSelector.Value;
            DateTime? interviewDate = DateTime.Now;
            float salary = 0;

            // Handle error if salary is not a number
            if (txtSalary.Text != "")
            {
                try
                {
                    salary = float.Parse(txtSalary.Text.Trim());
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter a valid salary.");
                    return;
                }
            }
            else
            {
                salary = 0;
            }

            int importance = Convert.ToInt32(numJobImportance.Value);

            // Check if the job title and company name are empty
            if (jobTitle == "" || companyName == "" )
            {
                MessageBox.Show("Please enter a job title.");
                return;
            }
            // Check if the job is being updated to avoid duplicate entries
            if (updating)
            {
                Job.UpdateJob(this.jobId, jobTitle, companyName, jobStatus, salary, closingDate, jobAdUrl, notes, importance);
            }
            else
            {
                Job.AddJob(jobTitle, companyName, jobStatus, salary, closingDate, jobAdUrl, notes, importance);
            }
            // Refresh the job tracking UI
            JobTracking.RefreshUI();
            // Close the form
            this.Close();
        }
    }
}
