namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    partial class DeletePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletePassword));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            confirmbutton = new Guna.UI2.WinForms.Guna2Button();
            PasswordTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            label2 = new Label();
            NavBack = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            guna2Panel1.SuspendLayout();
            guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NavBack).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BackgroundImage = (Image)resources.GetObject("guna2Panel1.BackgroundImage");
            guna2Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            guna2Panel1.BorderColor = Color.Gray;
            guna2Panel1.BorderRadius = 20;
            guna2Panel1.Controls.Add(confirmbutton);
            guna2Panel1.Controls.Add(PasswordTextbox);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(guna2Panel2);
            guna2Panel1.Controls.Add(NavBack);
            guna2Panel1.CustomizableEdges = customizableEdges8;
            guna2Panel1.Location = new Point(49, 25);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges9;
            guna2Panel1.Size = new Size(678, 412);
            guna2Panel1.TabIndex = 4;
            // 
            // confirmbutton
            // 
            confirmbutton.BorderRadius = 10;
            confirmbutton.CustomizableEdges = customizableEdges1;
            confirmbutton.DisabledState.BorderColor = Color.DarkGray;
            confirmbutton.DisabledState.CustomBorderColor = Color.DarkGray;
            confirmbutton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            confirmbutton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            confirmbutton.FillColor = Color.FromArgb(0, 64, 0);
            confirmbutton.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmbutton.ForeColor = Color.White;
            confirmbutton.Location = new Point(225, 278);
            confirmbutton.Name = "confirmbutton";
            confirmbutton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            confirmbutton.Size = new Size(225, 40);
            confirmbutton.TabIndex = 45;
            confirmbutton.Text = "Confirm";
            // 
            // PasswordTextbox
            // 
            PasswordTextbox.BorderRadius = 10;
            PasswordTextbox.CustomizableEdges = customizableEdges3;
            PasswordTextbox.DefaultText = "";
            PasswordTextbox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PasswordTextbox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PasswordTextbox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PasswordTextbox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PasswordTextbox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PasswordTextbox.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTextbox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PasswordTextbox.Location = new Point(161, 200);
            PasswordTextbox.Margin = new Padding(3, 4, 3, 4);
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.PasswordChar = '\0';
            PasswordTextbox.PlaceholderText = "Password";
            PasswordTextbox.SelectedText = "";
            PasswordTextbox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            PasswordTextbox.Size = new Size(389, 46);
            PasswordTextbox.TabIndex = 44;
            PasswordTextbox.TextChanged += guna2TextBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(204, 147);
            label1.Name = "label1";
            label1.Size = new Size(277, 23);
            label1.TabIndex = 43;
            label1.Text = "Please enter your password";
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = Color.FromArgb(13, 22, 29);
            guna2Panel2.Controls.Add(label2);
            guna2Panel2.CustomizableEdges = customizableEdges5;
            guna2Panel2.Location = new Point(114, 78);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel2.Size = new Size(454, 31);
            guna2Panel2.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(157, 7);
            label2.Name = "label2";
            label2.Size = new Size(131, 18);
            label2.TabIndex = 0;
            label2.Text = "Confirm deletion";
            // 
            // NavBack
            // 
            NavBack.BackgroundImageLayout = ImageLayout.Stretch;
            NavBack.Image = (Image)resources.GetObject("NavBack.Image");
            NavBack.ImageRotate = 0F;
            NavBack.Location = new Point(41, 43);
            NavBack.Name = "NavBack";
            NavBack.ShadowDecoration.CustomizableEdges = customizableEdges7;
            NavBack.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            NavBack.Size = new Size(44, 31);
            NavBack.TabIndex = 34;
            NavBack.TabStop = false;
            // 
            // DeletePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 463);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeletePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeletePassword";
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NavBack).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTextbox;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Label label2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox NavBack;
        private Guna.UI2.WinForms.Guna2Button confirmbutton;
    }
}