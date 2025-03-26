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

namespace SleepEasyRegistry.DomainLayer
{
    public partial class frmStaff : Form
    {
        //String to connect to SQL database
        private string connectionString = "server=localhost;database=sleepeasyregistry;uid=root;pwd=\"\";";

        // Stores the currently logged-in employee's ID
        public string currentEmpId;
        public string fullUserName;

        public frmStaff()
        {
            InitializeComponent();
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            LoadStaffData();
            txtCurrentUser.Text = fullUserName;
        }

        //Function to load staff data to datagrid
        public void LoadStaffData()
        {
            dataGridStaff.Rows.Clear();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT empId, lastName, firstName, title FROM staff;";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        dataGridStaff.Rows.Clear();

                        while (reader.Read())
                        {
                            // Add the rows to the DataGridView
                            dataGridStaff.Rows.Add(
                                reader["empId"], reader["lastName"], reader["firstName"], reader["title"]
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading staff data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        /// Handles deletion of a selected registration record from the database.
        private void dataGridStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridStaff.Columns["btnEditStaff"].Index)
                {
                    int regId = Convert.ToInt32(dataGridStaff.Rows[e.RowIndex].Cells["colEmpId"].Value);

                    // Pass the frmMain reference to the frmEditStaff constructor
                    frmEditStaff editForm = new frmEditStaff(regId, this);  // Pass 'this' to refer to the current frmStaff instance
                    editForm.ShowDialog(); // Use ShowDialog() for modal behavior
                }
            }
        }


        //Open new form to add staff
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            frmAddStaff frmAddStaff = new frmAddStaff();
            frmAddStaff.Show();
        }
    }
}
