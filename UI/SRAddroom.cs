using HOTEL_MANAGEMENT_SYSTEM.Controllers;
using HOTEL_MANAGEMENT_SYSTEM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class SRAddroom : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );
        public SRAddroom()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void addRoomBtn_Click(object sender, EventArgs e)
        {
            // checks if all fields are empty
            if (Roomnumberadd.Text == null)
            {
               MessageBox.Show("Room Number is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Roomnumberadd.Focus();
                return;
            }
            if (Roompriceadd.Text == null)
            {
                MessageBox.Show("Room Price is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Roompriceadd.Focus();
                return;
            }
            if (occupancylimitadd.Text == null)
            {
                MessageBox.Show("Occupancy Limit is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                occupancylimitadd.Focus();
                return;
            }
            if (roomStatusadd.Text == null)
            {
                MessageBox.Show("Room Status is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                roomStatusadd.Focus();
                return;
            }
            if (bedTypeadd.Text == null)
            {
                MessageBox.Show("Bed Type is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bedTypeadd.Focus();
                return;
            } 
            if (bathroomInclusionadd.Text == null)
            {
                MessageBox.Show("Bathroom Inclusion is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bathroomInclusionadd.Focus();
                return;
            }

            // create instance of StandardRoom
            StandardRoom standardRoom = new StandardRoom();

            // assign the value of the textboxes to the properties of the standardRoom object
            standardRoom.RoomNumber = Convert.ToInt32(Roomnumberadd.Text);
            standardRoom.RoomPrice = Convert.ToDouble(Roompriceadd.Text);
            standardRoom.OccupancyLimit = Convert.ToInt32(occupancylimitadd.Text);
            standardRoom.RoomStatus = roomStatusadd.Text;
            standardRoom.BedType = bedTypeadd.Text;
            standardRoom.BathroomInclusion = bathroomInclusionadd.Text;

            // create standardRoomController instance
            StandardRoomController standardRoomController = new StandardRoomController();

            bool success = standardRoomController.AddStandardRoom(standardRoom);

            // checks if added to the database
            if (success == true)
            {
                // show success message
                MessageBox.Show("Room Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Standardroom standardroom = new Standardroom();
                standardroom.Show();
            }
            else
            {
                // show error message
                MessageBox.Show("Failed to Add Room", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Reset();
            }
        }

        // method to reset all fields
        private void Reset()
        {
            Roomnumberadd.Clear();
            Roompriceadd.Clear();
            occupancylimitadd.Clear();
            roomStatusadd.Clear();
            bedTypeadd.Clear();
            bathroomInclusionadd.Clear();
        }
    }
}
