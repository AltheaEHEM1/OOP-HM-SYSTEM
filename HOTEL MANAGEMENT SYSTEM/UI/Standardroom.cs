using System;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class Standardroom : Form
    {
        public Standardroom()
        {
            InitializeComponent();
        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelfortransparent.Controls.Clear();
            panelfortransparent.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void panelfortransparent_Paint(object sender, PaintEventArgs e)
        {
            panelfortransparent.BackColor = Color.Transparent;
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(200, 30, 30, 30))) //transparency
            {
                e.Graphics.FillRectangle(brush, panelfortransparent.ClientRectangle);
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
            addroom Addroom = new addroom();
            Addroom.Show();
        }

        private void Editbuttonstandard_Click(object sender, EventArgs e)
        {
            EditRoom editroom = new EditRoom();
            editroom.Show();
        }

        private void deletebuttonstandard_Click(object sender, EventArgs e)
        {
            Deleteroom del = new Deleteroom();
            del.Show();
        }
    }
}
