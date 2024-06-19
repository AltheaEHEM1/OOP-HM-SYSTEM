namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    partial class PaymentInfo
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Transparentcontainer = new Panel();
            whitebg = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            Cardbutton = new Guna.UI2.WinForms.Guna2Button();
            or = new Label();
            Cashbutton = new Guna.UI2.WinForms.Guna2Button();
            Whichpaymenttext = new Label();
            headerpaymentinfo = new Panel();
            Paymentmodetext = new Label();
            backicon = new PictureBox();
            Transparentcontainer.SuspendLayout();
            whitebg.SuspendLayout();
            headerpaymentinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backicon).BeginInit();
            SuspendLayout();
            // 
            // Transparentcontainer
            // 
            Transparentcontainer.Controls.Add(whitebg);
            Transparentcontainer.Dock = DockStyle.Fill;
            Transparentcontainer.Location = new Point(0, 0);
            Transparentcontainer.Name = "Transparentcontainer";
            Transparentcontainer.Size = new Size(1440, 900);
            Transparentcontainer.TabIndex = 0;
            Transparentcontainer.Paint += Transparentcontainer_Paint;
            // 
            // whitebg
            // 
            whitebg.BorderRadius = 10;
            whitebg.Controls.Add(Cardbutton);
            whitebg.Controls.Add(or);
            whitebg.Controls.Add(Cashbutton);
            whitebg.Controls.Add(Whichpaymenttext);
            whitebg.Controls.Add(headerpaymentinfo);
            whitebg.Controls.Add(backicon);
            whitebg.CustomizableEdges = customizableEdges5;
            whitebg.Location = new Point(84, 76);
            whitebg.Name = "whitebg";
            whitebg.ShadowDecoration.CustomizableEdges = customizableEdges6;
            whitebg.Size = new Size(1272, 738);
            whitebg.TabIndex = 0;
            // 
            // Cardbutton
            // 
            Cardbutton.BorderRadius = 10;
            Cardbutton.BorderThickness = 2;
            Cardbutton.CustomizableEdges = customizableEdges1;
            Cardbutton.DisabledState.BorderColor = Color.DarkGray;
            Cardbutton.DisabledState.CustomBorderColor = Color.DarkGray;
            Cardbutton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Cardbutton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Cardbutton.FillColor = Color.White;
            Cardbutton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cardbutton.ForeColor = Color.Black;
            Cardbutton.Location = new Point(456, 505);
            Cardbutton.Name = "Cardbutton";
            Cardbutton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Cardbutton.Size = new Size(407, 72);
            Cardbutton.TabIndex = 6;
            Cardbutton.Text = "Card Payment";
            // 
            // or
            // 
            or.AutoSize = true;
            or.BackColor = Color.Transparent;
            or.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            or.Location = new Point(637, 423);
            or.Name = "or";
            or.Size = new Size(29, 23);
            or.TabIndex = 5;
            or.Text = "or";
            // 
            // Cashbutton
            // 
            Cashbutton.BorderRadius = 10;
            Cashbutton.BorderThickness = 2;
            Cashbutton.CustomizableEdges = customizableEdges3;
            Cashbutton.DisabledState.BorderColor = Color.DarkGray;
            Cashbutton.DisabledState.CustomBorderColor = Color.DarkGray;
            Cashbutton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Cashbutton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Cashbutton.FillColor = Color.FromArgb(13, 22, 29);
            Cashbutton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cashbutton.ForeColor = Color.White;
            Cashbutton.Location = new Point(456, 295);
            Cashbutton.Name = "Cashbutton";
            Cashbutton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Cashbutton.Size = new Size(407, 72);
            Cashbutton.TabIndex = 4;
            Cashbutton.Text = "Cash Payment";
            Cashbutton.Click += Cashbutton_Click;
            // 
            // Whichpaymenttext
            // 
            Whichpaymenttext.AutoSize = true;
            Whichpaymenttext.BackColor = Color.Transparent;
            Whichpaymenttext.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Whichpaymenttext.Location = new Point(505, 202);
            Whichpaymenttext.Name = "Whichpaymenttext";
            Whichpaymenttext.Size = new Size(313, 23);
            Whichpaymenttext.TabIndex = 3;
            Whichpaymenttext.Text = "Which payment do you prefer?";
            // 
            // headerpaymentinfo
            // 
            headerpaymentinfo.BackColor = Color.FromArgb(13, 22, 29);
            headerpaymentinfo.Controls.Add(Paymentmodetext);
            headerpaymentinfo.Location = new Point(147, 77);
            headerpaymentinfo.Name = "headerpaymentinfo";
            headerpaymentinfo.Size = new Size(1041, 64);
            headerpaymentinfo.TabIndex = 1;
            // 
            // Paymentmodetext
            // 
            Paymentmodetext.AutoSize = true;
            Paymentmodetext.BackColor = Color.Transparent;
            Paymentmodetext.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Paymentmodetext.ForeColor = Color.White;
            Paymentmodetext.Location = new Point(441, 21);
            Paymentmodetext.Name = "Paymentmodetext";
            Paymentmodetext.Size = new Size(159, 23);
            Paymentmodetext.TabIndex = 2;
            Paymentmodetext.Text = "Payment Mode";
            // 
            // backicon
            // 
           // backicon.Image = Properties.Resources.icons8_back_64;
            backicon.Location = new Point(37, 35);
            backicon.Name = "backicon";
            backicon.Size = new Size(47, 47);
            backicon.SizeMode = PictureBoxSizeMode.Zoom;
            backicon.TabIndex = 0;
            backicon.TabStop = false;
            // 
            // PaymentInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1440, 900);
            Controls.Add(Transparentcontainer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PaymentInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PaymentInfo";
            Transparentcontainer.ResumeLayout(false);
            whitebg.ResumeLayout(false);
            whitebg.PerformLayout();
            headerpaymentinfo.ResumeLayout(false);
            headerpaymentinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backicon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Transparentcontainer;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel whitebg;
        private PictureBox backicon;
        private Label Whichpaymenttext;
        private Label Paymentmodetext;
        private Panel headerpaymentinfo;
        private Guna.UI2.WinForms.Guna2Button Cashbutton;
        private Guna.UI2.WinForms.Guna2Button Cardbutton;
        private Label or;
    }
}