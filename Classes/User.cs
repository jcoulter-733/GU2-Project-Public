// Name: John Coulter
//Class: HND Software Development: Graded Unit 2
//Project description: Job Interviewing and Tracking Application
//Date: 04/05/2025
//User.cs
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using GU2.Classes;
using GU2.Forms;
using System.Windows.Forms;
using System.Security.Policy;

namespace GU2.Classes
{
    /// <summary>
    /// User class represents a user in the application.
    /// </summary>
    internal class User
    {
        // Properties to store user information
        private int userId { get; set; }
        private string username { get; set; }
        private string password { get; set; }

        /// <summary>
        /// Constructor to initialize a User object.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="userId"></param>
        public User(string username, string password, int userId)
        {
            // Initialize properties
            this.userId = userId;
            this.username = username;
            this.password = password;            
        }
        /// <summary>
        /// Retrieves the maximum userId from the database.
        /// </summary>
        /// <returns></returns>
        private static int GetUserID()
        {
            int maxId = 0;

            // Using 'using' ensures the db is disposed of properly.
            using (DatabaseManagement db = new DatabaseManagement($"Data Source={Program.dbPath}"))
            {
                try
                {
                    db.OpenConnection();

                    // Use ExecuteScalar to get the maximum userId.
                    object result = db.ExecuteScalar("SELECT MAX(UserId) FROM Users");

                    // If result is not null convert it to int.
                    if (result != null && result != DBNull.Value)
                    {
                        maxId = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex) // Handle errors and display the error message.
                {                    
                    Console.WriteLine("Error retrieving max userId: " + ex.Message);
                }
                finally
                {
                    db.CloseConnection();
                }
            }
            
            return maxId;
        }

        /// <summary>
        /// Creates a new user and adds to the database.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static (bool,string) CreateUser(string username, string password, int userId)
        {
            // I need to Insert a userId manually, so I need to get the max userId from the database and increment it by 1.
            // This is because all the questions (system questions) I added to the database have a userId of 0.
            // This prevents any user from being assigned a userId of 0.
            int maxID = GetUserID();
            maxID++;

            // Gets the password hash and salt for the entered password.
            var (hash, salt) = CreatePasswordHash(password);

            // Create a new User object with the provided username, password, and userId.
            User newUser = new User(username, password, maxID);

            DatabaseManagement db = new DatabaseManagement($"Data Source={Program.dbPath}");

            // Query to check if the username already exists.
            string checkQuery = $"SELECT COUNT(*) FROM Users WHERE Username = '{newUser.username}'";
            object result = db.ExecuteScalar(checkQuery);
            int count = 0;

            if (result != null && int.TryParse(result.ToString(), out count))
            {
                if (count > 0)
                {
                    // The username already exists in the database.
                    return (false,  $"Error: Username {newUser.username} already exists");
                }
            }

            // Query to insert the new user into the database.
            string insertQuery = $"INSERT INTO Users (UserID, Username, PasswordHash, PasswordSalt) VALUES ({newUser.userId}, '{newUser.username}', '{hash}', '{salt}')";
            int rowsAffected = db.ExecuteNonQuery(insertQuery);
            if (rowsAffected > 0)
            {
                // User record inserted successfully.
                return (true, $"Message: User {newUser.username} created successfully, please login");
            }
            else
            {
                // An error occurred while inserting the record.
                return (false, "Error: Unable to create user");
            }
        }

        /// <summary>
        /// This method is used to log in a user. and returs the reult of the login attempt.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool LoginUser(string username, string password)
        {
            using (DatabaseManagement db = new DatabaseManagement($"Data Source={Program.dbPath}"))
            {
                try
                {
                    db.OpenConnection();

                    // Retrieve stored password hash and salt for the given username.
                    string query = $"SELECT PasswordHash, PasswordSalt, UserId FROM Users WHERE Username = '{username}'";
                    DataTable dt = db.ExecuteQuery(query);

                    // Check if a user record with the provided username exists.
                    if (dt.Rows.Count == 0)
                    {
                        return false;
                    }

                    // Extract the stored hash and salt from the result.
                    string storedHash = dt.Rows[0]["PasswordHash"].ToString();
                    string storedSalt = dt.Rows[0]["PasswordSalt"].ToString();

                    // Verify the provided password against the stored hash and salt.
                    bool isValid = VerifyPassword(password, storedHash, storedSalt);
                    if (isValid)
                    {
                        // If login is successful, set the userId in the Program class.
                        Program.userId = Convert.ToInt32(dt.Rows[0]["UserId"]);
                        Program.username = username;
                        // todo Load Lists for User Data at this point
                        // Job Info, QuestionInfo
                    }
                    else
                    {
                        // If login fails, reset the userId and username.
                        Program.userId = 0;
                        Program.username = "";

                    }
                    // Return result of the login attempt.
                    return isValid ? true : false;
                }
                catch (Exception ex) // return false if an error occurs. and reset the userId and username.
                {
                    
                    MessageBox.Show("Error: " + ex.Message);
                    Program.userId = 0;
                    Program.username = "";
                                     
                    return false;
                }
                finally
                {
                    
                    db.CloseConnection();
                }
            }
        }

        /// <summary>
        /// Function to log out the user, and clear the in memory data lists
        /// </summary>
        public static void LogoutUser()
        {
            // Clear the user data
            Program.username = "";
            Program.userId = 0;

            // Clear Lists
            Program.ClearLists();
            
        }

        /// <summary>
        /// Function to delete the current user from the database.
        /// </summary>
        public static void DeleteUser()
        {
            // Delete the user from the database
            DatabaseManagement db = new DatabaseManagement($"Data Source={Program.dbPath}");
            string deleteQuery = $"DELETE FROM Users WHERE UserId = {Program.userId}";
            int rowsAffected = db.ExecuteNonQuery(deleteQuery);
            if (rowsAffected > 0)
            {
                User.DeleteAllData(); // Delete all data related to the user
                
                LogoutUser(); // Log out the user
            }
            else
            {
                // An error occurred while deleting the record.
                MessageBox.Show("Error: Unable to delete user");
            }
        }
        /// <summary>
        /// Function called to delete all data related to the user from the database.
        /// </summary>
        public static void DeleteAllData()
        {
            Answer.DeleteAnswer();
            Question.DeleteQuestion();
            Job.DeleteJob();
            Question.RestoreSystemQuestions();
        }

        /// <summary>
        /// Function to update the password for the current user.
        /// </summary>
        /// <param name="currentPassword"></param>
        /// <param name="newPassword"></param>
        public static void UpdatePassword(string currentPassword, string newPassword)
        {
            using (DatabaseManagement db = new DatabaseManagement($"Data Source={Program.dbPath}"))
            {
                try
                {
                    db.OpenConnection();

                    // Retrieve stored password hash and salt for the given username.
                    string query = $"SELECT PasswordHash, PasswordSalt, UserId FROM Users WHERE UserId = '{Program.userId}'";
                    DataTable dt = db.ExecuteQuery(query);

                    // Extract the stored hash and salt from the result.
                    string storedHash = dt.Rows[0]["PasswordHash"].ToString();
                    string storedSalt = dt.Rows[0]["PasswordSalt"].ToString();

                    // Verify the old password is correct , against the stored hash and salt.
                    bool isValid = VerifyPassword(currentPassword, storedHash, storedSalt);

                    if (isValid) // the old password matched
                    {
                        var (newHash, newSalt) = CreatePasswordHash(newPassword); // Create a new hash and salt for the new password.

                        // Update the password hash and salt in the database.
                        string updateQuery = $"UPDATE Users SET PasswordHash = '{newHash}', PasswordSalt = '{newSalt}' WHERE UserId = {Program.userId}";
                        int rowsAffected = db.ExecuteNonQuery(updateQuery);
                        if (rowsAffected > 0)
                        {
                            // Password updated successfully.
                            MessageBox.Show("Password updated successfully.");
                        }
                        

                    }
                    else
                    {
                        // An error occurred while updating the password.
                        MessageBox.Show("Error: Unable to update password");
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions and display the error message.
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }

        /// <summary>
        /// Function to generate a new password hash and salt from a given password.
        /// </summary>
        /// <param name="password"></param>
        /// <param name="saltSize"></param>
        /// <param name="iterations"></param>
        /// <returns></returns>
        public static (string Hash, string Salt) CreatePasswordHash(string password, int saltSize = 16, int iterations = 100000)
        {
            byte[] saltBytes = new byte[saltSize];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, iterations, HashAlgorithmName.SHA256))
            {
                byte[] hashBytes = pbkdf2.GetBytes(32); // 256-bit hash
                string hashBase64 = Convert.ToBase64String(hashBytes);
                string saltBase64 = Convert.ToBase64String(saltBytes);
                return (hashBase64, saltBase64);
            }
        }


        /// <summary>
        /// Function to verify a password against a stored hash and salt.
        /// </summary>
        /// <param name="password"></param>
        /// <param name="storedHash"></param>
        /// <param name="storedSalt"></param>
        /// <param name="iterations"></param>
        /// <returns></returns>
        public static bool VerifyPassword(string password, string storedHash, string storedSalt, int iterations = 100000)
        {
            // Convert the stored salt back to bytes.
            byte[] saltBytes = Convert.FromBase64String(storedSalt);

            // Re-compute the hash with the provided password and stored salt.
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, iterations, HashAlgorithmName.SHA256))
            {
                byte[] hashBytes = pbkdf2.GetBytes(32);
                string computedHash = Convert.ToBase64String(hashBytes);

                // Compare the computed hash to the stored hash.
                if (computedHash == storedHash)
                {
                    return true; // Password is valid.
                }
                else
                {                   
                    return false; // Password is invalid.
                }
            }
        }
    }
    
}
