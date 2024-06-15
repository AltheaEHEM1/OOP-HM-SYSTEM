namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    partial class ProfilePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilePage));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            ChangePasswordButton = new Guna.UI2.WinForms.Guna2Button();
            HeaderBox = new Guna.UI2.WinForms.Guna2ResizeBox();
            ProfilePictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            Panel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            BackButton = new Guna.UI2.WinForms.Guna2CircleButton();
            EditProfileButton = new Guna.UI2.WinForms.Guna2Button();
            Name = new Label();
            Email = new Label();
            label3 = new Label();
            label4 = new Label();
            WorkIcon = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProfilePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WorkIcon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(WorkIcon);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Email);
            panel1.Controls.Add(Name);
            panel1.Controls.Add(ChangePasswordButton);
            panel1.Controls.Add(HeaderBox);
            panel1.Controls.Add(ProfilePictureBox);
            panel1.Controls.Add(Panel2);
            panel1.Controls.Add(BackButton);
            panel1.Controls.Add(EditProfileButton);
            panel1.Location = new Point(70, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 750);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // ChangePasswordButton
            // 
            ChangePasswordButton.BorderColor = Color.Transparent;
            ChangePasswordButton.BorderRadius = 10;
            ChangePasswordButton.CustomizableEdges = customizableEdges2;
            ChangePasswordButton.DisabledState.BorderColor = Color.DarkGray;
            ChangePasswordButton.DisabledState.CustomBorderColor = Color.DarkGray;
            ChangePasswordButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ChangePasswordButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ChangePasswordButton.FillColor = Color.FromArgb(13, 22, 29);
            ChangePasswordButton.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ChangePasswordButton.ForeColor = Color.White;
            ChangePasswordButton.Image = (Image)resources.GetObject("ChangePasswordButton.Image");
            ChangePasswordButton.ImageSize = new Size(20, 30);
            ChangePasswordButton.Location = new Point(1051, 653);
            ChangePasswordButton.Name = "ChangePasswordButton";
            ChangePasswordButton.ShadowDecoration.CustomizableEdges = customizableEdges3;
            ChangePasswordButton.Size = new Size(210, 40);
            ChangePasswordButton.TabIndex = 11;
            ChangePasswordButton.Text = "Change Password";
            ChangePasswordButton.Click += ChangePasswordButton_Click;
            // 
            // HeaderBox
            // 
            HeaderBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            HeaderBox.BackColor = Color.FromArgb(61, 68, 74);
            HeaderBox.FillColor = Color.Transparent;
            HeaderBox.ForeColor = Color.Black;
            HeaderBox.Location = new Point(41, 501);
            HeaderBox.Name = "HeaderBox";
            HeaderBox.Size = new Size(1220, 50);
            HeaderBox.TabIndex = 7;
            HeaderBox.Click += HeaderBox_Click;
            // 
            // ProfilePictureBox
            // 
            ProfilePictureBox.BackColor = Color.Transparent;
            ProfilePictureBox.Image = (Image)resources.GetObject("ProfilePictureBox.Image");
            ProfilePictureBox.ImageRotate = 0F;
            ProfilePictureBox.Location = new Point(114, 307);
            ProfilePictureBox.Name = "ProfilePictureBox";
            ProfilePictureBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ProfilePictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            ProfilePictureBox.Size = new Size(220, 195);
            ProfilePictureBox.TabIndex = 0;
            ProfilePictureBox.TabStop = false;
            ProfilePictureBox.Click += ProfilePictureBox_Click;
            // 
            // Panel2
            // 
            Panel2.BorderColor = Color.Black;
            Panel2.BorderRadius = 20;
            Panel2.BorderThickness = 1;
            Panel2.CustomizableEdges = customizableEdges5;
            Panel2.Location = new Point(41, 105);
            Panel2.Name = "Panel2";
            Panel2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Panel2.Size = new Size(1220, 270);
            Panel2.TabIndex = 2;
            Panel2.Paint += Panel2_Paint;
            // 
            // BackButton
            // 
            BackButton.DisabledState.BorderColor = Color.DarkGray;
            BackButton.DisabledState.CustomBorderColor = Color.DarkGray;
            BackButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BackButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BackButton.FillColor = Color.Transparent;
            BackButton.Font = new Font("Segoe UI", 9F);
            BackButton.ForeColor = Color.White;
            BackButton.Image = (Image)resources.GetObject("BackButton.Image");
            BackButton.ImageSize = new Size(70, 60);
            BackButton.Location = new Point(41, 26);
            BackButton.Name = "BackButton";
            BackButton.ShadowDecoration.CustomizableEdges = customizableEdges7;
            BackButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            BackButton.Size = new Size(49, 52);
            BackButton.TabIndex = 1;
            BackButton.Click += BackButton_Click;
            // 
            // EditProfileButton
            // 
            EditProfileButton.BorderColor = Color.Transparent;
            EditProfileButton.BorderRadius = 10;
            EditProfileButton.CustomizableEdges = customizableEdges8;
            EditProfileButton.DisabledState.BorderColor = Color.DarkGray;
            EditProfileButton.DisabledState.CustomBorderColor = Color.DarkGray;
            EditProfileButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            EditProfileButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            EditProfileButton.FillColor = Color.FromArgb(13, 22, 29);
            EditProfileButton.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditProfileButton.ForeColor = Color.White;
            EditProfileButton.Image = (Image)resources.GetObject("EditProfileButton.Image");
            EditProfileButton.Location = new Point(1051, 37);
            EditProfileButton.Name = "EditProfileButton";
            EditProfileButton.ShadowDecoration.CustomizableEdges = customizableEdges9;
            EditProfileButton.Size = new Size(210, 40);
            EditProfileButton.TabIndex = 0;
            EditProfileButton.Text = "Edit Profile";
            EditProfileButton.Click += EditProfileButton_Click;
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name.ForeColor = Color.Black;
            Name.Location = new Point(343, 394);
            Name.Name = "Name";
            Name.Size = new Size(280, 28);
            Name.TabIndex = 0;
            Name.Text = "Miyuki Mharie Parocha";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Email.ForeColor = Color.Black;
            Email.Location = new Point(343, 422);
            Email.Name = "Email";
            Email.Size = new Size(207, 21);
            Email.TabIndex = 16;
            Email.Text = "miyukimharie@gmail.com";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(343, 445);
            label3.Name = "label3";
            label3.Size = new Size(106, 24);
            label3.TabIndex = 0;
            label3.Text = "05070401";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(892, 394);
            label4.Name = "label4";
            label4.Size = new Size(223, 25);
            label4.TabIndex = 0;
            label4.Text = "Front Desk Employee";
            // 
            // WorkIcon
            // 
            WorkIcon.BackgroundImage = (Image)resources.GetObject("WorkIcon.BackgroundImage");
            WorkIcon.BackgroundImageLayout = ImageLayout.Stretch;
            WorkIcon.FillColor = Color.Transparent;
            WorkIcon.ImageRotate = 0F;
            WorkIcon.Location = new Point(861, 387);
            WorkIcon.Name = "WorkIcon";
            WorkIcon.ShadowDecoration.CustomizableEdges = customizableEdges1;
            WorkIcon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            WorkIcon.Size = new Size(29, 36);
            WorkIcon.TabIndex = 19;
            WorkIcon.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(61, 68, 74);
            label5.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(343, 514);
            label5.Name = "label5";
            label5.Size = new Size(107, 25);
            label5.TabIndex = 0;
            label5.Text = "Schedule";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(343, 564);
            label6.Name = "label6";
            label6.Size = new Size(88, 22);
            label6.TabIndex = 0;
            label6.Text = "Monday";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(343, 593);
            label7.Name = "label7";
            label7.Size = new Size(185, 22);
            label7.TabIndex = 22;
            label7.Text = "9:00 am to 6:00 pm";
            // 
            // ProfilePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1440, 900);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProfilePage";
            Load += ProfilePage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProfilePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)WorkIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button EditProfileButton;
        private Guna.UI2.WinForms.Guna2CircleButton BackButton;
        private Guna.UI2.WinForms.Guna2GradientPanel Panel2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ProfilePictureBox;
        private Guna.UI2.WinForms.Guna2ResizeBox HeaderBox;
        private Guna.UI2.WinForms.Guna2Button ChangePasswordButton;
        private Guna.UI2.WinForms.Guna2TextBox DaySchedule;
        private Guna.UI2.WinForms.Guna2TextBox ScheduleHeader;
        private Guna.UI2.WinForms.Guna2TextBox PositionProfile;
        private Guna.UI2.WinForms.Guna2TextBox EmailProfile;
        private Guna.UI2.WinForms.Guna2TextBox TimeSchedule;
        private Guna.UI2.WinForms.Guna2TextBox IDNumberProfile;
        private Guna.UI2.WinForms.Guna2TextBox NameProfile;
        private Label label7;
        private Label label6;
        private Label label5;
        private Guna.UI2.WinForms.Guna2CirclePictureBox WorkIcon;
        private Label label4;
        private Label label3;
        private Label Email;
        private Label Name;
    }
}