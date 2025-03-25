using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace SleepEasyRegistry.BusinessObjects
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }
        public bool Availability { get; set; }
        public string Description { get; set; }

        public Service(int serviceId, string name, decimal price, string type, bool availability, string description)
        {
            ServiceId = serviceId;
            Name = name;
            Price = price;
            Type = type;
            Availability = availability;
            Description = description;
        }

        public class ServiceManager
        {
            private string connectionString;
            private List<Service> availableServices = new List<Service>();  // List to hold available services

            public ServiceManager(string connectionString)
            {
                this.connectionString = connectionString;
            }

            public List<Service> PopulateAvailableServices(ComboBox cmbServices)
            {
                availableServices.Clear();  // Clear any existing services
                cmbServices.Items.Clear();

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "SELECT * FROM service WHERE availability = 1;";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Service service = new Service(
                                    Convert.ToInt32(reader["serviceId"]),
                                    reader["name"].ToString(),
                                    Convert.ToDecimal(reader["price"]),
                                    reader["type"].ToString(),
                                    Convert.ToBoolean(reader["availability"]),
                                    reader["description"].ToString()
                                );
                                availableServices.Add(service);  // Add to the availableServices list
                                cmbServices.Items.Add(service.Name);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading services: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return availableServices;  // Return the list of available services
            }
        }
    }
}
