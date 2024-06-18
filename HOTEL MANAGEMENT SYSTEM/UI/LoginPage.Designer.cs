namespace HOTEL_MANAGEMENT_SYSTEM
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            login = new Guna.UI2.WinForms.Guna2Button();
            Createacc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            label4 = new Label();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            PasswordTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            Username = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(13, 22, 29);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1646, 1200);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_location_24;
            pictureBox3.Location = new Point(59, 39);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 29);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(59, 91);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 4;
            label2.Text = "Philippines";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(59, 71);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 3;
            label1.Text = "Quezon City.";
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(login);
            panel2.Controls.Add(Createacc);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(guna2HtmlLabel1);
            panel2.Controls.Add(PasswordTextbox);
            panel2.Controls.Add(Username);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(1082, 284);
            panel2.Name = "panel2";
            panel2.Size = new Size(438, 385);
            panel2.TabIndex = 2;
            // 
            // login
            // 
            login.BackColor = Color.Transparent;
            login.BorderRadius = 15;
            login.CustomizableEdges = customizableEdges1;
            login.DisabledState.BorderColor = Color.DarkGray;
            login.DisabledState.CustomBorderColor = Color.DarkGray;
            login.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            login.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            login.FillColor = Color.FromArgb(214, 164, 38);
            login.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login.ForeColor = Color.White;
            login.Location = new Point(120, 279);
            login.Margin = new Padding(3, 4, 3, 4);
            login.Name = "login";
            login.ShadowDecoration.CustomizableEdges = customizableEdges2;
            login.Size = new Size(206, 43);
            login.TabIndex = 6;
            login.Text = "Log in";
            login.Click += login_Click;
            // 
            // Createacc
            // 
            Createacc.BackColor = Color.Transparent;
            Createacc.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Createacc.Location = new Point(262, 340);
            Createacc.Name = "Createacc";
            Createacc.Size = new Size(77, 22);
            Createacc.TabIndex = 6;
            Createacc.Text = "Click here";
            Createacc.Click += Createacc_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(91, 341);
            label4.Name = "label4";
            label4.Size = new Size(189, 20);
            label4.TabIndex = 5;
            label4.Text = "Don't have an account?";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.Black;
            guna2HtmlLabel1.Location = new Point(91, 109);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(3, 2);
            guna2HtmlLabel1.TabIndex = 4;
            guna2HtmlLabel1.Text = null;
            // 
            // PasswordTextbox
            // 
            PasswordTextbox.BackColor = Color.Transparent;
            PasswordTextbox.BorderColor = Color.FromArgb(13, 22, 29);
            PasswordTextbox.BorderRadius = 12;
            PasswordTextbox.CustomizableEdges = customizableEdges3;
            PasswordTextbox.DefaultText = "";
            PasswordTextbox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PasswordTextbox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PasswordTextbox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PasswordTextbox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PasswordTextbox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PasswordTextbox.Font = new Font("Segoe UI", 9F);
            PasswordTextbox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PasswordTextbox.IconLeft = Properties.Resources.icons8_password_24;
            PasswordTextbox.Location = new Point(85, 201);
            PasswordTextbox.Margin = new Padding(3, 5, 3, 5);
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.PasswordChar = '\0';
            PasswordTextbox.PlaceholderForeColor = Color.Gray;
            PasswordTextbox.PlaceholderText = "Password";
            PasswordTextbox.SelectedText = "";
            PasswordTextbox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            PasswordTextbox.Size = new Size(286, 43);
            PasswordTextbox.TabIndex = 2;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.BackColor = Color.Transparent;
            Username.BackgroundImageLayout = ImageLayout.Center;
            Username.BorderColor = Color.FromArgb(13, 22, 29);
            Username.BorderRadius = 12;
            Username.CustomizableEdges = customizableEdges5;
            Username.DefaultText = "";
            Username.DisabledState.BorderColor = Color.FromArgb(13, 22, 29);
            Username.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Username.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Username.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Username.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Username.Font = new Font("Segoe UI", 9F);
            Username.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Username.IconLeft = Properties.Resources.icons8_user_30__1_1;
            Username.Location = new Point(85, 135);
            Username.Margin = new Padding(3, 5, 3, 5);
            Username.Name = "Username";
            Username.PasswordChar = '\0';
            Username.PlaceholderForeColor = Color.Gray;
            Username.PlaceholderText = "Email";
            Username.SelectedText = "";
            Username.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Username.Size = new Size(286, 43);
            Username.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(120, 67);
            label3.Name = "label3";
            label3.Size = new Size(222, 20);
            label3.TabIndex = 0;
            label3.Text = "Enter your credentials below.";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(624, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(328, 167);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.FINAL__4_;
            pictureBox1.Location = new Point(0, 188);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1646, 1176);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icons8_eye_30;
            pictureBox4.Location = new Point(374, 210);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(49, 29);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.icons8_hide_30;
            pictureBox5.Location = new Point(319, 210);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(49, 29);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1646, 1102);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox3;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox Username;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTextbox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        //private Label CreateAccclick;
        private Label label4;
        private Guna.UI2.WinForms.Guna2HtmlLabel Createacc;
        private Guna.UI2.WinForms.Guna2Button login;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}
