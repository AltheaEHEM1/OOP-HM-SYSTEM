﻿namespace HOTEL_MANAGEMENT_SYSTEM
{
    partial class ChangesSaved
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangesSaved));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            CheckPic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ChangesSavedTxt = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)CheckPic).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // CheckPic
            // 
            CheckPic.Image = (Image)resources.GetObject("CheckPic.Image");
            CheckPic.ImageRotate = 0F;
            CheckPic.Location = new Point(195, 86);
            CheckPic.Name = "CheckPic";
            CheckPic.ShadowDecoration.CustomizableEdges = customizableEdges1;
            CheckPic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            CheckPic.Size = new Size(115, 110);
            CheckPic.TabIndex = 0;
            CheckPic.TabStop = false;
            //CheckPic.Click += CheckPic_Click;
            // 
            // ChangesSavedTxt
            // 
            ChangesSavedTxt.BackColor = Color.Transparent;
            ChangesSavedTxt.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ChangesSavedTxt.Location = new Point(174, 190);
            ChangesSavedTxt.Name = "ChangesSavedTxt";
            ChangesSavedTxt.Size = new Size(153, 25);
            ChangesSavedTxt.TabIndex = 1;
            ChangesSavedTxt.Text = "Changes saved!";
            //ChangesSavedTxt.Click += ChangesSavedTxt_Click;
            // 
            // ChangesSaved
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(500, 300);
            Controls.Add(ChangesSavedTxt);
            Controls.Add(CheckPic);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangesSaved";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangesSaved";
            TopMost = true;
            //Load += ChangesSaved_Load;
            ((System.ComponentModel.ISupportInitialize)CheckPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox CheckPic;
        private Guna.UI2.WinForms.Guna2HtmlLabel ChangesSavedTxt;
    }
}