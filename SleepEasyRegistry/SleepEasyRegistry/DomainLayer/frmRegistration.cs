using MySql.Data.MySqlClient;
using SleepEasyRegistry.BusinessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SleepEasyRegistry
{
    public partial class frmAddRegistration : Form
    {

        private string connectionString = "server=localhost;database=sleepeasyregistry;uid=root;pwd=\"\";";
        private List<Room> availableRooms = new List<Room>(); // List to store room information

        public frmAddRegistration()
        {
            InitializeComponent();
        }



        private void dtpCheckIn_ValueChanged(object sender, EventArgs e)
        {
            PopulateAvailableRooms();
        }

        private void dtpCheckOut_ValueChanged(object sender, EventArgs e)
        {
            PopulateAvailableRooms();
        }

        private void PopulateAvailableRooms()
        {
            cmbAvailableRooms.Items.Clear();  // Clear any previous items
            availableRooms.Clear();  // Clear previous room information

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

                    // Execute the query and populate the combo box
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

                        // Add the room number to the combo box
                        cmbAvailableRooms.Items.Add(room.RoomNum);

                        // Store the room information in the list
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


        private void frmAddRegistration_Load(object sender, EventArgs e)
        {
            PopulateAvailableRooms();
        }

        private void cmbAvailableRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ensure that a selection is made
            if (cmbAvailableRooms.SelectedIndex >= 0)
            {
                // Get the selected room number from the combo box
                int selectedRoomNum = Convert.ToInt32(cmbAvailableRooms.SelectedItem);

                // Find the room object corresponding to the selected room number
                Room selectedRoom = availableRooms.FirstOrDefault(r => r.RoomNum == selectedRoomNum);

                if (selectedRoom != null)
                {
                    // Set the text fields with the corresponding room details
                    txtRoomType.Text = selectedRoom.RoomType;
                    txtRoomRate.Text = selectedRoom.RoomRate.ToString("C"); // Format as currency
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Prompt the user with a confirmation message
            DialogResult result = MessageBox.Show(
                "You will loose any unsaved changes.",
                "Cancel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            // If the user confirms (clicks Yes), proceed with closing the form
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control characters (e.g., backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Prevent the character from being entered
            }
        }

        // Helper method to validate phone number (example: 10 digits)
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Assuming valid phone numbers are 10 digits long (you can modify this validation as needed)
            return phoneNumber.Length == 10 && phoneNumber.All(char.IsDigit);
        }

        // Helper method to validate email format
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnConfirmReg_Click(object sender, EventArgs e)
        {
            // Check if the first name is empty
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the last name is empty
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Last Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the address is empty
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the phone number is empty or invalid
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text) || !IsValidPhoneNumber(txtPhoneNumber.Text))
            {
                MessageBox.Show("Please enter a valid Phone Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the email is empty or invalid
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid Email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get selected room number
            string roomNumber = cmbAvailableRooms.Text;

            // Access the static variable from frmLogin
            int empId = frmLogin.CurrentEmpId;  // Accessing the static variable

            string roomRateText = txtRoomRate.Text;

            // Remove the dollar sign ('$') and any other non-numeric characters
            roomRateText = roomRateText.Replace("$", "").Trim();

            // Try to parse the remaining text as a double
            double rate;
            if (!double.TryParse(roomRateText, out rate))
            {
                MessageBox.Show("Please enter a valid room rate.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get other form details
            string fName = txtFirstName.Text;
            string lName = txtLastName.Text;
            string address = txtAddress.Text;
            string paymentMethod = cmbPayMethod.Text;

            // Calculate the duration between check-in and check-out dates
            DateTime checkInDate = dtpCheckIn.Value;
            DateTime checkOutDate = dtpCheckOut.Value;
            int duration = (checkOutDate - checkInDate).Days;

            // If duration is less than or equal to 0, show an error message
            if (duration <= 0)
            {
                MessageBox.Show("Check-out date must be later than check-in date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate the cost of stay
            double costOfStay = rate * duration;

            // Get email and phone number
            string email = txtEmail.Text;
            string phoneNum = txtPhoneNumber.Text;
            phoneNum = phoneNum.Insert(3, "-").Insert(7, "-");  // Format phone number


            // Create SQL query to insert the new record into the registration table
            string query = @"
        INSERT INTO registration 
        (roomNum, empId, roomRate, lastName, firstName, address, payMethod, currentStatus, checkInDate, checkOutDate, stayDuration, costOfStay, email, phoneNumber) 
        VALUES 
        (@RoomNum, @EmpId, @RoomRate, @LastName, @FirstName, @Address, @PayMethod, @CurrentStatus, @CheckInDate, @CheckOutDate, @StayDuration, @CostOfStay, @Email, @PhoneNumber);
    ";

            // Create MySQL connection and command
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Add parameters to the SQL command
                cmd.Parameters.AddWithValue("@RoomNum", roomNumber);
                cmd.Parameters.AddWithValue("@EmpId", empId);
                cmd.Parameters.AddWithValue("@RoomRate", rate);
                cmd.Parameters.AddWithValue("@LastName", lName);
                cmd.Parameters.AddWithValue("@FirstName", fName);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@PayMethod", paymentMethod);
                cmd.Parameters.AddWithValue("@CurrentStatus", "Registered");  // Assuming status is 0 (for available/active)
                cmd.Parameters.AddWithValue("@CheckInDate", checkInDate);
                cmd.Parameters.AddWithValue("@CheckOutDate", checkOutDate);
                cmd.Parameters.AddWithValue("@StayDuration", duration);
                cmd.Parameters.AddWithValue("@CostOfStay", costOfStay);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNum);

                try
                {
                    conn.Open(); // Open the MySQL connection
                    cmd.ExecuteNonQuery(); // Execute the insert command
                    MessageBox.Show("Registration is successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmMain mainForm = Application.OpenForms.OfType<frmMain>().FirstOrDefault();
                    if (mainForm != null)
                    {
                        mainForm.LoadRegistrationData();
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
