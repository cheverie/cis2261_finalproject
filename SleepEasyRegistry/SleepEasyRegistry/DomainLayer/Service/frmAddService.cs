using System;
using System.Windows.Forms;
using System.Linq;
using MySql.Data.MySqlClient;

namespace SleepEasyRegistry.DomainLayer
{
    public partial class frmAddService : Form
    {
        private string connectionString = "server=localhost;database=sleepeasyregistry;uid=root;pwd=\"\";";
        
        public frmAddService()
        {
            InitializeComponent();
        }

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

        private void btnAdd_Click(object sender, EventArgs e)
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
            
            if (!rbTrue.Checked && !rbFalse.Checked)
            {
                MessageBox.Show("Please select an availability.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get other form details
            string name = txtName.Text;
            string type = txtType.Text;
            string description = txtDescription.Text;
            int availability = 1;
            if (rbFalse.Checked)
            {
                availability = 0;
            }
            else 
            {
                availability = 1;
            }
            
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
            
            // Create SQL query to insert the new record into the registration table
            string query = @"
                INSERT INTO service 
                (name, price, type, availability, description) 
                VALUES 
                (@Name, @Price, @Type, @Availability, @Description);
            ";

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

                try
                {
                    conn.Open(); // Open the MySQL connection
                    cmd.ExecuteNonQuery(); // Execute the insert command
                    MessageBox.Show("Adding Service was successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmService serviceForm = Application.OpenForms.OfType<frmService>().FirstOrDefault();
                    if (serviceForm != null)
                    {
                        serviceForm.LoadServiceData();
                    }
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