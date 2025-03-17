using System.Windows.Forms;
using SleepEasyRegistry.DomainLayer;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SleepEasyRegistry.DomainLayer
{
    public partial class frmService : Form
    {
        // public string gCurrentEmpId;
        public int gAccessLevel;
        public string gFullName;

        // Database connection string
        private readonly string connectionString = "server=localhost;database=sleepeasyregistry;uid=root;pwd=\"\";";
        
        public frmService()
        {
            InitializeComponent();
        }
        
        private void frmViewService_Load(object sender, EventArgs e)
        {
            LoadServiceData();
        }

        /// <summary>
        /// Loads service data from the database and populates the DataGridView.
        /// </summary>
        public void LoadServiceData()
        {
            dataGridService.Rows.Clear();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "select *\nfrom service;";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        dataGridService.Rows.Clear();

                        while (reader.Read())
                        {
                            // Add the rows to the DataGridView
                            dataGridService.Rows.Add(
                                reader["serviceId"], reader["name"], reader["price"], reader["type"],
                                reader["availability"], reader["description"]
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading service data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// Sets the current user information and adjusts UI visibility based on access level.
        public void SetCurrentUser(string fullName, int accessLevel)
        {
            txtCurrentUser.Text = $"Welcome, {fullName}";
            gAccessLevel = accessLevel;
            gFullName = fullName;
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        
        /// <summary>
        /// Refreshes Registration Datagrid data
        /// </summary>
        public void RefreshData()
        {
            LoadServiceData();  // This will reload the data in the DataGridView.
        } 
        
        /// <summary>
        /// Handles deletion of a selected service record from the database.
        /// </summary>
        private void dataGridService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridService.Columns["btnDeleteService"].Index)
                {
                    int serviceId = Convert.ToInt32(dataGridService.Rows[e.RowIndex].Cells["colServiceId"].Value);

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            using (MySqlConnection conn = new MySqlConnection(connectionString))
                            {
                                conn.Open();
                                string query = "DELETE FROM service WHERE serviceId = @serviceId";

                                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                                {
                                    cmd.Parameters.AddWithValue("@serviceId", serviceId);
                                    int rowsAffected = cmd.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        dataGridService.Rows.RemoveAt(e.RowIndex);
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
                else if (e.ColumnIndex == dataGridService.Columns["btnEditService"].Index)
                {
                    int serviceId = Convert.ToInt32(dataGridService.Rows[e.RowIndex].Cells["colServiceId"].Value);

                    // Pass the frmMain reference to the frmEditReg constructor
                    frmEditService editForm = new frmEditService(serviceId, this);  // Pass 'this' to refer to the current frmMain instance
                    editForm.ShowDialog(); // Use ShowDialog() for modal behavior
                }
            }
        }
        
        
    }
}