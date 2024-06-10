using HOTEL_MANAGEMENT_SYSTEM.UI;

namespace HOTEL_MANAGEMENT_SYSTEM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Dashboard uc = new Dashboard();
            addUserControl(uc);
        }

        private void navigationbar_Paint(object sender, PaintEventArgs e)
        {
            navigationbar.BackColor = Color.Transparent;
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(200, 30, 30, 30))) //transparency
            {
                e.Graphics.FillRectangle(brush, navigationbar.ClientRectangle);
            }
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void Dashboard_Click(object sender, EventArgs e)
        {
            Dashboard uc = new Dashboard();
            addUserControl(uc);
        }

        private void Booknow_Click(object sender, EventArgs e)
        {
            Booknow uc = new Booknow();
            addUserControl(uc);
        }

        private void Rooms_Click(object sender, EventArgs e)
        {
            Rooms uc = new Rooms();
            addUserControl(uc);
        }

        private void Reservations_Click(object sender, EventArgs e)
        {
            Reservations uc = new Reservations();
            addUserControl(uc);
        }

        private void Transactions_Click(object sender, EventArgs e)
        {
            Transactions uc = new Transactions();
            addUserControl(uc);
        }
    }
}
