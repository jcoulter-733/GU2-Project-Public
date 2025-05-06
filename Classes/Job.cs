// Name: John Coulter
//Class: HND Software Development: Graded Unit 2
//Project description: Job Interviewing and Tracking Application
//Date: 04/05/2025
// Job.cs
using GU2.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GU2.Classes
{
    /// <summary>
    /// Job class represents a job ad listing to be tracked
    /// </summary>
    internal class Job
    {
        private int jobId { get; set; }
        private int userId { get; set; }
        private int importance { get; set; }
        private string companyName { get; set; }
        private string jobTitle { get; set; }
        private string status { get; set; }
        private DateTime closingDate { get; set; }
        
        private string jobAdUrl { get; set; }
        private float salary { get; set; }
        private string notes { get; set; }

        /// <summary>
        /// Default constructor for the Job class.
        /// </summary>
        public Job()
        {
            // Empty constructor
        }

        /// <summary>
        /// Function to create a list of jobs from the database for current user.
        /// </summary>
        /// <param name="userId"></param>
        public static void CreateJobList(int userId)
        {
            // Clear the list of jobs
            Program.jobs.Clear();

            // Create the Query to run
            string connString = $"Data Source={Program.dbPath}";
            using (var db = new DatabaseManagement(connString))
            {
                string sql = $@"
                                SELECT
                                    jobId,
                                    userId,
                                    companyName,
                                    importance,
                                    jobTitle,
                                    status,
                                    closingDate,                
                                    jobAdUrl,
                                    salary,
                                    notes

                            FROM Jobs
                            WHERE userId = {userId}
                            ORDER BY closingDate DESC;
                ";

                DataTable dt = db.ExecuteQuery(sql);

                // Turn each row into a Question instance
                foreach (DataRow row in dt.Rows)
                {
                    var j = new Job()
                    {
                        jobId = Convert.ToInt32(row["jobId"]),
                        userId = Convert.ToInt32(row["userId"]),
                        companyName = row["companyName"].ToString(),
                        importance = Convert.ToInt32(row["importance"]),
                        jobTitle = row["jobTitle"].ToString(),
                        status = row["status"].ToString(),
                        closingDate = Convert.ToDateTime(row["closingDate"]),                        
                        jobAdUrl = row["jobAdUrl"].ToString(),
                        salary = Convert.ToSingle(row["salary"]),
                        notes = row["notes"].ToString()
                    };
                    // Add Job to the list
                    Program.jobs.Add(j);
                }
            }

        }

        /// <summary>
        /// Function to add a job to the database.
        /// </summary>
        /// <param name="jobTitle"></param>
        /// <param name="companyName"></param>
        /// <param name="jobStatus"></param>
        /// <param name="salary"></param>
        /// <param name="closingDate"></param>
        /// <param name="jobAdUrl"></param>
        /// <param name="notes"></param>
        /// <param name="importance"></param>
        public static void AddJob(string jobTitle, string companyName, string jobStatus, float salary, DateTime closingDate, string jobAdUrl, string notes, int importance)
        {
            // Create SQL statement
            string sql = $@"
                            INSERT INTO Jobs
                            (userId, companyName, importance, jobTitle, status, closingDate, jobAdUrl, salary, notes)
                            VALUES
                            ({Program.userId}, '{companyName}', {importance}, '{jobTitle}', '{jobStatus}', '{closingDate:yyyy-MM-dd}', '{jobAdUrl}', {salary}, '{notes}');
            ";

            // Execute the query
            string connString = $"Data Source={Program.dbPath}";
            using (var db = new DatabaseManagement(connString))
            {
                db.ExecuteQuery(sql);
            }
        }

        /// <summary>
        /// Function to update a job in the database.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="jobTitle"></param>
        /// <param name="companyName"></param>
        /// <param name="jobStatus"></param>
        /// <param name="salary"></param>
        /// <param name="closingDate"></param>
        /// <param name="jobAdUrl"></param>
        /// <param name="notes"></param>
        /// <param name="importance"></param>
        public static void UpdateJob(int jobId, string jobTitle, string companyName, string jobStatus, float salary, DateTime closingDate, string jobAdUrl, string notes, int importance)
        {
            // Create the SQL statement
            string sql = $@"
                Update Jobs
                SET companyName = '{companyName}',
                    importance = {importance},
                    jobTitle = '{jobTitle}',
                    status = '{jobStatus}',
                    closingDate = '{closingDate:yyyy-MM-dd}',
                    jobAdUrl = '{jobAdUrl}',
                    salary = {salary},
                    notes = '{notes}'
                WHERE jobId = {jobId};
                
                
            ";
            // Run the query via your DatabaseManagement helper
            string connString = $"Data Source={Program.dbPath}";
            using (var db = new DatabaseManagement(connString))
            {
                db.ExecuteQuery(sql);
            }

        }

        /// <summary>
        /// Function to delete all users jobs from the database.
        /// </summary>
        public static void DeleteJob()
        {
            string sql = "DELETE FROM Jobs WHERE userId = @userId";
            var parms = new Dictionary<string, object>
            {
                ["@userId"] = Program.userId
            };
            using (DatabaseManagement db = new DatabaseManagement($"Data Source={Program.dbPath}"))
            {
                try
                {
                    db.OpenConnection();
                    // Execute the delete command
                    int rowsAffected = db.ExecuteNonQuery(sql, parms);
                    // Check if the deletion was successful
                    if (rowsAffected > 0)
                    {
                        // Refresh the list of jobs
                        Program.RefreshLists();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting jobs: " + ex.Message);
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }
        /// <summary>
        /// Function to delete a specific job from the database.
        /// </summary>
        /// <param name="jobId"></param>
        public static void DeleteJob(int jobId)
        {
            // Find the job in the list
            var job = Program.jobs.FirstOrDefault(j => j.jobId == jobId);

            if (job == null) // The job was not found
            {
                MessageBox.Show("Job not found.","Delete Failed",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            using (var db = new DatabaseManagement($"Data Source={Program.dbPath}"))
            {
                try
                {
                    var logParams = new Dictionary<string, object>
                    {
                        ["@userId"] = Program.userId,
                        ["@jobId"] = jobId,

                    };

                    int rowsDeleted = 0;
                    // Check if the job belongs to the current user
                    if (job.userId == Program.userId)
                    {
                            string deleteSql = @"
                            DELETE FROM jobs
                            WHERE jobId = @jobId;
                            ";
                        // Execute the delete command
                        rowsDeleted = db.ExecuteNonQuery(deleteSql, logParams);
                    }
                    
                    // Remove from any in‑memory lists so the UI updates
                    Program.jobs.Remove(job);
                    Program.filteredJobs.Remove(job);

                    // Show a message to confirm deletion
                    if (rowsDeleted > 0) 
                    {
                        MessageBox.Show("Job deleted successfully.","Delete Successful",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else // Handle error if job wasn't deleted
                    {
                        MessageBox.Show("Failed to delete job. It may not exist.","Delete Failed",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }

                }
                catch (Exception ex) // Handle any other error and display the error message
                {
                    MessageBox.Show($"Error deleting question: {ex.Message}","Database Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Function to count the number of jobs in users list of jobs with a closing date within the next 7 days.
        /// </summary>
        /// <returns></returns>
        public static int DeadlinesApproaching()
        {
            // count the number of jobs with a closing date within the next 7 days

            int count = 0;
            foreach (var job in Program.jobs)
            {
                if (job.closingDate >= DateTime.Now && job.closingDate <= DateTime.Now.AddDays(7))
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Function to return a DataTable with the list of jobs.
        /// </summary>
        /// <returns></returns>
        public static DataTable PopulateDataTable()
        {
            // Create a new DataTable
            DataTable dt = new DataTable();
            // Add columns to the DataTable
            dt.Columns.Add("jobId", typeof(int));
            dt.Columns.Add("userId", typeof(int));
            dt.Columns.Add("companyName", typeof(string));
            dt.Columns.Add("importance", typeof(int));
            dt.Columns.Add("jobTitle", typeof(string));
            dt.Columns.Add("status", typeof(string));
            dt.Columns.Add("closingDate", typeof(DateTime));            
            dt.Columns.Add("jobAdUrl", typeof(string));
            dt.Columns.Add("salary", typeof(float));
            dt.Columns.Add("notes", typeof(string));

            // Populate the DataTable with data from the questions list
            foreach (var job in Program.jobs)
            {
                dt.Rows.Add(job.jobId, job.userId, job.companyName, job.importance, job.jobTitle, job.status, job.closingDate, job.jobAdUrl, job.salary, job.notes);
            }
            return dt;
        }

        /// <summary>
        /// Function to create a filtered list of jobs to display
        /// </summary>
        /// <param name="status"></param>
        /// <param name="hideAppliedFor"></param>
        /// <param name="showUpcoming"></param>
        /// <param name="keyword"></param>
        public static void CreateFilteredQuestionList(string status, bool hideAppliedFor, bool showUpcoming, string keyword)
        {
            // Copy the full list of questions
            var list = Program.jobs.ToList();


            // Hide jobs that are already applied for
            if (hideAppliedFor)
            {
                list.RemoveAll(j => j.status.Equals("Applied", StringComparison.OrdinalIgnoreCase));
            }

            // Show only upcoming jobs (Closing date is in the future)
            if (showUpcoming)
            {
                list.RemoveAll(j => j.closingDate < DateTime.Now);
            }


            // filter by the status
            if (!string.IsNullOrEmpty(status))
            {
                list.RemoveAll(j => !j.status.Equals(status, StringComparison.OrdinalIgnoreCase));
            }

            

            // keyword search is last to filter a smaller list
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                list.RemoveAll(j => j.jobTitle.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) < 0);
            }

            // Save back into filteredQuestions
            Program.filteredJobs = list;
        }

        /// <summary>
        /// Function to return a filtered DataTable of jobs to display
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="status"></param>
        /// <param name="hideAppliedFor"></param>
        /// <param name="showUpcoming"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public static DataTable PopulateFilteredDataTable(int userId, string status = null, bool hideAppliedFor= false, bool showUpcoming = true, string keyword = null)
        {
            // Copy the full list of questions
            var list = Program.jobs.ToList();


            // Hide jobs that are already applied for
            if (hideAppliedFor)
            {
                list.RemoveAll(j => j.status.Equals("Applied", StringComparison.OrdinalIgnoreCase));
            }

            // Show only upcoming jobs (Closing date is in the future)
            if(showUpcoming)
            {
                list.RemoveAll(j => j.closingDate < DateTime.Now);
            }

            // filter by the status
            if (!string.IsNullOrEmpty(status))
            {
                list.RemoveAll(j => !j.status.Equals(status, StringComparison.OrdinalIgnoreCase));
            }



            // keyword search is last to filter a smaller list
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                list.RemoveAll(j => j.jobTitle.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) < 0);
            }

            // 3) Materialize to a DataTable

            DataTable dt = new DataTable();
            dt.Columns.Add("jobId", typeof(int));
            dt.Columns.Add("userId", typeof(int));
            dt.Columns.Add("companyName", typeof(string));
            dt.Columns.Add("importance", typeof(int));
            dt.Columns.Add("jobTitle", typeof(string));
            dt.Columns.Add("status", typeof(string));
            dt.Columns.Add("closingDate", typeof(DateTime));
            dt.Columns.Add("jobAdUrl", typeof(string));
            dt.Columns.Add("salary", typeof(float));
            dt.Columns.Add("notes", typeof(string));
            // Populate the DataTable with data from the questions list
            foreach (var job in Program.filteredJobs)
            {
                dt.Rows.Add(job.jobId, job.userId, job.companyName, job.importance, job.jobTitle, job.status, job.closingDate, job.jobAdUrl, job.salary, job.notes);
            }
            return dt;
        }
    }
}