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
    public partial class DeluxeRoomConfirmPassword : Form
    {
        private DeluxeRoom roomToDelete = new DeluxeRoom();

        public DeluxeRoomConfirmPassword(DeluxeRoom room)
        {
            InitializeComponent();
            this.roomToDelete = room;
        }

        private void confirmbutton_Click(object sender, EventArgs e)
        {
            try
            {
                bool successAuthenticate = true;

                if (successAuthenticate)
                {
                    DeluxeRoomController deleteDeluxeRoom = new DeluxeRoomController();
                    bool deleteSuccess = deleteDeluxeRoom.DeleteDeluxeRoom(roomToDelete);

                    if (deleteSuccess)
                    {
                        MessageBox.Show("Room successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DeluxeRooms deluxeroom = new DeluxeRooms();
                        this.Close();
                        deluxeroom.Show();
                    }
                    else
                    {
                        throw new Exception("Failed to delete room.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NavBack_Click(object sender, EventArgs e)
        {
            this.Close();
            DeluxeRoomDelete backDeleteRoom = new DeluxeRoomDelete(roomToDelete);
            backDeleteRoom.ShowDialog();
        }
    }
}
