using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class Booknow : UserControl
    {
        private Form1 form1;

        public Booknow()
        {
            InitializeComponent(); //for elements 
            InitializeHoverEffects(); //hover effects on diff room type
            InitializeClickEvents(); //mouse click for diff room type
        }

        public Booknow(Form1 form1)
        {
            this.form1 = form1; //parent form
        }

        private void InitializeHoverEffects()
        {
            // Adding event handlers for MouseEnter and MouseLeave events
            SRPanel.MouseEnter += new EventHandler(guna2Panel_MouseEnter);
            SRPanel.MouseLeave += new EventHandler(guna2Panel_MouseLeave);

            DRPanel.MouseEnter += new EventHandler(guna2Panel_MouseEnter);
            DRPanel.MouseLeave += new EventHandler(guna2Panel_MouseLeave);

            SuitesPanel.MouseEnter += new EventHandler(guna2Panel_MouseEnter);
            SuitesPanel.MouseLeave += new EventHandler(guna2Panel_MouseLeave);
        }

        //Clicked event for SRPANEL only
        private void InitializeClickEvents()
        {
            SRPanel.Click += new EventHandler(SRPanel_Click);
            //DRPanel.Click += new EventHandler(DRPanel_Click);
            SuitesPanel.Click += SuitesPanel_Click;
        }

        // Event handler method for SRPanel click event
        private void SRPanel_Click(object sender, EventArgs e)
        {
            SelectRoom selectRoom = new SelectRoom();
            selectRoom.Show();

            // Close the parent form
            Form parentForm = this.FindForm();
            parentForm.Close();
        }


        // Event handler method for DRPanel click event
        private void DRPanel_Click(object sender, EventArgs e)
        {
            DeluxeRoom deluxeRoom = new DeluxeRoom();
            deluxeRoom.Show();

            // Close the parent form
            Form parentForm = this.FindForm();
            parentForm.Hide();
        }

        // Event handler method for SuitesPanel click event
        private void SuitesPanel_Click(object sender, EventArgs e)
        {
            Suites suites = new Suites();
            suites.Show();

            // Close the parent form
            Form parentForm = this.FindForm();
            parentForm.Hide();
        }

        //Hover color for panel 1 when mouse is hovered (Standard Room)
        private void guna2Panel_MouseEnter(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Panel panel = sender as Guna.UI2.WinForms.Guna2Panel;
            panel.FillColor = Color.LightGray;
        }

        //Revert the background color when mouse is not hovered
        private void guna2Panel_MouseLeave(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Panel panel = sender as Guna.UI2.WinForms.Guna2Panel;
            panel.FillColor = Color.Transparent;
        }

        private void Booknow_Load(object sender, EventArgs e)
        {
            // Do any additional initialization here if needed
        }

        private void Amount_Click(object sender, EventArgs e)
        {
            // Handle click event if needed
        }

        private void SRPanel_Paint(object sender, PaintEventArgs e)
        {
            // Handle paint event if needed
        }

        private void DRPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SuitesPanel_Paint(object sender, PaintEventArgs e)
        {
            // Handle paint event if needed
        }

        private void SelectRoom_Click(object sender, EventArgs e)
        {

        }
    }
}
