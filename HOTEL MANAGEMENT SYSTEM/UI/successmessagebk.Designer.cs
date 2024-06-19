namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    partial class successmessagebk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(successmessagebk));
            checkmark = new PictureBox();
            LABELBOOK = new Label();
            ((System.ComponentModel.ISupportInitialize)checkmark).BeginInit();
            SuspendLayout();
            // 
            // checkmark
            // 
            checkmark.Image = (Image)resources.GetObject("checkmark.Image");
            checkmark.Location = new Point(159, 28);
            checkmark.Name = "checkmark";
            checkmark.Size = new Size(145, 139);
            checkmark.SizeMode = PictureBoxSizeMode.Zoom;
            checkmark.TabIndex = 0;
            checkmark.TabStop = false;
            // 
            // LABELBOOK
            // 
            LABELBOOK.AutoSize = true;
            LABELBOOK.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LABELBOOK.Location = new Point(126, 189);
            LABELBOOK.Name = "LABELBOOK";
            LABELBOOK.Size = new Size(217, 23);
            LABELBOOK.TabIndex = 1;
            LABELBOOK.Text = "Successfully Booked!";
            // 
            // successmessagebk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(468, 292);
            Controls.Add(LABELBOOK);
            Controls.Add(checkmark);
            FormBorderStyle = FormBorderStyle.None;
            Name = "successmessagebk";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "successmessagebk";
            Load += successmessagebk_Load;
            ((System.ComponentModel.ISupportInitialize)checkmark).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox checkmark;
        private Label LABELBOOK;
    }
}