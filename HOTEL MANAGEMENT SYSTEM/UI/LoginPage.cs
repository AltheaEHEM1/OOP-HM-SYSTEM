using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.IO;
using System.Drawing.Text;
using System.Reflection;
using System.Drawing;
using System.Drawing.Drawing2D;
using Guna.UI2.WinForms; // Add this namespace

namespace HOTEL_MANAGEMENT_SYSTEM
{
    public partial class CreateAccount : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public CreateAccount()
        {
            InitializeComponent();
            panel2.Parent = pictureBox1;
            panel2.BackColor = Color.FromArgb(200, Color.White);
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 20, 20));
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            // Hide the LoginPage form
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}