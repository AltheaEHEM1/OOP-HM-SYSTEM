using HOTEL_MANAGEMENT_SYSTEM.Controllers;
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

        private void Saveeditbutton_Click(object sender, EventArgs e)
        {
            // assign the value to the variables
            int roomNumber = Convert.ToInt32(Roomnumberadd.Text);
            double roomPrice = Convert.ToDouble(Roompriceadd.Text);
            int occupancyLimit = Convert.ToInt32(occupancylimitadd.Text);
            string roomStatus = roomStatusadd.Text;
            string bedType = bedTypeadd.Text;
            string bathroomInclusion = bathroomInclusionadd.Text;

            // create standardRoomController instance
            StandardRoomController standardRoomController = new StandardRoomController();

            bool success = standardRoomController.AddStandardRoom(roomNumber, roomStatus, roomPrice, occupancyLimit, bedType, bathroomInclusion);

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
