/// John Coulter
/// Graded Unit 2 Project
/// Job Interviewing and Tracking Application
/// 04/05/2025
/// Login.cs
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
using GU2.Forms;

namespace GU2
{
    /// <summary>
    /// This form is the login screen for the application. It allows users to log in or create a new account.
    /// </summary>
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for the "Exit" button. This method closes the application when the button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Event handler for the form load event. This method initializes the form and sets default values for the username and password fields.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSplash_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        /// <summary>
        /// Event handler for the "Create Account" button. This method creates a new user account when the button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            // Checks if the username or password fields are empty
            if (CheckForm())
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();
                
                // Try to create a new user
                (bool loginStatus, string message) = User.CreateUser(username, password, 1);//1 = default userId, this is changed by User.CreateUser method

                // Change the label color based on the login status
                if (loginStatus)
                {
                    lblStatus.ForeColor = Color.Green;
                }
                else
                {
                    lblStatus.ForeColor = Color.Red;
                }
                // Display the message
                lblStatus.Text = message;
            }

        }
        /// <summary>
        /// Event handler for the "Login" button. This method logs in the user when the button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();
                string loginPass = "Message: Login successful, please wait while your data is loaded.";
                string loginFail = "Message: Login failed, please check your username and password.";

                // Try to login user
                bool login = User.LoginUser(username, password);

                // If login is successful, load the data from the database and log in user to dashboard form
                if (login)
                {
                    lblStatus.ForeColor = Color.Green;
                    lblStatus.Text = loginPass;

                    // wait for 1 seconds to load data and display success message
                    for (int i = 0; i < 5; i++)
                    {
                        lblStatus.Text += ".";
                        await Task.Delay(100);
                    }

                    // Load data from the database into Lists
                    Program.LoadLists();
                    

                    // open Dashboard form
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                // If login fails, display error message
                else
                {
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = loginFail;
                }
            }
        }

        /// <summary>
        /// Checks if the username and password fields are empty. If they are, it displays an error message.
        /// </summary>
        /// <returns></returns>
        private bool CheckForm()
        {
            // Checks if the username or password fields are empty
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ("ERROR: Please enter a username and password.");
                return false;
            }
            return true;
        }
    }
}
