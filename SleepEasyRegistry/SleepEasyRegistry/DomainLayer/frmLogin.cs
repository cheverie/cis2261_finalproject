using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;


namespace SleepEasyRegistry
{
    public partial class frmLogin : Form
    {
        public static int CurrentEmpId { get; set; }

        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=sleepeasyregistry;uid=root;pwd=\"\";";

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();

                    string empId = txtEmpId.Text.Trim();
                    string empPass = txtPassword.Text.Trim();

                    if (string.IsNullOrEmpty(empId) || string.IsNullOrEmpty(empPass))
                    {
                        MessageBox.Show("Please enter both Employee ID and Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Retrieve hashed password from the database for the given empId
                    string query = "SELECT empPass, accessLevel FROM staffauth WHERE empId = @EmpId;";
                    using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@EmpId", empId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedHashedPassword = reader["empPass"].ToString();
                                int accessLevel = Convert.ToInt32(reader["accessLevel"]);

                                // Compare entered password with stored hash
                                if (BCrypt.Net.BCrypt.EnhancedVerify(empPass, storedHashedPassword))
                                {
                                    // Retrieve full name from staff table
                                    reader.Close(); // Close the first reader before executing another query

                                    string nameQuery = "SELECT CONCAT(firstName, ' ', lastName) FROM staff WHERE empId = @EmpId;";
                                    using (MySqlCommand nameCmd = new MySqlCommand(nameQuery, cnn))
                                    {
                                        nameCmd.Parameters.AddWithValue("@EmpId", empId);
                                        string fullName = nameCmd.ExecuteScalar()?.ToString() ?? "Unknown User";

                                        // Store empId globally
                                        CurrentEmpId = Convert.ToInt32(empId);

                                        // Open the main form
                                        frmMain mainForm = new frmMain();
                                        mainForm.SetCurrentUser(fullName, accessLevel);
                                        mainForm.Show();
                                        this.Hide();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Invalid Employee ID or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtEmpId.Clear();
                                    txtPassword.Clear();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid Employee ID or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtEmpId.Clear();
                                txtPassword.Clear();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string password = "secure789";
            string passwordHash = BCrypt.Net.BCrypt.EnhancedHashPassword(password, 13 );
            txtEmpId.Text = passwordHash;
        }
    }
}