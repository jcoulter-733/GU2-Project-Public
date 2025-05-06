// Name: John Coulter
//Class: HND Software Development: Graded Unit 2
//Project description: Job Interviewing and Tracking Application
//Date: 04/05/2025
//DatabaseManagement.cs
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace GU2.Classes
{
    /// <summary>
    /// DatabaseManagement class provides methods to interact with a SQLite database.
    /// The connection string is stored in Program.cs and passed to this class.
    /// </summary>
    internal class DatabaseManagement : IDisposable
    {
        private SQLiteConnection _connection;
        private bool _disposed;

        /// <summary>
        /// Constructor that initializes the SQLite connection with the provided connection string.
        /// </summary>
        /// <param name="connectionString"></param>
        public DatabaseManagement(string connectionString)
        {
            _connection = new SQLiteConnection(connectionString);
        }

        /// <summary>
        /// Opens the SQLite connection if it's not already open.
        /// </summary>
        public void OpenConnection()
        {
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
        }

        /// <summary>
        /// Closes the SQLite connection if it's not already closed.
        /// </summary>
        public void CloseConnection()
        {
            if (_connection.State != ConnectionState.Closed)
            {
                _connection.Close();
            }
        }

        /// <summary>
        /// Executes a query that returns results (e.g., SELECT) and returns a DataTable.
        /// </summary>
        public DataTable ExecuteQuery(string query, Dictionary<string, object> parameters = null)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnection();
                using (var command = new SQLiteCommand(query, _connection))
                {
                    if (parameters != null)
                    {
                        foreach (var kv in parameters)
                            command.Parameters.AddWithValue(kv.Key, kv.Value);
                    }
                    using (var adapter = new SQLiteDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Error executing query: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return dt;
        }

        /// <summary>
        /// Executes a command that does not return any data (e.g., INSERT, UPDATE, DELETE)
        /// </summary>
        public int ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
        {
            int affectedRows = 0;
            try
            {
                OpenConnection();
                using (var command = new SQLiteCommand(query, _connection))
                {
                    if (parameters != null)
                    {
                        foreach (var kv in parameters)
                            command.Parameters.AddWithValue(kv.Key, kv.Value);
                    }
                    affectedRows = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {               
                Console.WriteLine("Error executing non-query: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return affectedRows;
        }

        /// <summary>
        /// Executes a query that returns a single value (e.g., SELECT COUNT(*) ...).
        /// </summary>
        public object ExecuteScalar(string query, Dictionary<string, object> parameters = null)
        {
            object result = null;
            try
            {
                OpenConnection();
                using (var command = new SQLiteCommand(query, _connection))
                {
                    if (parameters != null)
                    {
                        foreach (var kv in parameters)
                            command.Parameters.AddWithValue(kv.Key, kv.Value);
                    }
                    result = command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error executing scalar: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return result;
        }

        /// <summary>
        /// Disposes of the SQLite connection and releases resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Disposes of the SQLite connection and releases resources.
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_connection != null)
                    {
                        _connection.Dispose();
                        _connection = null;
                    }
                }
                _disposed = true;
            }
        }
    }
}
