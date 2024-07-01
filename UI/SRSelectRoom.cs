using HOTEL_MANAGEMENT_SYSTEM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class SRSelectRoom : Form
    {
        private Form_receptionist parentForm;
        private DateTime checkinDate;
        private DateTime checkOutDate;
        private int selectedRoomId;

        public SRSelectRoom()
        {
            InitializeComponent();
            //InitializeParentForm();

        }
        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            guna2Panel2.Controls.Clear();
            guna2Panel2.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void InitializeParentForm()
        {
            parentForm = new Form_receptionist();  // Create an instance of form1
        }

        private void SRNavback_Click(object sender, EventArgs e)
        {
            Booknow uc = new Booknow();
            addUserControl(uc);

            // Close the parent form
            Form parentForm = this.FindForm();
            this.Hide();
        }
        /*
        private void SRSelectRoom_Load(object sender, EventArgs e)
        {
            {
                Booknow booknow = new Booknow(); // Create an instance of Booknow
                addUserControl(uc); // Add Booknow to form1
            }
        }
        */

        private void NextNav_Click(object sender, EventArgs e)
        {
            try
            {
                // check if the user selected a room
                if (selectedRoomId != null)
                {
                    // navigate to the next page
                    this.Close();
                    ContactInfo contactInfo = new ContactInfo();
                    contactInfo.Show();
                }
                else
                {
                    throw new Exception("Please select a room first.")
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SRSelectRoom_Load(object sender, EventArgs e)
        {
            try
            {
                // load the available rooms
                LoadAvailableRooms();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAvailableRooms()
        {
            try
            {
                // reset the selectedRoomId
                selectedRoomId = null;

                // load room numbers that are available depending on the checkin and checkout date that was selected
                using (var context = new DataContext())
                {

                    // get the room numbers that are available
                    var availableRooms = context.Rooms
                        .OfType<StandardRoom>()
                        .Where(sr => !sr.IsDeleted && !sr.Bookings.Any(b => b.CheckInDate < checkOutDate && b.CheckOutDate > checkinDate))
                        .ToList();

                    // bind the available rooms to the grid view
                    // listOfStandardRooms.DataSource = availableRooms;

                    // clear the existing controls in the panel
                    standardRoomPanel.Controls.Clear();

                    // set the properties for each room representation
                    int numberOfColumns = 10;
                    int rowIndex = 0;
                    int columnIndex = 0;
                    int roomWidth = 50;
                    int roomHeight = 50;
                    int padding = 10; // distance between each room representation

                    // loop through the available rooms and create a representation for each row
                    foreach (var room in availableRooms)
                    {
                        // create label to represent the room
                        Label roomLabel = new Label();
                        roomLabel.Size = new Size(roomWidth, roomHeight);
                        roomLabel.BorderStyle = BorderStyle.FixedSingle;
                        roomLabel.TextAlign = ContentAlignment.MiddleCenter;
                        roomLabel.Text = room.RoomNumber.ToString();

                        // set the background color based on the status
                        string status = room.RoomStatus.ToLower();
                        switch (status)
                        {
                            case "available":
                                roomLabel.BackColor = Color.Green;
                                break;
                            case "occupied":
                                roomLabel.BackColor = Color.Maroon;
                                break;
                            case "under maintenance":
                                roomLabel.BackColor = Color.Gray;
                                break;
                            default:
                                roomLabel.BackColor = Color.White;
                                break;
                        }

                        // calculate position of the room representation
                        int xPosition = columnIndex * (roomWidth + padding);
                        int yPosition = rowIndex * (roomHeight + padding);
                        roomLabel.Location = new Point(xPosition, yPosition);

                        // Add the label to the pannel
                        standardRoomPanel.Controls.Add(roomLabel);

                        // update rowIndex and columnIndex
                        columnIndex++;
                        if (columnIndex == numberOfColumns)
                        {
                            columnIndex = 0;
                            rowIndex++;
                        }

                        // add click event handler to handle room selection
                        roomLabel.Click += (sender, e) => RoomLabel_Click(sender, e, room.RoomId);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RoomLabel_Click(object sender, EventArgs e, int roomId)
        {
            // assign the roomId to the selectedRoomId variable
            selectedRoomId = roomId;
        }


        private void CheckinDate_ValueChanged(object sender, EventArgs e)
        {
            // Assign the selected date to the checkinDate variable
            checkinDate = CheckinDate.Value;
            // Reload the available rooms
            LoadAvailableRooms();
        }

        private void CheckoutDate_ValueChanged(object sender, EventArgs e)
        {
            // Assign the selected date to the checkOutDate variable
            checkOutDate = CheckoutDate.Value;
            // Reload the available rooms
            LoadAvailableRooms();
        }
    }
}
