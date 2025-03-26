using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * Code to grant functionality to the Edit Staff form
 * 
 * Author: Jensen MacMillan
 * Date: 03-25-2025
 */


namespace SleepEasyRegistry.DomainLayer
{
    public partial class frmEditStaff : Form
    {
        //String for DB connection
        private string connectionString = "server=localhost;database=sleepeasyregistry;uid=root;pwd=\"\";";

        private int empId;
        private frmStaff _staffForm;

        public frmEditStaff(int empId, frmStaff staffForm)
        {
            InitializeComponent();
            _staffForm = staffForm; // Store the reference to the staff form
            this.empId = empId;
            LoadStaffDetails();
        }

        private void LoadStaffDetails()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    //Open connection
                    conn.Open();

                    string query = "SELECT * FROM staff WHERE empId = @EmpId";
                    string authQuery = "SELECT * FROM staffauth WHERE empId = @EmpId";

                    //Run query against staff table
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        //Bind EmpId parameter
                        cmd.Parameters.AddWithValue("@EmpId", empId);
                        try
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Set the registration ID
                                    txtEmpId.Text = empId.ToString();

                                    // Set fields
                                    txtLName.Text = reader["lastName"].ToString();
                                    txtFName.Text = reader["firstName"].ToString();
                                    txtTitle.Text = reader["title"].ToString();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error loading staff members details from staff: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to DB: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Button Functions

        //Code from Nick edited to fit staff functionality
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "You will lose any unsaved changes.",
                "Cancel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //Code from Nick edited to fit staff functionality
        private void btnConfirmEdit_Click(object sender, EventArgs e)
        {
            // Check if the last name is empty
            if (string.IsNullOrWhiteSpace(txtLName.Text))
            {
                MessageBox.Show("Last Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the first name is empty
            if (string.IsNullOrWhiteSpace(txtFName.Text))
            {
                MessageBox.Show("First Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the title is empty
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Title is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get form details
            string lName = txtLName.Text;
            string fName = txtFName.Text;
            string title = txtTitle.Text;
            string empPass = txtEmpPass.Text;
            empPass = BCrypt.Net.BCrypt.EnhancedHashPassword(empPass);
            
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    // Create SQL query to update the record in the staff table
                    string query = @"UPDATE staff SET lastName = @LastName, firstName = @FirstName, title = @Title WHERE empId = @EmpId;";
                    // Create SQL query to update the record in the staffauth table
                    string authQuery = @"UPDATE staffauth SET empPass = @EmpPass WHERE empId = @EmpId;";

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
                        cmd.Parameters.AddWithValue("@EmpId", empId);
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

                    // Run query against staffauth table
                    using (MySqlCommand cmd = new MySqlCommand(authQuery, conn))
                    {
                        // Add parameters to the SQL command
                        cmd.Parameters.AddWithValue("@EmpPass", empPass);
                        cmd.Parameters.AddWithValue("@EmpId", empId);
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
                        MessageBox.Show("Staff member and password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Close edit form and refresh data
                        frmStaff staffForm = Application.OpenForms.OfType<frmStaff>().FirstOrDefault();
                        if (staffForm != null)
                        {
                            staffForm.LoadStaffData();
                        }
                        _staffForm.LoadStaffData();
                        this.Close();
                    } 
                    else if (staffSuccess && !staffAuthSuccess)
                    {
                        MessageBox.Show("Staff member updated successfully. Password was not able to be updated", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (!staffSuccess && staffAuthSuccess)
                    {
                        MessageBox.Show("Password updated successfully. Staff member was not able to be updated", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } 
                    else
                    {
                        MessageBox.Show("All records failed to update.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to DB: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
