namespace HOTEL_MANAGEMENT_SYSTEM
{
    partial class TermsandCondition
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TermsandCondition));
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            TandCText2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            CancellationConfirmBttn = new Guna.UI2.WinForms.Guna2Button();
            AcceptTermsTxt = new Guna.UI2.WinForms.Guna2HtmlLabel();
            CheckBox = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            TandCTxt = new Label();
            CancellationTxt = new Label();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderRadius = 20;
            guna2Panel1.Controls.Add(TandCText2);
            guna2Panel1.Controls.Add(CancellationConfirmBttn);
            guna2Panel1.Controls.Add(AcceptTermsTxt);
            guna2Panel1.Controls.Add(CheckBox);
            guna2Panel1.Controls.Add(TandCTxt);
            guna2Panel1.Controls.Add(CancellationTxt);
            guna2Panel1.CustomizableEdges = customizableEdges5;
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.Location = new Point(28, 24);
            guna2Panel1.Margin = new Padding(3, 4, 3, 4);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel1.Size = new Size(516, 350);
            guna2Panel1.TabIndex = 0;
            guna2Panel1.Paint += guna2Panel1_Paint;
            // 
            // TandCText2
            // 
            TandCText2.AutoSize = false;
            TandCText2.BackColor = Color.Transparent;
            TandCText2.Font = new Font("Century Gothic", 9F);
            TandCText2.Location = new Point(39, 157);
            TandCText2.Margin = new Padding(3, 4, 3, 4);
            TandCText2.Name = "TandCText2";
            TandCText2.Size = new Size(458, 147);
            TandCText2.TabIndex = 9;
            TandCText2.Text = resources.GetString("TandCText2.Text");
            TandCText2.Click += TandCText2_Click;
            // 
            // CancellationConfirmBttn
            // 
            CancellationConfirmBttn.BorderRadius = 10;
            CancellationConfirmBttn.CustomizableEdges = customizableEdges1;
            CancellationConfirmBttn.DisabledState.BorderColor = Color.DarkGray;
            CancellationConfirmBttn.DisabledState.CustomBorderColor = Color.DarkGray;
            CancellationConfirmBttn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            CancellationConfirmBttn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            CancellationConfirmBttn.FillColor = Color.FromArgb(55, 73, 7);
            CancellationConfirmBttn.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancellationConfirmBttn.ForeColor = Color.White;
            CancellationConfirmBttn.Location = new Point(141, 595);
            CancellationConfirmBttn.Margin = new Padding(3, 4, 3, 4);
            CancellationConfirmBttn.Name = "CancellationConfirmBttn";
            CancellationConfirmBttn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            CancellationConfirmBttn.Size = new Size(232, 60);
            CancellationConfirmBttn.TabIndex = 8;
            CancellationConfirmBttn.Text = "Confirm";
            CancellationConfirmBttn.Click += CancellationConfirmBttn_Click;
            // 
            // AcceptTermsTxt
            // 
            AcceptTermsTxt.BackColor = Color.Transparent;
            AcceptTermsTxt.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AcceptTermsTxt.Location = new Point(141, 529);
            AcceptTermsTxt.Margin = new Padding(3, 4, 3, 4);
            AcceptTermsTxt.Name = "AcceptTermsTxt";
            AcceptTermsTxt.Size = new Size(301, 25);
            AcceptTermsTxt.TabIndex = 7;
            AcceptTermsTxt.Text = "I accept Terms and Conditions";
            // 
            // CheckBox
            // 
            CheckBox.CheckedState.BorderColor = Color.FromArgb(55, 73, 7);
            CheckBox.CheckedState.BorderRadius = 2;
            CheckBox.CheckedState.BorderThickness = 0;
            CheckBox.CheckedState.FillColor = Color.FromArgb(55, 73, 7);
            CheckBox.CustomizableEdges = customizableEdges3;
            CheckBox.Location = new Point(80, 529);
            CheckBox.Margin = new Padding(3, 4, 3, 4);
            CheckBox.Name = "CheckBox";
            CheckBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            CheckBox.Size = new Size(29, 33);
            CheckBox.TabIndex = 6;
            CheckBox.UncheckedState.BorderColor = Color.Black;
            CheckBox.UncheckedState.BorderRadius = 1;
            CheckBox.UncheckedState.BorderThickness = 1;
            CheckBox.UncheckedState.FillColor = Color.White;
            // 
            // TandCTxt
            // 
            TandCTxt.AutoSize = true;
            TandCTxt.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TandCTxt.Location = new Point(145, 95);
            TandCTxt.Name = "TandCTxt";
            TandCTxt.Size = new Size(252, 27);
            TandCTxt.TabIndex = 2;
            TandCTxt.Text = "Terms and Conditions";
            // 
            // CancellationTxt
            // 
            CancellationTxt.AutoSize = true;
            CancellationTxt.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancellationTxt.Location = new Point(197, 56);
            CancellationTxt.Name = "CancellationTxt";
            CancellationTxt.Size = new Size(158, 27);
            CancellationTxt.TabIndex = 1;
            CancellationTxt.Text = "Cancellation";
            // 
            // TermsandCondition
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(571, 417);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "TermsandCondition";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TermsandCondition";
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label CancellationTxt;
        private Label TandCTxt;
        private Guna.UI2.WinForms.Guna2CustomCheckBox CheckBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel AcceptTermsTxt;
        private Guna.UI2.WinForms.Guna2Button CancellationConfirmBttn;
        private Guna.UI2.WinForms.Guna2HtmlLabel TandCText2;
    }
}