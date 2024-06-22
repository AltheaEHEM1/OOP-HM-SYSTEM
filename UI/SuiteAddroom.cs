using HOTEL_MANAGEMENT_SYSTEM.Controllers;
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

namespace HOTEL_MANAGEMENT_SYSTEM
{
    public partial class SuiteAddroom : Form
    {
        public SuiteAddroom()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Savebutton_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Savebutton_Click_1(object sender, EventArgs e)
        {
            // assign the value to the variables
            int roomNumber = Convert.ToInt32(roomnumber.Text);
            double roomPrice = Convert.ToDouble(roomprice.Text);
            int occupancyLimit = Convert.ToInt32(occupancylimit.Text);
            string roomStatus = roomstatus.Text;
            string suiteType = suitetype.Text;
            int numberOfRooms = Convert.ToInt32(numberofrooms.Text);

            // create DeluxeRoomController instance
            SuiteRoomController suiteRoomController = new SuiteRoomController();

            bool success = suiteRoomController.AddSuiteRoom(roomNumber, roomStatus, roomPrice, occupancyLimit, numberOfRooms, suiteType);

            // checks if added to the database
            if (success == true)
            {
                // show success message
                MessageBox.Show("Room Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // show error message
                MessageBox.Show("Failed to Add Room", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
