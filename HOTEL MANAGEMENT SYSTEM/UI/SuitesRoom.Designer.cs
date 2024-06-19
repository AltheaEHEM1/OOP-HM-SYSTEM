namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    partial class SuitesRoom
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            headersuites = new Panel();
            philtext = new Label();
            QCTEXT = new Label();
            locationpic = new PictureBox();
            pictureBox1 = new PictureBox();
            transparentpanelsuites = new Panel();
            Addroomicon = new Panel();
            Editbuttonsuite = new Guna.UI2.WinForms.Guna2Button();
            Deletebuttondeluxe = new Guna.UI2.WinForms.Guna2Button();
            panelwhitebgforsuites = new Panel();
            suitesroomgridview = new Guna.UI2.WinForms.Guna2DataGridView();
            Room_Number = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            HasJacuzzi = new DataGridViewTextBoxColumn();
            NumberofRoom = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Addroombutton = new Guna.UI2.WinForms.Guna2Button();
            Suitestext = new Label();
            backicon = new PictureBox();
            upperradius = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipsepanelinsuites = new Guna.UI2.WinForms.Guna2Elipse(components);
            headersuites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)locationpic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Addroomicon.SuspendLayout();
            panelwhitebgforsuites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)suitesroomgridview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backicon).BeginInit();
            SuspendLayout();
            // 
            // headersuites
            // 
            headersuites.BackColor = Color.FromArgb(13, 22, 29);
            headersuites.Controls.Add(philtext);
            headersuites.Controls.Add(QCTEXT);
            headersuites.Controls.Add(locationpic);
            headersuites.Controls.Add(pictureBox1);
            headersuites.Dock = DockStyle.Top;
            headersuites.Location = new Point(0, 0);
            headersuites.Name = "headersuites";
            headersuites.Size = new Size(1440, 141);
            headersuites.TabIndex = 0;
            // 
            // philtext
            // 
            philtext.AutoSize = true;
            philtext.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            philtext.ForeColor = Color.White;
            philtext.Location = new Point(55, 99);
            philtext.Name = "philtext";
            philtext.Size = new Size(84, 20);
            philtext.TabIndex = 15;
            philtext.Text = "Philippines";
            // 
            // QCTEXT
            // 
            QCTEXT.AutoSize = true;
            QCTEXT.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QCTEXT.ForeColor = Color.White;
            QCTEXT.Location = new Point(55, 79);
            QCTEXT.Name = "QCTEXT";
            QCTEXT.Size = new Size(102, 20);
            QCTEXT.TabIndex = 14;
            QCTEXT.Text = "Quezon City.";
            // 
            // locationpic
            // 
            locationpic.Image = Properties.Resources.icons8_location_24;
            locationpic.Location = new Point(55, 47);
            locationpic.Name = "locationpic";
            locationpic.Size = new Size(31, 29);
            locationpic.TabIndex = 13;
            locationpic.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.headerpic_removebg_preview;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1440, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // transparentpanelsuites
            // 
            transparentpanelsuites.BackColor = Color.DimGray;
            transparentpanelsuites.Dock = DockStyle.Top;
            transparentpanelsuites.Location = new Point(0, 141);
            transparentpanelsuites.Name = "transparentpanelsuites";
            transparentpanelsuites.Size = new Size(1440, 66);
            transparentpanelsuites.TabIndex = 1;
            transparentpanelsuites.Paint += transparentpanelsuites_Paint;
            // 
            // Addroomicon
            // 
            Addroomicon.BackColor = Color.White;
            Addroomicon.Controls.Add(Editbuttonsuite);
            Addroomicon.Controls.Add(Deletebuttondeluxe);
            Addroomicon.Controls.Add(panelwhitebgforsuites);
            Addroomicon.Controls.Add(Addroombutton);
            Addroomicon.Controls.Add(Suitestext);
            Addroomicon.Controls.Add(backicon);
            Addroomicon.Dock = DockStyle.Fill;
            Addroomicon.Location = new Point(0, 207);
            Addroomicon.Name = "Addroomicon";
            Addroomicon.Size = new Size(1440, 693);
            Addroomicon.TabIndex = 2;
            // 
            // Editbuttonsuite
            // 
            Editbuttonsuite.BorderRadius = 10;
            Editbuttonsuite.CustomizableEdges = customizableEdges1;
            Editbuttonsuite.DisabledState.BorderColor = Color.DarkGray;
            Editbuttonsuite.DisabledState.CustomBorderColor = Color.DarkGray;
            Editbuttonsuite.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Editbuttonsuite.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Editbuttonsuite.FillColor = Color.FromArgb(214, 164, 38);
            Editbuttonsuite.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Editbuttonsuite.ForeColor = Color.White;
            Editbuttonsuite.Location = new Point(1020, 599);
            Editbuttonsuite.Name = "Editbuttonsuite";
            Editbuttonsuite.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Editbuttonsuite.Size = new Size(133, 45);
            Editbuttonsuite.TabIndex = 11;
            Editbuttonsuite.Text = "Edit";
            Editbuttonsuite.Click += Editbuttonsuite_Click;
            // 
            // Deletebuttondeluxe
            // 
            Deletebuttondeluxe.BorderRadius = 10;
            Deletebuttondeluxe.CustomizableEdges = customizableEdges3;
            Deletebuttondeluxe.DisabledState.BorderColor = Color.DarkGray;
            Deletebuttondeluxe.DisabledState.CustomBorderColor = Color.DarkGray;
            Deletebuttondeluxe.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Deletebuttondeluxe.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Deletebuttondeluxe.FillColor = Color.FromArgb(126, 6, 6);
            Deletebuttondeluxe.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Deletebuttondeluxe.ForeColor = Color.White;
            Deletebuttondeluxe.Location = new Point(1165, 599);
            Deletebuttondeluxe.Name = "Deletebuttondeluxe";
            Deletebuttondeluxe.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Deletebuttondeluxe.Size = new Size(133, 45);
            Deletebuttondeluxe.TabIndex = 12;
            Deletebuttondeluxe.Text = "Delete";
            Deletebuttondeluxe.Click += Deletebuttondeluxe_Click;
            // 
            // panelwhitebgforsuites
            // 
            panelwhitebgforsuites.Controls.Add(suitesroomgridview);
            panelwhitebgforsuites.Location = new Point(55, 88);
            panelwhitebgforsuites.Name = "panelwhitebgforsuites";
            panelwhitebgforsuites.Size = new Size(1310, 505);
            panelwhitebgforsuites.TabIndex = 10;
            // 
            // suitesroomgridview
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(13, 22, 29);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            suitesroomgridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(13, 22, 29);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            suitesroomgridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            suitesroomgridview.ColumnHeadersHeight = 50;
            suitesroomgridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            suitesroomgridview.Columns.AddRange(new DataGridViewColumn[] { Room_Number, Price, HasJacuzzi, NumberofRoom, Status });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            suitesroomgridview.DefaultCellStyle = dataGridViewCellStyle3;
            suitesroomgridview.Dock = DockStyle.Fill;
            suitesroomgridview.Enabled = false;
            suitesroomgridview.GridColor = Color.FromArgb(231, 229, 255);
            suitesroomgridview.Location = new Point(0, 0);
            suitesroomgridview.Name = "suitesroomgridview";
            suitesroomgridview.RowHeadersVisible = false;
            suitesroomgridview.RowHeadersWidth = 51;
            suitesroomgridview.Size = new Size(1310, 505);
            suitesroomgridview.TabIndex = 2;
            suitesroomgridview.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            suitesroomgridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            suitesroomgridview.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            suitesroomgridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            suitesroomgridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            suitesroomgridview.ThemeStyle.BackColor = Color.White;
            suitesroomgridview.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            suitesroomgridview.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            suitesroomgridview.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            suitesroomgridview.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            suitesroomgridview.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            suitesroomgridview.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            suitesroomgridview.ThemeStyle.HeaderStyle.Height = 50;
            suitesroomgridview.ThemeStyle.ReadOnly = false;
            suitesroomgridview.ThemeStyle.RowsStyle.BackColor = Color.White;
            suitesroomgridview.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            suitesroomgridview.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            suitesroomgridview.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            suitesroomgridview.ThemeStyle.RowsStyle.Height = 29;
            suitesroomgridview.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            suitesroomgridview.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // Room_Number
            // 
            Room_Number.FillWeight = 94.33156F;
            Room_Number.HeaderText = "Room Number";
            Room_Number.MinimumWidth = 6;
            Room_Number.Name = "Room_Number";
            // 
            // Price
            // 
            Price.FillWeight = 94.33156F;
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            // 
            // HasJacuzzi
            // 
            HasJacuzzi.FillWeight = 94.33156F;
            HasJacuzzi.HeaderText = "Has Jacuzzi";
            HasJacuzzi.MinimumWidth = 6;
            HasJacuzzi.Name = "HasJacuzzi";
            // 
            // NumberofRoom
            // 
            NumberofRoom.FillWeight = 94.33156F;
            NumberofRoom.HeaderText = "Number of Room";
            NumberofRoom.MinimumWidth = 6;
            NumberofRoom.Name = "NumberofRoom";
            // 
            // Status
            // 
            Status.FillWeight = 94.33156F;
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            // 
            // Addroombutton
            // 
            Addroombutton.BorderRadius = 10;
            Addroombutton.CustomizableEdges = customizableEdges5;
            Addroombutton.DisabledState.BorderColor = Color.DarkGray;
            Addroombutton.DisabledState.CustomBorderColor = Color.DarkGray;
            Addroombutton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Addroombutton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Addroombutton.FillColor = Color.FromArgb(55, 73, 7);
            Addroombutton.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Addroombutton.ForeColor = Color.White;
            Addroombutton.Location = new Point(1165, 37);
            Addroombutton.Name = "Addroombutton";
            Addroombutton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Addroombutton.Size = new Size(200, 45);
            Addroombutton.TabIndex = 9;
            Addroombutton.Text = "Add Room";
            Addroombutton.Click += Addroombutton_Click;
            // 
            // Suitestext
            // 
            Suitestext.AutoSize = true;
            Suitestext.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Suitestext.Location = new Point(106, 45);
            Suitestext.Name = "Suitestext";
            Suitestext.Size = new Size(71, 23);
            Suitestext.TabIndex = 2;
            Suitestext.Text = "Suites ";
            // 
            // backicon
            // 
            //backicon.Image = Properties.Resources.icons8_back_64;
            backicon.Location = new Point(48, 37);
            backicon.Name = "backicon";
            backicon.Size = new Size(38, 38);
            backicon.SizeMode = PictureBoxSizeMode.Zoom;
            backicon.TabIndex = 1;
            backicon.TabStop = false;
            backicon.Click += backicon_Click;
            // 
            // upperradius
            // 
            upperradius.BorderRadius = 10;
            upperradius.TargetControl = suitesroomgridview;
            // 
            // guna2Elipsepanelinsuites
            // 
            guna2Elipsepanelinsuites.BorderRadius = 10;
            guna2Elipsepanelinsuites.TargetControl = panelwhitebgforsuites;
            // 
            // SuitesRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1440, 900);
            Controls.Add(Addroomicon);
            Controls.Add(transparentpanelsuites);
            Controls.Add(headersuites);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SuitesRoom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SuitesRoom";
            headersuites.ResumeLayout(false);
            headersuites.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)locationpic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Addroomicon.ResumeLayout(false);
            Addroomicon.PerformLayout();
            panelwhitebgforsuites.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)suitesroomgridview).EndInit();
            ((System.ComponentModel.ISupportInitialize)backicon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel headersuites;
        private Panel transparentpanelsuites;
        private PictureBox pictureBox1;
        private PictureBox locationpic;
        private Label QCTEXT;
        private Label philtext;
        private Panel Addroomicon;
        private PictureBox backicon;
        private Label Suitestext;
        private Guna.UI2.WinForms.Guna2Button Addroombutton;
        private Panel panelwhitebgforsuites;
        private Guna.UI2.WinForms.Guna2DataGridView suitesroomgridview;
        private Guna.UI2.WinForms.Guna2Elipse upperradius;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipsepanelinsuites;
        private Guna.UI2.WinForms.Guna2Button Deletebuttondeluxe;
        private Guna.UI2.WinForms.Guna2Button Editbuttonsuite;
        private DataGridViewTextBoxColumn Room_Number;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn HasJacuzzi;
        private DataGridViewTextBoxColumn NumberofRoom;
        private DataGridViewTextBoxColumn Status;
    }
}