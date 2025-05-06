// Name: John Coulter
//Class: HND Software Development: Graded Unit 2
//Project description: Job Interviewing and Tracking Application
//Date: 04/05/2025
// Question.cs
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO.Pipes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GU2.Classes
{
    /// <summary>
    /// The Question class represents a question in the application.
    /// </summary>
    internal class Question
    {
        internal int userId { get; set; }
        internal int questionId { get; set; }
        internal string question { get; set; }
        internal string questionType { get; set; }
        internal string questionBehaviour { get; set; }
        internal DateTime addedAt { get; set; }

        /// <summary>
        /// Default constructor for the Question class.
        /// </summary>
        public Question()
        {
            // Empty constructor
        }

        /// <summary>
        /// Adds a new question to the database.
        /// </summary>
        /// <param name="question"></param>
        /// <param name="type"></param>
        /// <param name="behaviour"></param>
        public static void AddQuestion(string question, string type, string behaviour)
        {
            // Create a new question object with the provided details
            Question newQuestion = new Question
            {
                userId = Program.userId,
                questionId = 0,
                question = question,
                questionType = type,
                questionBehaviour = behaviour,
                addedAt = DateTime.Now
            };

            // Add the question to the database
            using (var db = new DatabaseManagement($"Data Source={Program.dbPath}"))
            {
                try
                {
                    // Create the query
                    string query = @"
                                    INSERT INTO questions
                                        (userId, question, questionType, questionBehaviour)
                                    VALUES
                                        (@userId, @question, @questionType, @questionBehaviour);
                    ";

                    // Set the parameters
                    var parms = new Dictionary<string, object>
                    {
                        ["@userId"] = Program.userId,
                        ["@question"] = question,
                        ["@questionType"] = type,
                        ["@questionBehaviour"] = behaviour
                    };

                    // Check if the question was added successfully
                    int rowsAffected = db.ExecuteNonQuery(query, parms);

                    // Show a message to the user with the result
                    MessageBox.Show(rowsAffected == 1? "Question added successfully!"
                          : "No rows were inserted. Please check your data.",
                        rowsAffected == 1 ? "Success" : "Insert Failed",
                        MessageBoxButtons.OK,
                        rowsAffected == 1 ? MessageBoxIcon.Information : MessageBoxIcon.Warning
                    );
                }
                catch (Exception ex) // Handle any error and display the error message
                {
                    MessageBox.Show($"Error inserting question: {ex.Message}","Database Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }

        }
        /// <summary>
        /// Updates an existing question in the database.
        /// Only questions added by the user can be edited, This is verified before the function is called. But the sql statement also prevents it.
        /// </summary>
        /// <param name="questionId"></param>
        /// <param name="question"></param>
        /// <param name="type"></param>
        /// <param name="behaviour"></param>
        public static void UpdateQuestion(int questionId, string question, string type, string behaviour)
        {            
            string sql = "UPDATE Questions SET question = @question, questionType = @questionType, questionBehaviour = @questionBehaviour WHERE questionId = @questionId AND userId = @userId";
            // set the parameters
            var parms = new Dictionary<string, object>
            {
                ["@questionId"] = questionId,
                ["@userId"] = Program.userId,
                ["@question"] = question,
                ["@questionType"] = type,
                ["@questionBehaviour"] = behaviour
            };
            using (DatabaseManagement db = new DatabaseManagement($"Data Source={Program.dbPath}"))
            {
                try
                {
                    db.OpenConnection();
                    // Execute the update command
                    int rowsAffected = db.ExecuteNonQuery(sql, parms);
                    // Check if the update was successful
                    if (rowsAffected > 0)
                    {
                        // FInd the question to be updated in the in-memory list
                        var questionToUpdate = Program.questions.FirstOrDefault(q => q.questionId == questionId);
                        if (questionToUpdate != null) // if it was found, update it with the new values
                        {
                            questionToUpdate.question = question;
                            questionToUpdate.questionType = type;
                            questionToUpdate.questionBehaviour = behaviour;
                        }
                    }
                }
                catch (Exception ex) // Handle any error and display the error message
                {
                    MessageBox.Show("Error updating question: " + ex.Message);
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }
        /// <summary>
        /// Deletes all questions added by the current user from the database.
        /// </summary>
        public static void DeleteQuestion()
        {
            // Create Sql statement to delete all questions added by the current user
            string sql = "DELETE FROM Questions WHERE userId = @userId";
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
                        // Clear the in-memory list of deleted records
                        Program.questions.Clear();
                        Question.CreateQuestionList(Program.userId);

                    }
                }
                catch (Exception ex)
                // Handle any error and display the error message
                {
                    MessageBox.Show("Error deleting questions: " + ex.Message);
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }
        /// <summary>
        /// Deletes a specific question from the database.
        /// Only questions added by the user can be deleted. for system questions, the function will create a deletion record to hide it from the user.
        /// </summary>
        /// <param name="questionId"></param>
        public static void DeleteQuestion(int questionId)
        {
            // Find the question in list
            var question = Program.questions.FirstOrDefault(q => q.questionId == questionId);
            bool deletionRecordExists = Program.DeletionRecords.Contains(questionId); // check if the question has already been deleted

            if (question == null) // if the question was not found, show a message and return
            {
                MessageBox.Show("Question not found.","Delete Failed",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if(deletionRecordExists) // if the question has already been deleted, show a message and return
            {
                MessageBox.Show("Question has already been deleted.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new DatabaseManagement($"Data Source={Program.dbPath}"))
            {
                try
                {
                    // Create a deletion record for this question
                    const string insertLogSql = @"
                                                INSERT INTO QuestionDeletion
                                                (userId, questionId)
                                                VALUES(@deleterId, @questionId);
                                                ";
                    // Set the parameters
                    var logParams = new Dictionary<string, object>
                    {
                        ["@deleterId"] = Program.userId,
                        ["@questionId"] = questionId,

                    };
                    // Execute the insert command
                    db.ExecuteNonQuery(insertLogSql, logParams);

                    int rowsDeleted = 0;

                    // User created questions can be removed
                    if (question.userId == Program.userId)
                    {
                        const string deleteSql = @"
                                                    DELETE FROM questions
                                                    WHERE questionId = @questionId;
                        ";
                        rowsDeleted = db.ExecuteNonQuery(deleteSql, logParams);
                    }

                    // Remove from any in‑memory lists so the UI updates
                    Program.questions.Remove(question);
                    Program.filteredQuestions?.Remove(question);

                    // Let the user know what happened
                    if (question.userId == Program.userId)
                    {
                        Answer.DeleteAnswer(question.questionId);
                        // User created question Was deleted permanently
                        MessageBox.Show(
                            rowsDeleted == 1
                              ? "Your question was deleted successfully."
                              : "The question couldn't be deleted.",
                            rowsDeleted == 1 ? "Deleted" : "Warning",
                            MessageBoxButtons.OK,
                            rowsDeleted == 1 ? MessageBoxIcon.Information : MessageBoxIcon.Warning
                        );
                    }
                    else
                    {
                        Answer.DeleteAnswer(question.questionId);
                        // System question had a delete record created
                        MessageBox.Show(
                            "System question deletion has been recorded.",
                            "Deletion Recorded",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Error deleting question: {ex.Message}",
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }
        /// <summary>
        /// Function to return a filtered DataTable of questions based on the selected filters.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="type"></param>
        /// <param name="behaviour"></param>
        /// <param name="answered"></param>
        /// <param name="includeSystem"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public static DataTable PopulateFilteredDataTable(int userId, string type = null, string behaviour = null, bool answered = false, bool includeSystem = true, string keyword = null)
        {
            // Make a copy of the full list of questions
            var list = Program.questions.ToList();

            // Apply filters to the list
            if (!string.IsNullOrWhiteSpace(type)) // Filter by question type, if the filter was blank, it will not be applied
                list.RemoveAll(q =>
                    !q.questionType.Equals(type, StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrWhiteSpace(behaviour)) // Filter by question behaviour, if the filter was blank, it will not be applied
                list.RemoveAll(q =>
                    !q.questionBehaviour.Equals(behaviour, StringComparison.OrdinalIgnoreCase));

            if (!includeSystem) // If the user does not want to see system questions, remove them from the list (compare userId of question with 0 (The system userId))
                list.RemoveAll(q => q.userId == 0);

            if (!answered) // If the user does not want to see answered questions, remove them from the list (Compare questionId with the list of answered questions)
                list.RemoveAll(q => Program.AnswerRecords.Contains(q.questionId));

            if (!string.IsNullOrWhiteSpace(keyword)) // If the user has entered a keyword, remove all questions that do not contain the keyword (case insensitive)
                list.RemoveAll(q =>
                    q.question.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) < 0);

            // Create the datable to hold the filtered questions
            var dt = new DataTable();
            dt.Columns.Add("userId", typeof(int));
            dt.Columns.Add("questionId", typeof(int));
            dt.Columns.Add("question", typeof(string));
            dt.Columns.Add("questionType", typeof(string));
            dt.Columns.Add("questionBehaviour", typeof(string));
            dt.Columns.Add("addedAt", typeof(DateTime));

            // Populate the DataTable with the filtered questions
            foreach (var q in list)
                dt.Rows.Add(q.userId, q.questionId, q.question, q.questionType, q.questionBehaviour, q.addedAt);

            return dt;
        }
        /// <summary>
        /// Function to return a DataTable of all questions in the database.
        /// </summary>
        /// <returns></returns>
        public static DataTable PopulateDataTable()
        {
            // Create a new DataTable
            DataTable dt = new DataTable();
            // Add columns to the DataTable
            dt.Columns.Add("userId", typeof(int));
            dt.Columns.Add("questionId", typeof(int));
            dt.Columns.Add("question", typeof(string));
            dt.Columns.Add("questionType", typeof(string));
            dt.Columns.Add("questionBehaviour", typeof(string));
            dt.Columns.Add("addedAt", typeof(DateTime));
            // Populate the DataTable with data from the questions list
            foreach (var question in Program.questions)
            {
                dt.Rows.Add(question.userId, question.questionId, question.question, question.questionType, question.questionBehaviour, question.addedAt);
            }
            return dt;
        }

        /// <summary>
        /// Function to return the number of questions added by the current user.
        /// </summary>
        /// <returns></returns>
        public static int CountUserQuestions()
        {
            int number = Program.questions.Count(q => q.userId == Program.userId);
            return number;
        }

        /// <summary>
        /// Function to create a filtered list of questions based on the selected filters.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="behaviour"></param>
        /// <param name="showSystemQuestions"></param>
        /// <param name="keyword"></param>
        /// <param name="answered"></param>
        public static void CreateFilteredQuestionList(string type, string behaviour, bool showSystemQuestions, string keyword, bool answered)
        {
            // Copy the full list of questions
            var list = Program.questions.ToList();


            
            if (!answered) // Remove all answered questions by comparing the questionId with the list of answered questions
            {
                list.RemoveAll(q => Program.AnswerRecords.Contains(q.questionId));
            }

            
            if (!showSystemQuestions) // Remove all system questions by comparing the userId with 0 (The system userId)
            {
                list.RemoveAll(q => q.userId == 0);
            }
            
            if (!string.IsNullOrEmpty(type)) // Filter by the question type, if the filter was blank, it will not be applied
            {
                list.RemoveAll(q =>
                    !q.questionType.Equals(type, StringComparison.OrdinalIgnoreCase));
            }

            
            if (!string.IsNullOrEmpty(behaviour)) // Filter by the question behaviour, if the filter was blank, it will not be applied
            {
                list.RemoveAll(q =>
                    !q.questionBehaviour.Equals(behaviour, StringComparison.OrdinalIgnoreCase));
            }

            
            if (!string.IsNullOrWhiteSpace(keyword)) // If the user has entered a keyword, remove all questions that do not contain the keyword (case insensitive)
            {
                list.RemoveAll(q =>
                    q.question.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) < 0);
            }

            // Save back into filteredQuestions
            Program.filteredQuestions = list;
        }


        /// <summary>
        /// Function to create a list of questions from the database.
        /// </summary>
        /// <param name="userId"></param>
        public static void CreateQuestionList(int userId)
        {
            // load the set of questionIds the user has deleted
            CreateDeletionList(userId);

            // Clear existing in‑memory list
            Program.questions.Clear();


            string connString = $"Data Source={Program.dbPath}";
            using (var db = new DatabaseManagement(connString))
            {
                string sql = $@"
                                SELECT
                                    userId,
                                    questionId,
                                    question,
                                    questionType,
                                    questionBehaviour,
                                    addedAt
                                FROM Questions
                                WHERE userId = 0 OR userId = {userId}
                                ORDER BY addedAt;
                ";
                // Execute the query and save the results in a DataTable
                DataTable dt = db.ExecuteQuery(sql);

                // for each row in the DataTable, create a new Question object and add it to the list
                foreach (DataRow row in dt.Rows)
                {
                    var q = new Question
                    {
                        userId = Convert.ToInt32(row["userId"]),
                        questionId = Convert.ToInt32(row["questionId"]),
                        question = row["question"].ToString(),
                        questionType = row["questionType"].ToString(),
                        questionBehaviour = row["questionBehaviour"].ToString(),
                        addedAt = DateTime.Parse(row["addedAt"].ToString())
                    };

                    Program.questions.Add(q);
                }
            }
            // Remove all questions that have been 'deleted' by the user by comparing the questionId with the list of deleted questions
            Program.questions.RemoveAll(q => Program.DeletionRecords.Contains(q.questionId));
        }

        /// <summary>
        /// Function to create a list of deleted questionIds from the database.
        /// </summary>
        /// <param name="userId"></param>
        public static void CreateDeletionList(int userId)
        {
            // Clear the list
            Program.DeletionRecords.Clear();

            // Fetch all deletion records for this user
            string connString = $"Data Source={Program.dbPath}";
            using (var db = new DatabaseManagement(connString))
            {
                string sql = $@"
                            SELECT questionId
                            FROM QuestionDeletion
                            WHERE userId = {userId}
                            ORDER BY questionId;
                ";
                // Execute the query and save the results in a DataTable
                DataTable dt = db.ExecuteQuery(sql);

                // For each row in the DataTable, add the questionId to the list of deleted questions
                foreach (DataRow row in dt.Rows)
                {
                    Program.DeletionRecords.Add(Convert.ToInt32(row["questionId"]));
                }
            }
        }

        /// <summary>
        /// Function to restore all 'deleted' system questions for the current user.
        /// </summary>
        public static void RestoreSystemQuestions()
        {
            // Create Sql statement to delete all the users deletion records
            string sql = "DELETE FROM QuestionDeletion WHERE userId = @userId";
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
                        // Redfresh the in-memory list of deleted records
                        Program.RefreshLists();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error restoring questions: " + ex.Message);
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }
    }
}



