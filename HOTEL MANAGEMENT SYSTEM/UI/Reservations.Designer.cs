namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    partial class Reservations
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservations));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            SearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            ReservationCalendar = new Guna.UI2.WinForms.Guna2DateTimePicker();
            TablePanelSample = new Guna.UI2.WinForms.Guna2Panel();
            ReservationsTable = new Guna.UI2.WinForms.Guna2DataGridView();
            Room = new DataGridViewTextBoxColumn();
            Guest = new DataGridViewTextBoxColumn();
            RoomType = new DataGridViewTextBoxColumn();
            Checkin = new DataGridViewTextBoxColumn();
            Checkout = new DataGridViewTextBoxColumn();
            ReservationEditBttn = new Guna.UI2.WinForms.Guna2Button();
            ReservationCancelBttn = new Guna.UI2.WinForms.Guna2Button();
            TablePanelSample.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReservationsTable).BeginInit();
            SuspendLayout();
            // 
            // SearchBar
            // 
            SearchBar.BackColor = SystemColors.Control;
            SearchBar.BorderColor = Color.Black;
            SearchBar.BorderRadius = 10;
            SearchBar.CustomizableEdges = customizableEdges1;
            SearchBar.DefaultText = "";
            SearchBar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            SearchBar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            SearchBar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            SearchBar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            SearchBar.FillColor = SystemColors.Control;
            SearchBar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            SearchBar.Font = new Font("Segoe UI", 9F);
            SearchBar.HoverState.BorderColor = Color.Black;
            SearchBar.IconLeft = (Image)resources.GetObject("SearchBar.IconLeft");
            SearchBar.IconLeftOffset = new Point(10, 0);
            SearchBar.Location = new Point(934, 43);
            SearchBar.Name = "SearchBar";
            SearchBar.PasswordChar = '\0';
            SearchBar.PlaceholderForeColor = Color.Gray;
            SearchBar.PlaceholderText = "Search by guest, reservation";
            SearchBar.SelectedText = "";
            SearchBar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            SearchBar.Size = new Size(296, 37);
            SearchBar.TabIndex = 0;
            SearchBar.TextChanged += SearchBar_TextChanged_1;
            // 
            // ReservationCalendar
            // 
            ReservationCalendar.BorderRadius = 10;
            ReservationCalendar.Checked = true;
            ReservationCalendar.CustomizableEdges = customizableEdges3;
            ReservationCalendar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReservationCalendar.ForeColor = Color.WhiteSmoke;
            ReservationCalendar.Format = DateTimePickerFormat.Custom;
            ReservationCalendar.HoverState.FillColor = Color.FromArgb(13, 22, 29);
            ReservationCalendar.Location = new Point(78, 35);
            ReservationCalendar.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            ReservationCalendar.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            ReservationCalendar.Name = "ReservationCalendar";
            ReservationCalendar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ReservationCalendar.Size = new Size(255, 45);
            ReservationCalendar.TabIndex = 1;
            ReservationCalendar.TextOffset = new Point(10, 0);
            ReservationCalendar.Value = new DateTime(2024, 6, 15, 20, 50, 37, 914);
            // 
            // TablePanelSample
            // 
            TablePanelSample.BackColor = Color.Transparent;
            TablePanelSample.BorderColor = Color.Black;
            TablePanelSample.BorderRadius = 20;
            TablePanelSample.BorderThickness = 1;
            TablePanelSample.Controls.Add(ReservationsTable);
            TablePanelSample.CustomizableEdges = customizableEdges5;
            TablePanelSample.Location = new Point(147, 100);
            TablePanelSample.Name = "TablePanelSample";
            TablePanelSample.ShadowDecoration.CustomizableEdges = customizableEdges6;
            TablePanelSample.Size = new Size(1117, 393);
            TablePanelSample.TabIndex = 2;
            // 
            // ReservationsTable
            // 
            ReservationsTable.AllowUserToAddRows = false;
            ReservationsTable.AllowUserToDeleteRows = false;
            ReservationsTable.AllowUserToResizeColumns = false;
            ReservationsTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            ReservationsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ReservationsTable.BackgroundColor = SystemColors.Control;
            ReservationsTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(12, 22, 29);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(12, 22, 29);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ReservationsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ReservationsTable.ColumnHeadersHeight = 50;
            ReservationsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ReservationsTable.Columns.AddRange(new DataGridViewColumn[] { Room, Guest, RoomType, Checkin, Checkout });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ReservationsTable.DefaultCellStyle = dataGridViewCellStyle3;
            ReservationsTable.Dock = DockStyle.Fill;
            ReservationsTable.GridColor = Color.WhiteSmoke;
            ReservationsTable.Location = new Point(0, 0);
            ReservationsTable.Name = "ReservationsTable";
            ReservationsTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            ReservationsTable.RowHeadersVisible = false;
            ReservationsTable.RowTemplate.DividerHeight = 2;
            ReservationsTable.RowTemplate.Height = 50;
            ReservationsTable.ScrollBars = ScrollBars.Vertical;
            ReservationsTable.Size = new Size(1117, 393);
            ReservationsTable.TabIndex = 0;
            ReservationsTable.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            ReservationsTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            ReservationsTable.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            ReservationsTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            ReservationsTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            ReservationsTable.ThemeStyle.BackColor = SystemColors.Control;
            ReservationsTable.ThemeStyle.GridColor = Color.WhiteSmoke;
            ReservationsTable.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            ReservationsTable.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            ReservationsTable.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            ReservationsTable.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            ReservationsTable.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ReservationsTable.ThemeStyle.HeaderStyle.Height = 50;
            ReservationsTable.ThemeStyle.ReadOnly = false;
            ReservationsTable.ThemeStyle.RowsStyle.BackColor = Color.White;
            ReservationsTable.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ReservationsTable.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            ReservationsTable.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            ReservationsTable.ThemeStyle.RowsStyle.Height = 50;
            ReservationsTable.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            ReservationsTable.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            ReservationsTable.CellContentClick += ReservationsTable_CellContentClick;
            // 
            // Room
            // 
            Room.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Room.HeaderText = "Room";
            Room.Name = "Room";
            Room.SortMode = DataGridViewColumnSortMode.NotSortable;
            Room.Width = 150;
            // 
            // Guest
            // 
            Guest.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Guest.HeaderText = "Guest";
            Guest.Name = "Guest";
            Guest.SortMode = DataGridViewColumnSortMode.NotSortable;
            Guest.Width = 400;
            // 
            // RoomType
            // 
            RoomType.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            RoomType.HeaderText = "Room Type";
            RoomType.Name = "RoomType";
            RoomType.SortMode = DataGridViewColumnSortMode.NotSortable;
            RoomType.Width = 250;
            // 
            // Checkin
            // 
            Checkin.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Checkin.HeaderText = "Check-in";
            Checkin.Name = "Checkin";
            Checkin.SortMode = DataGridViewColumnSortMode.NotSortable;
            Checkin.Width = 150;
            // 
            // Checkout
            // 
            Checkout.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Checkout.HeaderText = "Check-out";
            Checkout.Name = "Checkout";
            Checkout.SortMode = DataGridViewColumnSortMode.NotSortable;
            Checkout.Width = 160;
            // 
            // ReservationEditBttn
            // 
            ReservationEditBttn.BorderRadius = 10;
            ReservationEditBttn.CustomizableEdges = customizableEdges7;
            ReservationEditBttn.DisabledState.BorderColor = Color.DarkGray;
            ReservationEditBttn.DisabledState.CustomBorderColor = Color.DarkGray;
            ReservationEditBttn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ReservationEditBttn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ReservationEditBttn.FillColor = Color.FromArgb(213, 171, 97);
            ReservationEditBttn.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReservationEditBttn.ForeColor = Color.White;
            ReservationEditBttn.Location = new Point(357, 631);
            ReservationEditBttn.Name = "ReservationEditBttn";
            ReservationEditBttn.ShadowDecoration.CustomizableEdges = customizableEdges8;
            ReservationEditBttn.Size = new Size(210, 60);
            ReservationEditBttn.TabIndex = 3;
            ReservationEditBttn.Text = "Edit";
            ReservationEditBttn.Click += ReservationEditBttn_Click;
            // 
            // ReservationCancelBttn
            // 
            ReservationCancelBttn.BorderRadius = 10;
            ReservationCancelBttn.CustomizableEdges = customizableEdges9;
            ReservationCancelBttn.DisabledState.BorderColor = Color.DarkGray;
            ReservationCancelBttn.DisabledState.CustomBorderColor = Color.DarkGray;
            ReservationCancelBttn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ReservationCancelBttn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ReservationCancelBttn.FillColor = Color.FromArgb(126, 6, 6);
            ReservationCancelBttn.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReservationCancelBttn.ForeColor = Color.White;
            ReservationCancelBttn.Location = new Point(833, 631);
            ReservationCancelBttn.Name = "ReservationCancelBttn";
            ReservationCancelBttn.ShadowDecoration.CustomizableEdges = customizableEdges10;
            ReservationCancelBttn.Size = new Size(210, 60);
            ReservationCancelBttn.TabIndex = 4;
            ReservationCancelBttn.Text = "Cancel";
            ReservationCancelBttn.Click += ReservationCancelBttn_Click;
            // 
            // Reservations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(ReservationCancelBttn);
            Controls.Add(ReservationEditBttn);
            Controls.Add(TablePanelSample);
            Controls.Add(ReservationCalendar);
            Controls.Add(SearchBar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Reservations";
            Size = new Size(1400, 734);
            Load += Reservations_Load;
            TablePanelSample.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ReservationsTable).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox SearchBar;
        private Guna.UI2.WinForms.Guna2DateTimePicker ReservationCalendar;
        private Guna.UI2.WinForms.Guna2Panel TablePanelSample;
        private Guna.UI2.WinForms.Guna2DataGridView ReservationsTable;
        private DataGridViewTextBoxColumn Room;
        private DataGridViewTextBoxColumn Guest;
        private DataGridViewTextBoxColumn RoomType;
        private DataGridViewTextBoxColumn Checkin;
        private DataGridViewTextBoxColumn Checkout;
        private Guna.UI2.WinForms.Guna2Button ReservationEditBttn;
        private Guna.UI2.WinForms.Guna2Button ReservationCancelBttn;
    }
}
