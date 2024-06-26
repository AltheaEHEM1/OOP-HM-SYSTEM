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
    public partial class SuiteRoomConfirmPassword : Form
    {
        private Suite suiteToDelete = new Suite();
        public SuiteRoomConfirmPassword(Suite room)
        {
            InitializeComponent();
            this.suiteToDelete = room;
        }

        private void confirmbutton_Click(object sender, EventArgs e)
        {
            try
            {
                bool successAuthenticate = true;

                if (successAuthenticate)
                {
                    SuiteRoomController deleteSuiteRoom = new SuiteRoomController();
                    bool deleteSuccess = deleteSuiteRoom.DeleteSuiteRoom(suiteToDelete);

                    if (deleteSuccess)
                    {
                        MessageBox.Show("Room successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SuitesRoom suiteroom = new SuitesRoom();
                        this.Close();
                        // load the SuitesRoom
                        suiteroom.Show();

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
            SuiteRoomDelete backDeleteRoom = new SuiteRoomDelete(suiteToDelete);
            backDeleteRoom.ShowDialog();
        }
    }
}
