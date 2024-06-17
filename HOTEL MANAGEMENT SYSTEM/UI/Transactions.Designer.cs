namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    partial class Transactions
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transactions));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            HeaderPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            TimeHeader = new Label();
            DateHeader = new Label();
            TransactionTypeHeader = new Label();
            TransactionNumberHeader = new Label();
            HeaderText = new Label();
            SearchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            Time = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            TransactionType = new DataGridViewTextBoxColumn();
            TransactionNumber = new DataGridViewTextBoxColumn();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DateTimePicker
            // 
            DateTimePicker.BorderColor = Color.FromArgb(13, 22, 29);
            DateTimePicker.BorderRadius = 10;
            DateTimePicker.Checked = true;
            DateTimePicker.CustomizableEdges = customizableEdges1;
            DateTimePicker.FillColor = Color.FromArgb(13, 22, 29);
            DateTimePicker.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateTimePicker.ForeColor = Color.White;
            DateTimePicker.Format = DateTimePickerFormat.Short;
            DateTimePicker.Location = new Point(55, 32);
            DateTimePicker.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            DateTimePicker.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            DateTimePicker.Name = "DateTimePicker";
            DateTimePicker.ShadowDecoration.CustomizableEdges = customizableEdges2;
            DateTimePicker.Size = new Size(208, 42);
            DateTimePicker.TabIndex = 0;
            DateTimePicker.TextAlign = HorizontalAlignment.Center;
            DateTimePicker.Value = new DateTime(2024, 6, 15, 8, 24, 55, 570);
            // 
            // HeaderPanel
            // 
            HeaderPanel.BorderColor = Color.FromArgb(13, 22, 29);
            HeaderPanel.BorderRadius = 10;
            HeaderPanel.BorderThickness = 1;
            HeaderPanel.Controls.Add(TimeHeader);
            HeaderPanel.Controls.Add(DateHeader);
            HeaderPanel.Controls.Add(TransactionTypeHeader);
            HeaderPanel.Controls.Add(TransactionNumberHeader);
            HeaderPanel.CustomizableEdges = customizableEdges3;
            HeaderPanel.FillColor = Color.FromArgb(13, 22, 29);
            HeaderPanel.FillColor2 = Color.FromArgb(13, 22, 29);
            HeaderPanel.Location = new Point(142, 137);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            HeaderPanel.Size = new Size(1117, 48);
            HeaderPanel.TabIndex = 2;
            // 
            // TimeHeader
            // 
            TimeHeader.AutoSize = true;
            TimeHeader.BackColor = Color.Transparent;
            TimeHeader.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TimeHeader.ForeColor = Color.White;
            TimeHeader.Location = new Point(1000, 15);
            TimeHeader.Name = "TimeHeader";
            TimeHeader.Size = new Size(46, 19);
            TimeHeader.TabIndex = 3;
            TimeHeader.Text = "Time";
            // 
            // DateHeader
            // 
            DateHeader.AutoSize = true;
            DateHeader.BackColor = Color.Transparent;
            DateHeader.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateHeader.ForeColor = Color.White;
            DateHeader.Location = new Point(725, 15);
            DateHeader.Name = "DateHeader";
            DateHeader.Size = new Size(45, 19);
            DateHeader.TabIndex = 2;
            DateHeader.Text = "Date";
            // 
            // TransactionTypeHeader
            // 
            TransactionTypeHeader.AutoSize = true;
            TransactionTypeHeader.BackColor = Color.Transparent;
            TransactionTypeHeader.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TransactionTypeHeader.ForeColor = Color.White;
            TransactionTypeHeader.Location = new Point(356, 15);
            TransactionTypeHeader.Name = "TransactionTypeHeader";
            TransactionTypeHeader.Size = new Size(138, 19);
            TransactionTypeHeader.TabIndex = 1;
            TransactionTypeHeader.Text = "Transaction Type";
            // 
            // TransactionNumberHeader
            // 
            TransactionNumberHeader.AutoSize = true;
            TransactionNumberHeader.BackColor = Color.Transparent;
            TransactionNumberHeader.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TransactionNumberHeader.ForeColor = Color.White;
            TransactionNumberHeader.Location = new Point(31, 15);
            TransactionNumberHeader.Name = "TransactionNumberHeader";
            TransactionNumberHeader.Size = new Size(127, 19);
            TransactionNumberHeader.TabIndex = 0;
            TransactionNumberHeader.Text = "Transaction No.";
            // 
            // HeaderText
            // 
            HeaderText.AutoSize = true;
            HeaderText.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeaderText.Location = new Point(613, 88);
            HeaderText.Name = "HeaderText";
            HeaderText.Size = new Size(174, 32);
            HeaderText.TabIndex = 3;
            HeaderText.Text = "Transactions";
            // 
            // SearchTextBox
            // 
            SearchTextBox.BorderColor = Color.Black;
            SearchTextBox.BorderRadius = 15;
            SearchTextBox.CustomizableEdges = customizableEdges5;
            SearchTextBox.DefaultText = "";
            SearchTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            SearchTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            SearchTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            SearchTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            SearchTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            SearchTextBox.Font = new Font("Segoe UI", 9F);
            SearchTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            SearchTextBox.IconLeft = (Image)resources.GetObject("SearchTextBox.IconLeft");
            SearchTextBox.Location = new Point(969, 44);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.PasswordChar = '\0';
            SearchTextBox.PlaceholderForeColor = Color.Gray;
            SearchTextBox.PlaceholderText = "Search by guest, reservation";
            SearchTextBox.SelectedText = "";
            SearchTextBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            SearchTextBox.Size = new Size(327, 35);
            SearchTextBox.TabIndex = 6;
            // 
            // Time
            // 
            Time.HeaderText = "Time";
            Time.Name = "Time";
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
            // 
            // TransactionType
            // 
            TransactionType.HeaderText = "Transaction Type";
            TransactionType.Name = "TransactionType";
            // 
            // TransactionNumber
            // 
            TransactionNumber.HeaderText = "Transaction No.";
            TransactionNumber.Name = "TransactionNumber";
            // 
            // guna2DataGridView1
            // 
            guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 240, 240);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(213, 171, 97);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(240, 240, 240);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(240, 240, 240);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(240, 240, 240);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 17;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.Columns.AddRange(new DataGridViewColumn[] { TransactionNumber, TransactionType, Date, Time });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(213, 171, 97);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.White;
            guna2DataGridView1.Location = new Point(142, 191);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowTemplate.Height = 40;
            guna2DataGridView1.ScrollBars = ScrollBars.Vertical;
            guna2DataGridView1.Size = new Size(1116, 289);
            guna2DataGridView1.TabIndex = 7;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(240, 240, 240);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.FromArgb(240, 240, 240);
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 17;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 40;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(213, 171, 97);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            // 
            // Transactions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2DataGridView1);
            Controls.Add(SearchTextBox);
            Controls.Add(HeaderText);
            Controls.Add(HeaderPanel);
            Controls.Add(DateTimePicker);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Transactions";
            Size = new Size(1400, 509);
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePicker;
        private Guna.UI2.WinForms.Guna2GradientPanel HeaderPanel;
        private Label HeaderText;
        private Label TransactionTypeHeader;
        private Label TransactionNumberHeader;
        private Label TimeHeader;
        private Label DateHeader;
        private Guna.UI2.WinForms.Guna2TextBox SearchTextBox;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn TransactionType;
        private DataGridViewTextBoxColumn TransactionNumber;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
    }
}
