using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Linq;

namespace SleepEasyRegistry.DomainLayer
{
    public partial class frmEditService : Form
    {
        private string connectionString = "server=localhost;database=sleepeasyregistry;uid=root;pwd=\"\";";
        private int serviceId;
        private frmService _serviceForm;

        public frmEditService(int serviceId, frmService serviceForm)
        {
            InitializeComponent();
            _serviceForm = serviceForm; // Store the reference to service form
            this.serviceId = serviceId;
            // LoadServiceDetails();
        }

        private void frmEditService_Load(object sender, EventArgs e)
        {
            LoadServiceDetails();

        }

        private void LoadServiceDetails()
        {
            string query = "SELECT * FROM service WHERE serviceId = @serviceId";
            
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@serviceId", serviceId);

                try
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Set the registration ID
                            txtServiceId.Text = serviceId.ToString();

                            txtName.Text = reader["name"].ToString();
                            txtPrice.Text = reader["price"].ToString();
                            txtDescription.Text = reader["description"].ToString();
                            txtType.Text = reader["type"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading service details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Cancel button handler
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

        private void btnConfirmEdit_Click(object sender, EventArgs e)
        {
            // Check if the service name is empty
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the type is empty
            if (string.IsNullOrWhiteSpace(txtType.Text))
            {
                MessageBox.Show("Type is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the price is empty or invalid
            if (string.IsNullOrWhiteSpace(txtPrice.Text) || !txtPrice.Text.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the description is empty or invalid
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please enter a valid description.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get form details
            string name = txtName.Text;
            string type = txtType.Text;
            string description = txtDescription.Text;
            int availability = 1;
            
            string priceText = txtPrice.Text;

            // Remove any non-numeric characters
            priceText = priceText.Replace("$", "").Trim();

            // Try to parse the remaining text as a double
            double price;
            if (!double.TryParse(priceText, out price))
            {
                MessageBox.Show("Please enter a valid price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create SQL query to update the record in the service table
            string query = @"
                UPDATE service 
                SET name = @Name,
                    price = @Price,
                    type = @Type,
                    availability = @Availability,
                    description = @Description
                WHERE serviceId = @ServiceId; ";

             // Create MySQL connection and command
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Add parameters to the SQL command
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Type", type);
                cmd.Parameters.AddWithValue("@Availability", availability);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@ServiceId", serviceId); 
            
                try
                {
                    // Open the MySQL connection
                    conn.Open(); 
                    // Execute the update command
                    cmd.ExecuteNonQuery(); 
                    MessageBox.Show("Service updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                    frmService serviceForm = Application.OpenForms.OfType<frmService>().FirstOrDefault();
                    if (serviceForm != null)
                    {
                        serviceForm.LoadServiceData();
                    }
                    _serviceForm.RefreshData();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}