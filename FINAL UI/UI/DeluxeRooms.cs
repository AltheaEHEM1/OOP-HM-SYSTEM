using System;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class DeluxeRooms : Form
    {
        public DeluxeRooms()
        {
            InitializeComponent();
        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            transparentpaneldeluxe.Controls.Clear();
            transparentpaneldeluxe.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void transparentpaneldeluxe_Paint(object sender, PaintEventArgs e)
        {
            transparentpaneldeluxe.BackColor = Color.Transparent;
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(200, 30, 30, 30))) //transparency
            {
                e.Graphics.FillRectangle(brush, transparentpaneldeluxe.ClientRectangle);
            }
        }

        private void backicon_Click(object sender, EventArgs e)
        {
            Rooms_admin rooms = new Rooms_admin();
            rooms.Show();

            // Hide the LoginPage form
            this.Hide();
        }

        private void Addroomicon_Click(object sender, EventArgs e)
        {
            DRAddroom drAddroom = new DRAddroom();
            drAddroom.Show();
        }

        private void Editbuttondeluxe_Click(object sender, EventArgs e)
        {
            DREditRoom dreditRoom = new DREditRoom();
            dreditRoom.Show();
        }

        private void Deletebuttondeluxe_Click(object sender, EventArgs e)
        {
            Deleteroom delroom = new Deleteroom();
            delroom.Show();
        }
    }
}
