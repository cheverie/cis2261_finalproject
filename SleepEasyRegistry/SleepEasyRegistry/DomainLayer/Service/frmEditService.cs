using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SleepEasyRegistry.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml.Linq;

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
                            txtAvailability.Text = reader["availability"].ToString();
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
    }
}