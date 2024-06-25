﻿using HOTEL_MANAGEMENT_SYSTEM.Controllers;
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
            SRAddroom Addroom = new SRAddroom();
            Addroom.Show();
        }

        private void Editbuttonstandard_Click(object sender, EventArgs e)
        {
            SREditRoom SReditRoom = new SREditRoom();
            SReditRoom.Show();
        }

        private void deletebuttonstandard_Click(object sender, EventArgs e)
        {
            Deleteroom del = new Deleteroom();
            del.Show();
        }

        private void Standardroom_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            // create instance of StandardRoomController
            var standardRoomController = new StandardRoomController();

            // get the list of rooms from the database and display in gridview
            Standardroomgridview.DataSource = standardRoomController.GetStandardRooms();


        }
    }
}
