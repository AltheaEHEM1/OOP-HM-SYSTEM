namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    partial class Standardroom
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            philtext = new Label();
            QCTEXT = new Label();
            locationpic = new PictureBox();
            pictureBox1 = new PictureBox();
            panelfortransparent = new Panel();
            panelbgwhite = new Panel();
            deletebuttonstandard = new Guna.UI2.WinForms.Guna2Button();
            panelforgridview = new Guna.UI2.WinForms.Guna2GradientPanel();
            Standardroomgridview = new Guna.UI2.WinForms.Guna2DataGridView();
            Room_Number = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Occupancy_Limit = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Editbuttonstandard = new Guna.UI2.WinForms.Guna2Button();
            Addroomicon = new Guna.UI2.WinForms.Guna2Button();
            standardtext = new Label();
            backicon = new PictureBox();
            radiusup = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipseinpanel = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)locationpic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelbgwhite.SuspendLayout();
            panelforgridview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Standardroomgridview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backicon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(13, 22, 29);
            panel1.Controls.Add(philtext);
            panel1.Controls.Add(QCTEXT);
            panel1.Controls.Add(locationpic);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1440, 141);
            panel1.TabIndex = 0;
            // 
            // philtext
            // 
            philtext.AutoSize = true;
            philtext.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            philtext.ForeColor = Color.White;
            philtext.Location = new Point(55, 99);
            philtext.Name = "philtext";
            philtext.Size = new Size(84, 20);
            philtext.TabIndex = 14;
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
            QCTEXT.TabIndex = 13;
            QCTEXT.Text = "Quezon City.";
            // 
            // locationpic
            // 
            locationpic.Image = Properties.Resources.icons8_location_24;
            locationpic.Location = new Point(55, 47);
            locationpic.Name = "locationpic";
            locationpic.Size = new Size(31, 29);
            locationpic.TabIndex = 12;
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
            // panelfortransparent
            // 
            panelfortransparent.BackColor = Color.DimGray;
            panelfortransparent.Dock = DockStyle.Top;
            panelfortransparent.Location = new Point(0, 141);
            panelfortransparent.Name = "panelfortransparent";
            panelfortransparent.Size = new Size(1440, 66);
            panelfortransparent.TabIndex = 1;
            panelfortransparent.Paint += panelfortransparent_Paint;
            // 
            // panelbgwhite
            // 
            panelbgwhite.BackColor = Color.White;
            panelbgwhite.Controls.Add(deletebuttonstandard);
            panelbgwhite.Controls.Add(panelforgridview);
            panelbgwhite.Controls.Add(Editbuttonstandard);
            panelbgwhite.Controls.Add(Addroomicon);
            panelbgwhite.Controls.Add(standardtext);
            panelbgwhite.Controls.Add(backicon);
            panelbgwhite.Dock = DockStyle.Fill;
            panelbgwhite.Location = new Point(0, 207);
            panelbgwhite.Name = "panelbgwhite";
            panelbgwhite.Size = new Size(1440, 693);
            panelbgwhite.TabIndex = 2;
            // 
            // deletebuttonstandard
            // 
            deletebuttonstandard.BorderRadius = 10;
            deletebuttonstandard.CustomizableEdges = customizableEdges1;
            deletebuttonstandard.DisabledState.BorderColor = Color.DarkGray;
            deletebuttonstandard.DisabledState.CustomBorderColor = Color.DarkGray;
            deletebuttonstandard.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            deletebuttonstandard.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            deletebuttonstandard.FillColor = Color.FromArgb(126, 6, 6);
            deletebuttonstandard.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deletebuttonstandard.ForeColor = Color.White;
            deletebuttonstandard.Location = new Point(1165, 599);
            deletebuttonstandard.Name = "deletebuttonstandard";
            deletebuttonstandard.ShadowDecoration.CustomizableEdges = customizableEdges2;
            deletebuttonstandard.Size = new Size(133, 45);
            deletebuttonstandard.TabIndex = 11;
            deletebuttonstandard.Text = "Delete";
            deletebuttonstandard.Click += deletebuttonstandard_Click;
            // 
            // panelforgridview
            // 
            panelforgridview.BorderRadius = 10;
            panelforgridview.Controls.Add(Standardroomgridview);
            panelforgridview.CustomizableEdges = customizableEdges3;
            panelforgridview.Location = new Point(55, 88);
            panelforgridview.Name = "panelforgridview";
            panelforgridview.ShadowDecoration.CustomizableEdges = customizableEdges4;
            panelforgridview.Size = new Size(1310, 505);
            panelforgridview.TabIndex = 9;
            // 
            // Standardroomgridview
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(13, 22, 29);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Standardroomgridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(13, 22, 29);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            Standardroomgridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            Standardroomgridview.ColumnHeadersHeight = 50;
            Standardroomgridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            Standardroomgridview.Columns.AddRange(new DataGridViewColumn[] { Room_Number, Price, Occupancy_Limit, Status });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            Standardroomgridview.DefaultCellStyle = dataGridViewCellStyle3;
            Standardroomgridview.Dock = DockStyle.Fill;
            Standardroomgridview.Enabled = false;
            Standardroomgridview.GridColor = Color.FromArgb(231, 229, 255);
            Standardroomgridview.Location = new Point(0, 0);
            Standardroomgridview.Name = "Standardroomgridview";
            Standardroomgridview.RowHeadersVisible = false;
            Standardroomgridview.RowHeadersWidth = 51;
            Standardroomgridview.Size = new Size(1310, 505);
            Standardroomgridview.TabIndex = 0;
            Standardroomgridview.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            Standardroomgridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            Standardroomgridview.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            Standardroomgridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            Standardroomgridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            Standardroomgridview.ThemeStyle.BackColor = Color.White;
            Standardroomgridview.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            Standardroomgridview.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            Standardroomgridview.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            Standardroomgridview.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            Standardroomgridview.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            Standardroomgridview.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            Standardroomgridview.ThemeStyle.HeaderStyle.Height = 50;
            Standardroomgridview.ThemeStyle.ReadOnly = false;
            Standardroomgridview.ThemeStyle.RowsStyle.BackColor = Color.White;
            Standardroomgridview.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Standardroomgridview.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            Standardroomgridview.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            Standardroomgridview.ThemeStyle.RowsStyle.Height = 29;
            Standardroomgridview.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            Standardroomgridview.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // Room_Number
            // 
            Room_Number.FillWeight = 91.5775452F;
            Room_Number.HeaderText = "Room Number";
            Room_Number.MinimumWidth = 6;
            Room_Number.Name = "Room_Number";
            // 
            // Price
            // 
            Price.FillWeight = 91.5775452F;
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            // 
            // Occupancy_Limit
            // 
            Occupancy_Limit.FillWeight = 91.5775452F;
            Occupancy_Limit.HeaderText = "Occupancy Limit";
            Occupancy_Limit.MinimumWidth = 6;
            Occupancy_Limit.Name = "Occupancy_Limit";
            // 
            // Status
            // 
            Status.FillWeight = 91.5775452F;
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            // 
            // Editbuttonstandard
            // 
            Editbuttonstandard.BorderRadius = 10;
            Editbuttonstandard.CustomizableEdges = customizableEdges5;
            Editbuttonstandard.DisabledState.BorderColor = Color.DarkGray;
            Editbuttonstandard.DisabledState.CustomBorderColor = Color.DarkGray;
            Editbuttonstandard.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Editbuttonstandard.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Editbuttonstandard.FillColor = Color.FromArgb(214, 164, 38);
            Editbuttonstandard.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Editbuttonstandard.ForeColor = Color.White;
            Editbuttonstandard.Location = new Point(1020, 599);
            Editbuttonstandard.Name = "Editbuttonstandard";
            Editbuttonstandard.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Editbuttonstandard.Size = new Size(133, 45);
            Editbuttonstandard.TabIndex = 10;
            Editbuttonstandard.Text = "Edit";
            Editbuttonstandard.Click += Editbuttonstandard_Click;
            // 
            // Addroomicon
            // 
            Addroomicon.BorderRadius = 10;
            Addroomicon.CustomizableEdges = customizableEdges7;
            Addroomicon.DisabledState.BorderColor = Color.DarkGray;
            Addroomicon.DisabledState.CustomBorderColor = Color.DarkGray;
            Addroomicon.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Addroomicon.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Addroomicon.FillColor = Color.FromArgb(55, 73, 7);
            Addroomicon.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Addroomicon.ForeColor = Color.White;
            Addroomicon.Location = new Point(1165, 37);
            Addroomicon.Name = "Addroomicon";
            Addroomicon.ShadowDecoration.CustomizableEdges = customizableEdges8;
            Addroomicon.Size = new Size(200, 45);
            Addroomicon.TabIndex = 8;
            Addroomicon.Text = "Add Room";
            Addroomicon.Click += Addroomicon_Click;
            // 
            // standardtext
            // 
            standardtext.AutoSize = true;
            standardtext.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            standardtext.Location = new Point(106, 45);
            standardtext.Name = "standardtext";
            standardtext.Size = new Size(168, 23);
            standardtext.TabIndex = 2;
            standardtext.Text = "Standard Rooms";
            // 
            // backicon
            // 
            backicon.Image = Properties.Resources.icons8_back_64;
            backicon.Location = new Point(48, 37);
            backicon.Name = "backicon";
            backicon.Size = new Size(38, 38);
            backicon.SizeMode = PictureBoxSizeMode.Zoom;
            backicon.TabIndex = 1;
            backicon.TabStop = false;
            backicon.Click += backicon_Click;
            // 
            // radiusup
            // 
            radiusup.BorderRadius = 10;
            radiusup.TargetControl = Standardroomgridview;
            // 
            // guna2Elipseinpanel
            // 
            guna2Elipseinpanel.BorderRadius = 10;
            guna2Elipseinpanel.TargetControl = panelforgridview;
            // 
            // Standardroom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1440, 900);
            Controls.Add(panelbgwhite);
            Controls.Add(panelfortransparent);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Standardroom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Standardroom";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)locationpic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelbgwhite.ResumeLayout(false);
            panelbgwhite.PerformLayout();
            panelforgridview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Standardroomgridview).EndInit();
            ((System.ComponentModel.ISupportInitialize)backicon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox locationpic;
        private Label QCTEXT;
        private Label philtext;
        private Panel panelfortransparent;
        private Panel panelbgwhite;
        private PictureBox backicon;
        private Label standardtext;
        private Guna.UI2.WinForms.Guna2Button Addroomicon;
        private Guna.UI2.WinForms.Guna2GradientPanel panelforgridview;
        private Guna.UI2.WinForms.Guna2DataGridView Standardroomgridview;
        private Guna.UI2.WinForms.Guna2Elipse radiusup;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipseinpanel;
        private Guna.UI2.WinForms.Guna2Button Editbuttonstandard;
        private Guna.UI2.WinForms.Guna2Button deletebuttonstandard;
        private DataGridViewTextBoxColumn Room_Number;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Occupancy_Limit;
        private DataGridViewTextBoxColumn Status;
    }
}