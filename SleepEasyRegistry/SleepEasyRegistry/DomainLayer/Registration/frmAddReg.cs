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
            dtpCheckIn.MinDate = DateTime.Now;
            dtpCheckOut.MinDate = DateTime.Now.AddDays(1);
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
            // Clear the text fields
            txtCostOfStay.Clear();
            txtRoomRate.Clear();
            txtRoomType.Clear();
            // Unselect the currently selected item in the combo box
            cmbAvailableRooms.SelectedIndex = -1;

            availableRooms.Clear();  // Clear previous room information
            cmbAvailableRooms.Items.Clear();  // Clear any previous items

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

                    // Calculate the length of stay by subtracting the check-in date from the check-out date
                    DateTime checkInDate = dtpCheckIn.Value;
                    DateTime checkOutDate = dtpCheckOut.Value;
                    int lengthOfStay = (checkOutDate.Date - checkInDate.Date).Days;

                    // Ensure the length of stay is a positive number
                    if (lengthOfStay > 0)
                    {
                        // Calculate the total cost (RoomRate * Length of stay)
                        decimal totalCost = selectedRoom.RoomRate * lengthOfStay;

                        // Set the total cost text field
                        txtCostOfStay.Text = totalCost.ToString("C"); // Format as currency
                    }
                    else
                    {
                        MessageBox.Show("Check-out date must be after the check-in date.");
                        cmbAvailableRooms.SelectedIndex = -1;
                        txtRoomRate.Clear();
                        txtRoomType.Clear();
                        txtCostOfStay.Clear();
                    }
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
            List<string> errors = new List<string>();

            // Validate first name
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
                errors.Add("• First Name is required.");

            // Validate last name
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
                errors.Add("• Last Name is required.");

            // Validate address
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
                errors.Add("• Address is required.");

            // Validate phone number
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text) || !IsValidPhoneNumber(txtPhoneNumber.Text))
                errors.Add("• Please enter a valid Phone Number.");

            // Validate email
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !IsValidEmail(txtEmail.Text))
                errors.Add("• Please enter a valid Email address.");

            // Validate room rate
            string roomRateText = txtRoomRate.Text.Replace("$", "").Trim();
            if (!double.TryParse(roomRateText, out double rate))
                errors.Add("• Please select a room.");

            // Validate check-in and check-out dates
            DateTime checkInDate = dtpCheckIn.Value.Date;
            DateTime checkOutDate = dtpCheckOut.Value.Date;
            int duration = (checkOutDate - checkInDate).Days + 1;

            if (duration <= 0)
                errors.Add("• Check-out date must be later than check-in date.");

            // Validate payment method
            if (cmbPayMethod.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cmbPayMethod.Text))
                errors.Add("• Payment Method is required.");

            // If there are validation errors, display them and return
            if (errors.Count > 0)
            {
                // Format the error messages
                string errorMessage = "Missing Fields:\n\n";
                errorMessage += string.Join("\n", errors);

                // Show the formatted error message in a message box
                MessageBox.Show(errorMessage, "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Proceed with inserting the data into the database
            string roomNumber = cmbAvailableRooms.Text;
            int empId = frmLogin.CurrentEmpId; // Access static variable

            string fName = txtFirstName.Text;
            string lName = txtLastName.Text;
            string address = txtAddress.Text;
            string paymentMethod = cmbPayMethod.Text;

            double costOfStay = rate * duration;
            string email = txtEmail.Text;
            string phoneNum = txtPhoneNumber.Text;
            phoneNum = phoneNum.Insert(3, "-").Insert(7, "-"); // Format phone number

            string query = @"
INSERT INTO registration 
(roomNum, empId, roomRate, lastName, firstName, address, payMethod, currentStatus, checkInDate, checkOutDate, stayDuration, costOfStay, email, phoneNumber) 
VALUES 
(@RoomNum, @EmpId, @RoomRate, @LastName, @FirstName, @Address, @PayMethod, @CurrentStatus, @CheckInDate, @CheckOutDate, @StayDuration, @CostOfStay, @Email, @PhoneNumber);
";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RoomNum", roomNumber);
                cmd.Parameters.AddWithValue("@EmpId", empId);
                cmd.Parameters.AddWithValue("@RoomRate", rate);
                cmd.Parameters.AddWithValue("@LastName", lName);
                cmd.Parameters.AddWithValue("@FirstName", fName);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@PayMethod", paymentMethod);
                cmd.Parameters.AddWithValue("@CurrentStatus", "Registered");
                cmd.Parameters.AddWithValue("@CheckInDate", checkInDate);
                cmd.Parameters.AddWithValue("@CheckOutDate", checkOutDate);
                cmd.Parameters.AddWithValue("@StayDuration", duration);
                cmd.Parameters.AddWithValue("@CostOfStay", costOfStay);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNum);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
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
