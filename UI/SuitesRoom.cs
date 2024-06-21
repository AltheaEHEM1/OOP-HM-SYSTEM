using System;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class SuitesRoom : Form
    {
        public SuitesRoom()
        {
            InitializeComponent();
        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            transparentpanelsuites.Controls.Clear();
            transparentpanelsuites.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void transparentpanelsuites_Paint(object sender, PaintEventArgs e)
        {
            transparentpanelsuites.BackColor = Color.Transparent;
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(200, 30, 30, 30))) //transparency
            {
                e.Graphics.FillRectangle(brush, transparentpanelsuites.ClientRectangle);
            }
        }

        private void backicon_Click(object sender, EventArgs e)
        {
            Rooms_admin rooms = new Rooms_admin();
            rooms.Show();

            // Hide the LoginPage form
            this.Hide();
        }

        private void Addroombutton_Click(object sender, EventArgs e)
        {
            SuiteAddroom suiteAddroom = new SuiteAddroom();
            suiteAddroom.Show();
        }

        private void Editbuttonsuite_Click(object sender, EventArgs e)
        {
            SuiteEditRoom suiteeditRoom = new SuiteEditRoom();
            suiteeditRoom.Show();
        }

        private void Deletebuttondeluxe_Click(object sender, EventArgs e)
        {
            Deleteroom delroom = new Deleteroom();
            delroom.Show();
        }
    }
}
