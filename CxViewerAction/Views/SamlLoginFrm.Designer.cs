﻿namespace CxViewerAction.Views
{
    partial class SamlLoginFrm
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
            this.samlLoginCtrl = new CxViewerAction.Views.DockedView.SamlLoginCtrl();
            this.SuspendLayout();
            // 
            // samlLoginCtrl
            // 
            this.samlLoginCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.samlLoginCtrl.Location = new System.Drawing.Point(0, 0);
            this.samlLoginCtrl.Name = "samlLoginCtrl";
            this.samlLoginCtrl.Size = new System.Drawing.Size(494, 573);
            this.samlLoginCtrl.TabIndex = 0;
            // 
            // SamlLoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 573);
            this.Controls.Add(this.samlLoginCtrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SamlLoginFrm";
            this.Text = "Saml Login";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SamlLoginFrm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private DockedView.SamlLoginCtrl samlLoginCtrl;

        public DockedView.SamlLoginCtrl SamlLoginCtrl
        {
            get { return samlLoginCtrl; }
            set { samlLoginCtrl = value; }
        }
    }
}