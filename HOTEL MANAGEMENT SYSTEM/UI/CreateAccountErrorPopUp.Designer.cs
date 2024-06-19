namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    partial class CreateAccountErrorPopUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccountErrorPopUp));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ErrorLogo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ErrorMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)ErrorLogo).BeginInit();
            SuspendLayout();
            // 
            // ErrorLogo
            // 
            ErrorLogo.BackgroundImage = (Image)resources.GetObject("ErrorLogo.BackgroundImage");
            ErrorLogo.BackgroundImageLayout = ImageLayout.Stretch;
            ErrorLogo.FillColor = Color.Transparent;
            ErrorLogo.ImageRotate = 0F;
            ErrorLogo.Location = new Point(187, 45);
            ErrorLogo.Name = "ErrorLogo";
            ErrorLogo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ErrorLogo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            ErrorLogo.Size = new Size(127, 134);
            ErrorLogo.TabIndex = 3;
            ErrorLogo.TabStop = false;
            // 
            // ErrorMessage
            // 
            ErrorMessage.AutoSize = true;
            ErrorMessage.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ErrorMessage.Location = new Point(124, 194);
            ErrorMessage.Name = "ErrorMessage";
            ErrorMessage.Size = new Size(252, 22);
            ErrorMessage.TabIndex = 4;
            ErrorMessage.Text = "Error creating your account";
            ErrorMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CreateAccountErrorPopUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 300);
            Controls.Add(ErrorMessage);
            Controls.Add(ErrorLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateAccountErrorPopUp";
            Text = "CreateAccountErrorPopUp";
            ((System.ComponentModel.ISupportInitialize)ErrorLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox ErrorLogo;
        private Label ErrorMessage;
    }
}