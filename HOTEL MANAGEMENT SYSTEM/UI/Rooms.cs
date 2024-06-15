using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class Rooms : UserControl
    {
        private Form1 form1;

        public Rooms()
        {
            InitializeComponent();
            InitializeHoverEffects();
            InitializeClickEvents();
        }

        private void InitializeHoverEffects()
        {
            // Add event handlers for MouseEnter and MouseLeave events
            Standardrooms.MouseEnter += panel_MouseEnter;
            Standardrooms.MouseLeave += panel_MouseLeave;

            Deluxrooms.MouseEnter += panel_MouseEnter;
            Deluxrooms.MouseLeave += panel_MouseLeave;

            Suitesrooms.MouseEnter += panel_MouseEnter;
            Suitesrooms.MouseLeave += panel_MouseLeave;
        }

        private void InitializeClickEvents()
        {
            Standardrooms.Click += Standardrooms_Click;
            Deluxrooms.Click += Deluxrooms_Click;
            Suitesrooms.Click += Suitesrooms_Click;
        }

        private void panel_MouseEnter(object sender, EventArgs e)
        {
            var panel = sender as Guna2CustomGradientPanel; // Ensure correct type casting
            panel.FillColor = Color.Black; // Change to the desired hover color
            panel.FillColor2 = Color.Gray;
            panel.FillColor3 = Color.Gray;
            panel.FillColor4 = Color.Black;
        }

        private void panel_MouseLeave(object sender, EventArgs e)
        {
            var panel = sender as Guna2CustomGradientPanel; // Ensure correct type casting
            panel.FillColor = Color.White; // Change back to the original color
            panel.FillColor2 = Color.White;
            panel.FillColor3 = Color.White;
            panel.FillColor4 = Color.White;
        }

        private void Standardrooms_Click(object sender, EventArgs e)
        {
            Standardroom standardroomForm = new Standardroom();
            standardroomForm.Show();
        }

        private void Deluxrooms_Click(object sender, EventArgs e)
        {
            DeluxeRooms deluxeRoomsForm = new DeluxeRooms();
            deluxeRoomsForm.Show();
        }

        private void Suitesrooms_Click(object sender, EventArgs e)
        {
            SuitesRoom suitesRoomForm = new SuitesRoom();
            suitesRoomForm.Show();
        }

        private void ChangeTextColor(Guna2CustomGradientPanel panel, Color color)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is Label)
                {
                    control.ForeColor = color;
                }
            }
        }
    }
}
