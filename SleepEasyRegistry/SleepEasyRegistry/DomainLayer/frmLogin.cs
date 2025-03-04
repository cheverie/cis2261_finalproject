using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SleepEasyRegistry
{
    public partial class frmLogin : Form
    {
        // Static variable to store the current logged-in Employee ID globally
        public static int CurrentEmpId { get; set; }

        public frmLogin()
        {
            InitializeComponent(); // Initializes the login form components
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // Event handler for form load (can be used for initialization if needed)
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Database connection string (ensure credentials are correct)
            string connectionString = "server=localhost;database=sleepeasyregistry;uid=root;pwd=\"\";";

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                try
                {
                    cnn.Open(); // Open connection to the database

                    // Retrieve user input from text fields
                    string empId = txtEmpId.Text.Trim();
                    string empPass = txtPassword.Text.Trim();

                    // Check if fields are empty and notify the user
                    if (string.IsNullOrEmpty(empId) || string.IsNullOrEmpty(empPass))
                    {
                        MessageBox.Show("Please fill out both Employee ID and Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit method to prevent further execution
                    }

                    // Query to verify employee credentials and get access level
                    string query = "SELECT accessLevel FROM staffauth WHERE empId = @EmpId AND empPass = @EmpPass;";
                    using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                    {
                        // Prevent SQL injection by using parameters
                        cmd.Parameters.AddWithValue("@EmpId", empId);
                        cmd.Parameters.AddWithValue("@EmpPass", empPass);

                        object result = cmd.ExecuteScalar(); // Execute query and get single value

                        if (result != null) // Check if credentials are valid
                        {
                            int accessLevel = Convert.ToInt32(result); // Retrieve access level

                            // Query to get the full name of the user
                            string nameQuery = "SELECT CONCAT(firstName, ' ', lastName) FROM staff WHERE empId = @EmpId;";
                            using (MySqlCommand nameCmd = new MySqlCommand(nameQuery, cnn))
                            {
                                nameCmd.Parameters.AddWithValue("@EmpId", empId);
                                string fullName = nameCmd.ExecuteScalar()?.ToString() ?? "Unknown User"; // Retrieve user's full name

                                // Store empId in the static variable for global access
                                CurrentEmpId = Convert.ToInt32(empId);

                                // Open the main form and pass user information
                                frmMain mainForm = new frmMain();
                                mainForm.SetCurrentUser(fullName, accessLevel); // Pass access level and name
                                mainForm.Show(); // Display the main form
                                this.Hide(); // Hide the login form after successful login
                            }
                        }
                        else
                        {
                            // Display error message for invalid credentials
                            MessageBox.Show("Invalid Employee ID or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtEmpId.Clear(); // Clear input fields
                            txtPassword.Clear();
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle and display any database connection or query errors
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
