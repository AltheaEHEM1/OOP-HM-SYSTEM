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
    public partial class Reservations : UserControl
    {

        public Reservations()
        {
            InitializeComponent();

        }



        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ReservationDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void SearchBttn_Click(object sender, EventArgs e)
        {

        }

        private void ReserveDateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ModifyBttn_Click(object sender, EventArgs e)
        {
            ModifyPage modifyPage = new ModifyPage();
            modifyPage.Show(); // Use ShowDialog() if you want it as a modal dialog


        }

        private void CancelBttn_Click(object sender, EventArgs e)
        {
            TermsandCondition TCPage = new TermsandCondition();
            TCPage.Show(); // Use ShowDialog() if you want it as a modal dialog
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        internal void Reservations_Load()
        {
            throw new NotImplementedException();
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchBar_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ReservationsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Reservations_Load(object sender, EventArgs e)
        {
            ReservationsTable.Rows.Add("1000", "Shanella Amara Cagulang", "Standard Room", "12.31.24", "12.25.24");
            ReservationsTable.Rows.Add("1", "Maria Nadine Aureus Borja", "Standard Room", "12.31.24", "12.25.24");
            ReservationsTable.Rows.Add("1002", "Darben Lamonte", "Deluxe Room", "12.31.24", "12.25.24");
            ReservationsTable.Rows.Add("2", "Althea Amor Asis", "Suites", "12.31.24", "12.25.24");
            ReservationsTable.Rows.Add("13", "Miyuki Mharie Parocha", "Standard Room", "12.31.24", "12.25.24");
            ReservationsTable.Rows.Add("10", "Maria Nadine Aureus Borja", "Standard Room", "12.31.24", "12.25.24");
            ReservationsTable.Rows.Add("5", "Darben Lamonte", "Deluxe Room", "12.31.24", "12.25.24");
            ReservationsTable.Rows.Add("27", "Maria Nadine Aureus Borja", "Standard Room", "12.31.24", "12.25.24");
        }

        private void ReservationEditBttn_Click(object sender, EventArgs e)
        {
            ModifyPage callModifyPage = new ModifyPage();
            callModifyPage.ShowDialog();
        }

        private void ReservationCancelBttn_Click(object sender, EventArgs e)
        {
            TermsandCondition callTermsandCondition = new TermsandCondition();
            callTermsandCondition.ShowDialog();
        }

        private void ReservationCalendar_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
