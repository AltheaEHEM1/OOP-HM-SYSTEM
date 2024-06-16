namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    partial class addroom
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
            Addaroomtext = new Label();
            SuspendLayout();
            // 
            // Addaroomtext
            // 
            Addaroomtext.AutoSize = true;
            Addaroomtext.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            Addaroomtext.Location = new Point(227, 52);
            Addaroomtext.Name = "Addaroomtext";
            Addaroomtext.Size = new Size(145, 27);
            Addaroomtext.TabIndex = 0;
            Addaroomtext.Text = "Add a room";
            // 
            // addroom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 610);
            Controls.Add(Addaroomtext);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addroom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addroom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Addaroomtext;
    }
}