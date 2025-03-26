using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using SleepEasyRegistry.BusinessObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * Code to grant functionality to the Add Staff form
 * 
 * Author: Jensen MacMillan
 * Date: 03-22-2025
 */

namespace SleepEasyRegistry.DomainLayer
{
    public partial class frmAddStaff : Form
    {
        //String to connect to SQL database
        private string connectionString = "server=localhost;database=sleepeasyregistry;uid=root;pwd=\"\";";

        public frmAddStaff()
        {
            InitializeComponent();
        }


        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            /* Verify that fields are filled */
            if (string.IsNullOrWhiteSpace(txtFName.Text))
            {
                MessageBox.Show("First Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLName.Text))
            {
                MessageBox.Show("Last Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Title is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            /* Assign data to attributes */
            string fName = txtFName.Text;
            string lName = txtLName.Text;
            string title = txtTitle.Text;
            string empPass = txtEmpPass.Text;
            empPass = BCrypt.Net.BCrypt.EnhancedHashPassword(empPass);
            int retrievedId = 0;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    // Create SQL query to insert the record into the staff table
                    string query = @"INSERT INTO staff (lastName, firstName, title) VALUES (@LastName, @FirstName, @Title);";
                    // Create SQL query to gather empId
                    string idQuery = @"SELECT LAST_INSERT_ID();";
                    // Create SQL query to insert the record into the staffauth table
                    //string authQuery = @"INSERT INTO staffauth (empPass) VALUES (@EmpPass) WHERE empId = @retrievedEmpId;";
                    string authQuery = @"INSERT INTO staffauth(empId, empPass) VALUES(@EmpId, @EmpPass);";

                    conn.Open();// Open the MySQL connection

                    bool staffSuccess = false;
                    bool staffAuthSuccess = false;

                    // Run query against staff table
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add parameters to the SQL command
                        cmd.Parameters.AddWithValue("@FirstName", fName);
                        cmd.Parameters.AddWithValue("@LastName", lName);
                        cmd.Parameters.AddWithValue("@Title", title);
                        try
                        {
                            cmd.ExecuteNonQuery(); // Execute the update command
                            staffSuccess = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }

                    // Run query to get empId
                    using (MySqlCommand cmd = new MySqlCommand(idQuery, conn))
                    {
                        try
                        {
                            retrievedId = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }

                    // Run query against staffauth table
                    using (MySqlCommand cmd = new MySqlCommand(authQuery, conn))
                    {
                        // Add parameters to the SQL command
                        cmd.Parameters.AddWithValue("@EmpPass", empPass);
                        cmd.Parameters.AddWithValue("@EmpId", retrievedId);
                        try
                        {
                            cmd.ExecuteNonQuery(); // Execute the update command
                            staffAuthSuccess = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }

                    //Provide user with popup showing status
                    if (staffSuccess && staffAuthSuccess)
                    {
                        MessageBox.Show("Staff member and password inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        frmStaff staffForm = Application.OpenForms.OfType<frmStaff>().FirstOrDefault();
                        if (staffForm != null)
                        {
                            staffForm.LoadStaffData();
                        }
                        this.Close();
                    }
                    else if (staffSuccess && !staffAuthSuccess)
                    {
                        MessageBox.Show("Staff member inserted successfully. Password was not able to be inserted", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (!staffSuccess && staffAuthSuccess)
                    {
                        MessageBox.Show("Password inserted successfully. Staff member was not able to be inserted", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("All records failed to insert.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to DB: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Code done by Nick for frmAddReg
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Prompt the user with a confirmation message
            DialogResult result = MessageBox.Show(
                "You will lose any unsaved changes.",
                "Cancel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            // If the user confirms (clicks Yes), proceed with closing the form
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
