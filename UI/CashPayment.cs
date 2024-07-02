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

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class CashPayment : Form
    {
        // variable that will hold the parameters from the previous form
        private int selectedRoomId;
        private Guest guestInfo;
        private Booking newBooking;
        private string roomType;

        public CashPayment(int roomId, Guest guest, Booking booking, string roomType)
        {
            InitializeComponent();
            selectedRoomId = roomId;
            guestInfo = guest;
            newBooking = booking;
            this.roomType = roomType;
        }

        private void transparentbg_Paint(object sender, PaintEventArgs e)
        {
            transparentbg.BackColor = Color.Transparent;
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(200, 30, 30, 30))) //transparency
            {
                e.Graphics.FillRectangle(brush, transparentbg.ClientRectangle);
            }
        }

        private void backicon_Click(object sender, EventArgs e)
        {
            PaymentInfo paymentInfo = new PaymentInfo(selectedRoomId, guestInfo, newBooking, roomType);
            paymentInfo.Show();
            this.Hide();
        }

        private void Confirmbutton_Click(object sender, EventArgs e)
        {
            this.Hide();

            // naviagate to booking summary form
            BookingSummary bookingSummary = new BookingSummary(selectedRoomId, guestInfo, newBooking, roomType);
            this.Show();
            
        }

        private void CashPayment_Load(object sender, EventArgs e)
        {
            
            using (var context = new DataContext())
            {
                // get the room price of the selected roomId
                var roomPrice = context.Rooms.Where(r => r.RoomId == selectedRoomId).Select(r => r.RoomPrice).FirstOrDefault();

                // display the room price
                totalAmountLabel.Text = roomPrice.ToString();
            }

        }
    }
}
