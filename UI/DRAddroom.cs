using HOTEL_MANAGEMENT_SYSTEM.Controllers;
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
    public partial class DRAddroom : Form
    {
        public DRAddroom()
        {
            InitializeComponent();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            // assign the value to the variables
            int roomNumber = Convert.ToInt32(roomnumberadd.Text);
            double roomPrice = Convert.ToDouble(roompriceadd.Text);
            int occupancyLimit = Convert.ToInt32(occupancylimitadd.Text);
            string roomStatus = roomstatusadd.Text;
            string typeOfView = typeofviewadd.Text;

            // create DeluxeRoomController instance
            DeluxeRoomController deluxeRoomController = new DeluxeRoomController();

            bool success = deluxeRoomController.AddDeluxeRoom(roomNumber, roomStatus, roomPrice, occupancyLimit, typeOfView);

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
