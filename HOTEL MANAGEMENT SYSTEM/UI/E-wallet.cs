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
    public partial class E_wallet : Form
    {
        public E_wallet()
        {
            InitializeComponent();

            //  MouseEnter and MouseLeave events for hover effect
            GcashPanel.MouseEnter += Panel_MouseEnter;
            GcashPanel.MouseLeave += Panel_MouseLeave;
            mayapanel.MouseEnter += Panel_MouseEnter;
            mayapanel.MouseLeave += Panel_MouseLeave;
            bpipanel.MouseEnter += Panel_MouseEnter;
            bpipanel.MouseLeave += Panel_MouseLeave;
            bdopanel.MouseEnter += Panel_MouseEnter;
            bdopanel.MouseLeave += Panel_MouseLeave;
            eastwestpanel.MouseEnter += Panel_MouseEnter;
            eastwestpanel.MouseLeave += Panel_MouseLeave;
            unionbankpanel.MouseEnter += Panel_MouseEnter;
            unionbankpanel.MouseLeave += Panel_MouseLeave;
            landbankpanel.MouseEnter += Panel_MouseEnter;
            landbankpanel.MouseLeave += Panel_MouseLeave;
        }

        private void Panel_MouseEnter(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                panel.BackColor = Color.LightGray; // Change to desired hover color
            }
        }

        private void Panel_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                panel.BackColor = SystemColors.Control; // Change to original color
            }
        }

        private void GcashPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mayapanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bpipanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bdopanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void eastwestpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void unionbankpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void landbankpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
