// Name: John Coulter
//Class: HND Software Development: Graded Unit 2
//Project description: Job Interviewing and Tracking Application
//Date: 04/05/2025
// Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GU2.Classes;

namespace GU2
{
    /// <summary>
    /// Main entry point for the application.
    /// </summary>
    internal static class Program
    {
        // Database path for SQLite database
        public static string dbPath = @"..\..\db\main.db;Version=3;";

        // Static variables to hold user information
        public static string username;
        public static int userId;

        // Lists to be loaded from the database at login time
        public static List<Question> questions = new List<Question>();        
        public static List<Answer> answers = new List<Answer>();
        public static List<Job> jobs = new List<Job>();
        public static List<Question> filteredQuestions = new List<Question>();
        public static List<Job> filteredJobs = new List<Job>();
        public static List<int> DeletionRecords = new List<int>();
        public static List<int> AnswerRecords = new List<int>();
        public static List<Question> simulationList = new List<Question>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        
        
        static void Main()
        {
            username = "";
            userId = 0;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

        /// <summary>
        /// Clears all lists used in the application.
        /// </summary>
        public static void ClearLists()
        {
            questions.Clear();
            AnswerRecords.Clear();
            answers.Clear();
            jobs.Clear();
            DeletionRecords.Clear();
            filteredQuestions.Clear();
            filteredJobs.Clear();
            simulationList.Clear();
        }

        /// <summary>
        /// Populates the lists with data from the database.
        /// </summary>
        public static void LoadLists()
        {
            Question.CreateDeletionList(Program.userId);
            Question.CreateQuestionList(Program.userId);
            Answer.CreateAnswerList(Program.userId);
            Job.CreateJobList(Program.userId);

        }

        /// <summary>
        /// Refreshes the lists by clearing and repopulating them.
        /// </summary>
        public static void RefreshLists()
        {
            questions.Clear();
            AnswerRecords.Clear();
            answers.Clear();
            jobs.Clear();
            DeletionRecords.Clear();
            
            Question.CreateDeletionList(Program.userId);
            Question.CreateQuestionList(Program.userId);
            Answer.CreateAnswerList(Program.userId);
            Job.CreateJobList(Program.userId);
        }
    }
}
