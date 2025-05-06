// Name: John Coulter
//Class: HND Software Development: Graded Unit 2
//Project description: Job Interviewing and Tracking Application
//Date: 04/05/2025
// JobTracking.cs
using GU2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GU2.Forms
{
    /// <summary>
    /// This form allows the user to track their job applications, including adding, editing, and deleting jobs.
    /// </summary>
    public partial class JobTracking : Form
    {
        // Static variables to hold job information
        public static int selectedJobId;
        public static string selectedJobTitle;
        public static string selectedCompanyName;
        public static int selectedJobImportance;
        public static DateTime selectedClosingDate;        
        public static string selectedJobStatus;
        public static float selectedJobSalary;
        public static string selectedJobNotes;
        public static int selectedUserId;
        public static string selectedJobAdUrl;

        public JobTracking()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Event handler for the form load event. This method initializes the form and loads data from the lists.
        /// </summary>
        /// <param name="filtered"></param>
        private void LoadData(bool filtered)
        {
            // Load the list of jobs
            Job.CreateJobList(Program.userId);

            DataTable dt;

            // If a filter is applied, we need to filter the questions
            if (filtered)
            {
                // Create a filtered list of questions
                Job.CreateFilteredQuestionList(
                            status: comboStatus.SelectedItem.ToString(),                   
                            hideAppliedFor: chkHideAppliedJobs.Checked,
                            keyword: txtKeyword.Text.Trim(),
                            showUpcoming: chkShowUpcoming.Checked
                );

                // Populate the DataTable with the filtered questions
                dt = Job.PopulateFilteredDataTable(
                            userId: Program.userId,
                            status: comboStatus.SelectedItem.ToString(),
                            hideAppliedFor: chkHideAppliedJobs.Checked,
                            keyword: txtKeyword.Text.Trim(),
                            showUpcoming: chkShowUpcoming.Checked
     );
            }
            else
            {
                // No filters: populate table from job list
                dt = Job.PopulateDataTable();
            }

            // Set the DataGridView properties
            DataGridViewer.AutoGenerateColumns = true;
            DataGridViewer.DataSource = dt;

            // Hide the columns that are not needed
            foreach (var col in new[] { "userId", "jobId" })
                if (DataGridViewer.Columns.Contains(col))
                    DataGridViewer.Columns[col].Visible = false;

            // Set Form title to reflect the number of jobs
            this.Text = $"Showing List of Jobs [{DataGridViewer.RowCount} Jobs]";

            // If the liost has been filtered and there are no jobs, show a message
            if (filtered && DataGridViewer.RowCount == 0)
            {
                lblJobTitle.Text = "No jobs found that matched your selected filters";
            }
            // No jobs found, clear the labels
            else if (DataGridViewer.RowCount == 0)
            {
                lblJobTitle.Text = "No jobs found";
                lblSelectedJob.Text = "";
                panel1.BackColor = Color.Black;
            }
            else
            {
                PopulateInfoLabel();
            }
        }
        /// <summary>
        /// Event handler for the "Add Job" button. This method opens the NewJob form to add a new job.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            NewJob newJob = new NewJob();
            newJob.ShowDialog();
        }

        /// <summary>
        /// This method populates the info label with the selected job details.
        /// </summary>
        private void PopulateInfoLabel()
        {
            // Calculate dqays until the deadline and set the label text
            string deadline = "";
            int daysToClosing = (selectedClosingDate - DateTime.Now.Date).Days;

            // Change the UI depending on the number of days to closing date
            if (daysToClosing < 0)
            {
                deadline = $"Application deadline has passed";
            }
            else if (daysToClosing == 0)
            {
                deadline = $"Application deadline is today";
                panel1.BackColor = Color.Red;
            }
            else if (daysToClosing == 1)
            {
                deadline = $"Application deadline is tomorrow";
                panel1.BackColor = Color.Red;
            }
            else if (daysToClosing < 7)
            {
                deadline = $"Application deadline is in {daysToClosing} days";
                panel1.BackColor = Color.Orange;
            }
            else
            {
                deadline = $"Application deadline is in {daysToClosing} days";
                panel1.BackColor = Color.LightGreen;

            }
            // Set the label text with the selected job details
            lblJobTitle.Text = $"{selectedJobTitle} at {selectedCompanyName}";
            lblSelectedJob.Text =
                $"Importance: {selectedJobImportance}\n" +
                $"Closing Date: {selectedClosingDate.ToString("yyyy-MM-dd")} ({deadline})\n" +
                $"Status: {selectedJobStatus}\n" +
                $"Salary: {selectedJobSalary}\n" +
                $"notes: {selectedJobNotes}\n";
        }
        /// <summary>
        /// Event handler for the form load event. This method initializes the form and sets allowed values for the combo box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JobTracking_Load(object sender, EventArgs e)
        {
            List<string> jobstatuses = new List<string>();

            // comboStatuses data source
            jobstatuses.Add("");
            jobstatuses.Add("Interested");
            jobstatuses.Add("Applied");
            jobstatuses.Add("Interviewing");
            jobstatuses.Add("Successful");
            jobstatuses.Add("Unsuccessful");

            comboStatus.DataSource = jobstatuses;

            LoadData(false);
        }

        /// <summary>
        /// Event handler for the DataGridView selection changed event. This method updates the selected job details when the user selects a different job in the DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewer_SelectionChanged(object sender, EventArgs e)
        {
            // if there's no current data‐row (e.g. you clicked on the header), just skip
            if (DataGridViewer.CurrentRow == null || DataGridViewer.CurrentRow.Index < 0)
                return;

            // now it's safe to dereference CurrentRow.Cells…
            selectedJobId = Convert.ToInt32(DataGridViewer.CurrentRow.Cells["jobId"].Value);
            selectedJobTitle = DataGridViewer.CurrentRow.Cells["jobTitle"].Value.ToString();
            selectedCompanyName = DataGridViewer.CurrentRow.Cells["companyName"].Value.ToString();
            selectedJobImportance = Convert.ToInt32(DataGridViewer.CurrentRow.Cells["importance"].Value);
            selectedClosingDate = Convert.ToDateTime(DataGridViewer.CurrentRow.Cells["closingDate"].Value);
            selectedJobStatus = DataGridViewer.CurrentRow.Cells["status"].Value.ToString();
            selectedJobSalary = Convert.ToSingle(DataGridViewer.CurrentRow.Cells["salary"].Value);
            selectedJobAdUrl = DataGridViewer.CurrentRow.Cells["jobAdUrl"].Value.ToString();    
            selectedUserId = Program.userId;
            selectedJobNotes = DataGridViewer.CurrentRow.Cells["notes"].Value.ToString();

            // Show the View Job Ad button if the URL is not empty
            if (selectedJobAdUrl != "")
            {
                btnViewJobAd.Visible = true;
                
            }
            else
            {
                btnViewJobAd.Visible = false;
            }

            // Show the Edit and Delete buttons if a job is selected
            if (selectedJobId >0)
            {
                btnDeleteJob.Visible = true;
                btnEditJob.Enabled = true;
                btnEditJob.Visible = true;
            }
            else
            {
                btnDeleteJob.Visible = false;
                btnEditJob.Enabled = false;
                btnEditJob.Visible = false;
            }
            // Update the UI with the selected job details
            PopulateInfoLabel();
        }

        /// <summary>
        /// Event handler for the "Filter" button. This method filters the job list based on the selected criteria.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilter_Click(object sender, EventArgs e)
        {
            // store the filter values
            string status = comboStatus.SelectedItem.ToString();            
            bool hideAppliedFor = chkHideAppliedJobs.Checked;
            bool showUpcomingOnly = chkShowUpcoming.Checked;
            string keyword = txtKeyword.Text.Trim();

            // Try to filter the questions
            Job.CreateFilteredQuestionList(status, hideAppliedFor, showUpcomingOnly, keyword);

            // Load a filtered list of questions
            LoadData(true);
        }

        /// <summary>
        /// Event handler for the "Clear Filters" button. This method clears the filters and reloads the job list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            chkShowUpcoming.Checked = false;
            chkHideAppliedJobs.Checked = false;
            txtKeyword.Text = "";
            comboStatus.SelectedIndex = 0;

            // Load an unfuiltered list of questions
            LoadData(false);
        }

        /// <summary>
        /// Event handler for the "View Job Ad" button. This method opens the job ad URL in the default web browser.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewJobAd_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(selectedJobAdUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: Could not open URL\n\n{ex}","Error");
            }
        }

        /// <summary>
        /// This method refreshes the UI by reloading the job list and updating the DataGridView.
        /// </summary>
        public static void RefreshUI()
        {
            // Refresh the UI
            // This method can be called from other forms to refresh the UI
            var form = Application.OpenForms.OfType<JobTracking>().FirstOrDefault();
            if (form == null)
                return; // nothing to refresh

            // Call LoadData on the UI thread
            if (form.InvokeRequired)
            {
                form.Invoke(new MethodInvoker(() => form.LoadData(false)));
            }
            else
            {
                form.LoadData(false);
            }

        }

        /// <summary>
        /// Event handler for the "Delete Job" button. This method deletes the selected job from the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteJob_Click(object sender, EventArgs e)
        {
            // variables to hold the selected job details
            int selectedJobId = Convert.ToInt32(DataGridViewer.CurrentRow.Cells["jobId"].Value);
            string selectedCompanyName = DataGridViewer.CurrentRow.Cells["companyName"].Value.ToString();
            string selectedJobTitle = DataGridViewer.CurrentRow.Cells["jobTitle"].Value.ToString();

            // Warn user that the selected question will be deleted
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete this job? This action cannot be undone.\n\nJob ID: {selectedJobId}\nCompany Name: {selectedCompanyName}\nJob Title: {selectedJobTitle}",
                "Delete Job",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (result == DialogResult.Yes)// User selects yes
            {
                // Delete the selected job
                Job.DeleteJob(selectedJobId);
                // Refresh the UI with unfiltered data
                LoadData(false);
            }
        }

        /// <summary>
        /// Event handler for the "Close" button. This method closes the JobTracking form and opens the Dashboard form.
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
        /// Event handler for the "Edit Job" button. This method opens the NewJob form to edit the selected job.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditJob_Click(object sender, EventArgs e)
        {
            // Open NewJob form with the selected job details
            NewJob editJob = new NewJob(selectedJobId, selectedUserId, selectedCompanyName, selectedJobImportance, selectedJobTitle, selectedJobStatus, selectedClosingDate, selectedJobAdUrl, selectedJobSalary, selectedJobNotes);
            editJob.ShowDialog();
        }
    }
}
    

