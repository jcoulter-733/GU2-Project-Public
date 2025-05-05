/// John Coulter
/// Graded Unit 2 Project
/// Job Interviewing and Tracking Application
/// 04/05/2025
/// AccountSettings.cs
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GU2.Classes
{
    /// <summary>
    /// This class represents an answer to a question in the database.
    /// </summary>
    internal class Answer
    {
        //Properties
        private int answerId { get; set; }
        private int questionId { get; set; }
        private int userId { get; set; }
        private string answer { get; set; }
        private DateTime answeredAt { get; set; }

        /// <summary>
        /// Default constructor for the Answer class.
        /// </summary>
        public Answer()
        {
            // empty constructor
        }
        /// <summary>
        /// Function to return an answerId
        /// </summary>
        /// <returns></returns>
        private int GetAnswerId()
        {
            return answerId;
        }

        /// <summary>
        /// Function to populate answerRecords list<int> of answerIds for a logged in user.
        /// This is how the system tracks which questions have been answered.
        /// </summary>
        /// <param name="userId"></param>
        public static void CreateAnswerList(int userId)
        {
            // Make sure the list is empty before populating it
            Program.AnswerRecords.Clear();

            // Fetch all answer records for the given userId
            string connString = $"Data Source={Program.dbPath}";
            using (var db = new DatabaseManagement(connString))
            {
                string sql = $@"
                    SELECT questionId
                    FROM Answers
                    WHERE userId = {userId}
                    ORDER BY questionId;
                    ";

                DataTable dt = db.ExecuteQuery(sql);

                // Add the QuestionId to the AnswerRecords list
                foreach (DataRow row in dt.Rows)
                {
                    Program.AnswerRecords.Add(Convert.ToInt32(row["questionId"]));
                }
            }
        }

        /// <summary>
        /// Function to save an answer to a question in the database.
        /// </summary>
        /// <param name="userAnswer"></param>
        /// <param name="questionId"></param>
        public static void AnswerQuestion(string userAnswer, int questionId)
        {
            // validation to check if the user has entered an answer
            if (string.IsNullOrWhiteSpace(userAnswer))
            {
                MessageBox.Show(
                    "Please enter an answer before saving.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Check if the question has an answer already
            bool answerExists = AnswerExists(questionId);

            // If question already has an answer, update it
            string sql;
            if (answerExists)
            {
                sql = @"
                        UPDATE Answers
                        SET answer = @answer
                        WHERE userId     = @userId
                         AND questionId = @questionId;
                ";
            }
            // If question does not have an answer, insert a new one
            else
            {
                sql = @"
                        INSERT INTO Answers (userId, questionId, answer)
                        VALUES (@userId, @questionId, @answer);
                ";
            }

            var parms = new Dictionary<string, object>
            {
                ["@userId"] = Program.userId,
                ["@questionId"] = questionId,
                ["@answer"] = userAnswer
            };

            // Execute against the database
            using (var db = new DatabaseManagement($"Data Source={Program.dbPath}"))
            {
                try
                {
                    int rowsAffected = db.ExecuteNonQuery(sql, parms);

                    // Check if the operation was successful
                    if (rowsAffected == 1)
                    {
                        // If it was an insert, Add the questionId to the answerList
                        if (!answerExists)
                            Program.AnswerRecords.Add(questionId);

                        // Show success message
                        MessageBox.Show(
                            "Your answer was saved successfully!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    else // The answer wans't added tot he database
                    {
                        MessageBox.Show(
                            "The answer couldn't be added to the database",
                            "Operation Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    }
                }
                catch (Exception ex) // handle any other errors
                {
                    MessageBox.Show(
                        $"Error saving answer: {ex.Message}",
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }


        /// <summary>
        /// Function to check if an answer exists for a given questionId and userId.
        /// </summary>
        /// <param name="questionId"></param>
        /// <returns></returns>
        public static bool AnswerExists(int questionId)
        {
            // Check if the answer exists for the given questionId and userId
            return Program.AnswerRecords.Contains(questionId);
        }

        /// <summary>
        /// Function to retrieve an answer for a given questionId and userId.
        /// </summary>
        /// <param name="questionId"></param>
        /// <returns></returns>
        public static string GetAnswer(int questionId)
        {
            string answerText = "";

            
            using (DatabaseManagement db = new DatabaseManagement($"Data Source={Program.dbPath}"))
            {
                try
                {
                    db.OpenConnection();

                    
                    object result = db.ExecuteScalar($"SELECT answer FROM Answers WHERE questionId = {questionId} AND userId = {Program.userId}");

                    // Check if the result is not null
                    if (result != null && result != DBNull.Value)
                    {
                        // Convert the result to a string
                        answerText = Convert.ToString(result);
                    }
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show($"Error retrieving Answer\nQuestionId: {questionId}\n\n" + ex.Message);
                }
                finally
                {
                    db.CloseConnection();
                }
            }
            // Return the answer text
            return answerText;
        }

        /// <summary>
        /// Function to delete all answers for a given userId.
        /// Users can't delete individual answers, but they can delete all of them.
        /// </summary>
        public static void DeleteAnswer()
        {
            // Query to delete all answrs for the logged in user
            string sql = "DELETE FROM Answers WHERE userId = @userId";
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
                        Program.RefreshLists();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting answers: " + ex.Message);
                }
                finally
                {
                    db.CloseConnection();
                }
            }

        }
        /// <summary>
        /// Function to delete a specific answer for a given questionId and userId.
        /// This function should be called when the user previously answered a question, but upon editing they left a blank answer
        /// </summary>
        /// <param name="questionId"></param>
        public static void DeleteAnswer(int questionId)
        {
            using (DatabaseManagement db = new DatabaseManagement($"Data Source={Program.dbPath}"))
            {
                try
                {
                    db.OpenConnection();
                    // Delete the answer from the database
                    string sql = $"DELETE FROM Answers WHERE questionId = {questionId} AND userId = {Program.userId}";
                    int rowsAffected = db.ExecuteNonQuery(sql);
                    // Check if the deletion was successful
                    if (rowsAffected > 0)
                    {
                        // Remove the questionId from the in-memory list
                        Program.AnswerRecords.Remove(questionId);
                        
                    }                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting answer: " + ex.Message);
                    return;                    
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }   
    }

    


}
