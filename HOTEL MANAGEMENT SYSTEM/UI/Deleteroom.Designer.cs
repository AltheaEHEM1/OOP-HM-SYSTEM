namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    partial class Deleteroom
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
            Deleteaprogramtext = new Label();
            Areyousuretext = new Label();
            SuspendLayout();
            // 
            // Deleteaprogramtext
            // 
            Deleteaprogramtext.AutoSize = true;
            Deleteaprogramtext.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Deleteaprogramtext.Location = new Point(218, 81);
            Deleteaprogramtext.Name = "Deleteaprogramtext";
            Deleteaprogramtext.Size = new Size(172, 27);
            Deleteaprogramtext.TabIndex = 0;
            Deleteaprogramtext.Text = "Delete a room";
            // 
            // Areyousuretext
            // 
            Areyousuretext.AutoSize = true;
            Areyousuretext.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Areyousuretext.Location = new Point(104, 137);
            Areyousuretext.Name = "Areyousuretext";
            Areyousuretext.Size = new Size(401, 21);
            Areyousuretext.TabIndex = 1;
            Areyousuretext.Text = "Are you sure you want to delete room number?";
            // 
            // Deleteroom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 371);
            Controls.Add(Areyousuretext);
            Controls.Add(Deleteaprogramtext);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Deleteroom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deleteroom";
            Load += Deleteroom_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Deleteaprogramtext;
        private Label Areyousuretext;
    }
}