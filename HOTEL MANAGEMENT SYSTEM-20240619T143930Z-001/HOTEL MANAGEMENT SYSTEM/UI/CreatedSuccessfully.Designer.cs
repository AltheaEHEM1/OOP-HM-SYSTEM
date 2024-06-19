namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    partial class CreatedSuccessfully
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
            Message = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            SuspendLayout();
            // 
            // Message
            // 
            Message.AutoSize = true;
            Message.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Message.ForeColor = SystemColors.Window;
            Message.Location = new Point(100, 28);
            Message.Name = "Message";
            Message.Size = new Size(259, 21);
            Message.TabIndex = 15;
            Message.Text = "Account successfully created!";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // CreatedSuccessfully
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(378, 76);
            Controls.Add(Message);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreatedSuccessfully";
            Text = "CreatedSuccessfully";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Message;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}