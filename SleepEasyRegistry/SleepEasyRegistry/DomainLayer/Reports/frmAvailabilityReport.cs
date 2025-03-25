using MySql.Data.MySqlClient;
using SleepEasyRegistry.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SleepEasyRegistry.DomainLayer
{
    public partial class frmAvailabilityReport : Form
    {
        private string connectionString = "server=localhost;database=sleepeasyregistry;uid=root;pwd=\"\";";
        private List<Room> availableRooms = new List<Room>(); // List to store room information
        private string currentEmployee; // Store empId

        // Modified constructor to accept empId
        public frmAvailabilityReport(string currentEmp)
        {
            InitializeComponent();
            this.currentEmployee = currentEmp;  // Store the currentEmp in a class-level variable
        }

        private void frmAvailabilityReport_Load(object sender, EventArgs e)
        {
            // Set the MinDate of dtpCheckIn to the current date
            dtpCheckIn.MinDate = DateTime.Today;

            // Ensure that dtpCheckIn defaults to the current date
            dtpCheckIn.Value = DateTime.Today;
            txtDate.Text = DateTime.Today.ToShortDateString();

            // Ensure that the empId is passed and assigned to txtEmployee
            if (!string.IsNullOrEmpty(currentEmployee))
            {
                txtEmployee.Text = currentEmployee; // Populate the employee textbox with the empId
            }
            else
            {
                txtEmployee.Text = "Unknown"; // Handle if empId is null or empty
            }

            // Populate available rooms based on the selected dates
            PopulateAvailableRooms();
        }

        private void PopulateAvailableRooms()
        {
            // Clear any previous rows in the DataGridView
            dgvAvailability.Rows.Clear();

            // Get the selected dates from the DateTimePickers
            DateTime checkInDate = dtpCheckIn.Value.Date;
            DateTime checkOutDate = dtpCheckOut.Value.Date;

            // Query to fetch available rooms
            string query = @"
SELECT ri.roomNum, ri.roomDesc, ri.roomType, ri.roomRate
FROM roominventory ri
WHERE ri.roomNum NOT IN (
    SELECT r.roomNum
    FROM registration r
    WHERE (
        (r.checkInDate BETWEEN @CheckInDate AND @CheckOutDate) 
        OR 
        (r.checkOutDate BETWEEN @CheckInDate AND @CheckOutDate)
        OR 
        (r.checkInDate <= @CheckInDate AND r.checkOutDate >= @CheckOutDate)
    )
);
";

            // Create MySQL connection and command
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CheckInDate", checkInDate);
                cmd.Parameters.AddWithValue("@CheckOutDate", checkOutDate);

                try
                {
                    conn.Open(); // Open the MySQL connection

                    // Execute the query and populate the DataGridView
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        // Create a Room object with room details
                        Room room = new Room(
                            Convert.ToInt32(reader["roomNum"]),
                            reader["roomDesc"].ToString(),
                            reader["roomType"].ToString(),
                            Convert.ToDecimal(reader["roomRate"])
                        );

                        // Add the room data to the DataGridView
                        dgvAvailability.Rows.Add(room.RoomNum, room.RoomDesc, room.RoomType, room.RoomRate.ToString("C"));

                        // Store the room information in the list (optional if you need it later)
                        availableRooms.Add(room);
                    }

                    reader.Close(); // Close the reader
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dtpCheckIn_ValueChanged(object sender, EventArgs e)
        {
            PopulateAvailableRooms();
        }

        private void dtpCheckOut_ValueChanged(object sender, EventArgs e)
        {
            PopulateAvailableRooms();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the current date
                string currentDate = DateTime.Today.ToShortDateString();

                // Get the path to the Downloads folder
                string downloadsFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";

                // Create the file path for the report
                string filePath = System.IO.Path.Combine(downloadsFolder, "RoomAvailabilityReport.txt");

                // Create a StringBuilder to build the report content
                StringBuilder reportContent = new StringBuilder();

                // Add headers
                reportContent.AppendLine("SYSTEM NAME            DATE                Check-In Date    Check-Out Date");
                reportContent.AppendLine($"Sleep Easy Registry    {currentDate,-18} {dtpCheckIn.Value.ToShortDateString(),-15} {dtpCheckOut.Value.ToShortDateString(),-15}");
                reportContent.AppendLine();
                reportContent.AppendLine("Report Name                                       Report Purpose");
                reportContent.AppendLine("Room Availability Report                   Lists available Rooms For Specified Dates");
                reportContent.AppendLine();
                reportContent.AppendLine("Employee");
                reportContent.AppendLine(currentEmployee); // Employee ID or Name
                reportContent.AppendLine();
                reportContent.AppendLine("Room Availability:");

                // Add column headers for the available rooms, with proper alignment
                reportContent.AppendLine(string.Format("{0,-12} {1,-40} {2,-15} {3,10}", "Room Number", "Description", "Type", "Rate"));

                // Add the room data from DataGridView
                foreach (DataGridViewRow row in dgvAvailability.Rows)
                {
                    if (row.Cells[0].Value != null) // Skip empty rows
                    {
                        string roomNum = row.Cells[0].Value.ToString();
                        string roomDesc = row.Cells[1].Value.ToString();
                        string roomType = row.Cells[2].Value.ToString();
                        string roomRate = row.Cells[3].Value.ToString();

                        // Format the room data to align with the headers
                        reportContent.AppendLine(string.Format("{0,-12} {1,-40} {2,-15} {3,10}", roomNum, roomDesc, roomType, roomRate));
                    }
                }

                // Write the content to the file
                System.IO.File.WriteAllText(filePath, reportContent.ToString());

                // Inform the user that the report has been generated
                MessageBox.Show($"Report generated successfully: {filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle any errors
                MessageBox.Show("Error generating report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
