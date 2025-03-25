using MySql.Data.MySqlClient;
using Org.BouncyCastle.Ocsp;
using SleepEasyRegistry.DomainLayer;
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
    public partial class frmMain : Form
    {
        // Stores the currently logged-in employee's ID
        public string currentEmpId;

        // Database connection string
        private readonly string connectionString = "server=localhost;database=sleepeasyregistry;uid=root;pwd=\"\";";

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadRegistrationData(); // Load data when the form loads
        }

        /// Sets the current user information and adjusts UI visibility based on access level.
        public void SetCurrentUser(string fullName, int accessLevel)
        {
            txtCurrentUser.Text = $"{fullName}";

            // Hide management menu for users without admin privileges
            if (accessLevel != 2)
            {
                tStripManagement.Visible = false;
            }
        }

        /// Handles logout functionality, confirming with the user before closing forms.
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out? You will lose any unsaved changes.",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Close all forms except the login form
                List<Form> formsToClose = new List<Form>();
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm.Name != "frmLogin")
                    {
                        formsToClose.Add(openForm);
                    }
                }

                foreach (Form form in formsToClose)
                {
                    form.Close();
                }

                // Reopen the login form
                frmLogin loginForm = new frmLogin();
                loginForm.Show();
            }
        }

        /// <summary>
        /// Loads registration data from the database and populates the DataGridView.
        /// </summary>
        public void LoadRegistrationData()
        {
            dataGridReg.Rows.Clear();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT regId, roomNum, empId, roomRate, lastName, firstName, address, payMethod, " +
                                   "currentStatus, checkInDate, checkOutDate, stayDuration, costOfStay, email, phoneNumber " +
                                   "FROM registration;";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        dataGridReg.Rows.Clear();

                        while (reader.Read())
                        {
                            // Retrieve the DateTime values and remove the time part using .Date
                            DateTime checkInDate = Convert.ToDateTime(reader["checkInDate"]).Date;
                            DateTime checkOutDate = Convert.ToDateTime(reader["checkOutDate"]).Date;

                            // Add the rows to the DataGridView
                            dataGridReg.Rows.Add(
                                reader["regId"], reader["roomNum"], reader["empId"], reader["roomRate"],
                                reader["lastName"], reader["firstName"], reader["address"], reader["payMethod"],
                                reader["currentStatus"], checkInDate.ToShortDateString(), checkOutDate.ToShortDateString(),
                                reader["stayDuration"], reader["costOfStay"], reader["email"], reader["phoneNumber"]
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading registration data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Handles deletion of a selected registration record from the database.
        /// </summary>
        private void dataGridReg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridReg.Columns["btnDeleteReg"].Index)
                {
                    int regId = Convert.ToInt32(dataGridReg.Rows[e.RowIndex].Cells["colRegId"].Value);

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            using (MySqlConnection conn = new MySqlConnection(connectionString))
                            {
                                conn.Open();
                                string query = "DELETE FROM registration WHERE regId = @regId";

                                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                                {
                                    cmd.Parameters.AddWithValue("@regId", regId);
                                    int rowsAffected = cmd.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        dataGridReg.Rows.RemoveAt(e.RowIndex);
                                        MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Record not found. It may have already been deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error deleting record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (e.ColumnIndex == dataGridReg.Columns["btnEditReg"].Index)
                {
                    int regId = Convert.ToInt32(dataGridReg.Rows[e.RowIndex].Cells["colRegId"].Value);

                    // Pass the frmMain reference to the frmEditReg constructor
                    frmEditReg editForm = new frmEditReg(regId, this);  // Pass 'this' to refer to the current frmMain instance
                    editForm.ShowDialog(); // Use ShowDialog() for modal behavior
                }
            }
        }

        /// <summary>
        /// Refreshes Registration Datagrid data
        /// </summary>
        public void RefreshData()
        {
            LoadRegistrationData();  // This will reload the data in the DataGridView.
        }

        /// <summary>
        /// Opens the form to add a new registration entry.
        /// </summary>
        private void btnAddReg_Click(object sender, EventArgs e)
        {
            frmAddRegistration regForm = new frmAddRegistration();
            regForm.Show();
        }
        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAvailabilityReport frmAvailability = new frmAvailabilityReport(txtCurrentUser.Text);
            frmAvailability.Show();
        }
    }
}