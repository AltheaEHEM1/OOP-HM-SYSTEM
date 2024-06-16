namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    partial class Edit
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
            Editroom = new Label();
            SuspendLayout();
            // 
            // Editroom
            // 
            Editroom.AutoSize = true;
            Editroom.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            Editroom.Location = new Point(286, 80);
            Editroom.Name = "Editroom";
            Editroom.Size = new Size(228, 27);
            Editroom.TabIndex = 0;
            Editroom.Text = "Edit (room number)";
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Editroom);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Edit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Editroom;
    }
}