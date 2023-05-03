using System.ComponentModel;

namespace wfaaad
{
    partial class FormModifArtiste
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.lblNomArt = new System.Windows.Forms.Label();
            this.lblPrenomArt = new System.Windows.Forms.Label();
            this.txtNomArt = new System.Windows.Forms.TextBox();
            this.txtPrenomArt = new System.Windows.Forms.TextBox();
            this.lblDescArt = new System.Windows.Forms.Label();
            this.txtDescArt = new System.Windows.Forms.TextBox();
            this.txtImgArt = new System.Windows.Forms.TextBox();
            this.txtTelArt = new System.Windows.Forms.TextBox();
            this.lblImgArt = new System.Windows.Forms.Label();
            this.lblTelArt = new System.Windows.Forms.Label();
            this.txtMailArt = new System.Windows.Forms.TextBox();
            this.lblMailArt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Location = new System.Drawing.Point(475, 425);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(199, 38);
            this.BtnAjouter.TabIndex = 1;
            this.BtnAjouter.Text = "Enregistrer la modification";
            this.BtnAjouter.UseVisualStyleBackColor = true;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // lblNomArt
            // 
            this.lblNomArt.AutoSize = true;
            this.lblNomArt.Location = new System.Drawing.Point(358, 35);
            this.lblNomArt.Name = "lblNomArt";
            this.lblNomArt.Size = new System.Drawing.Size(37, 17);
            this.lblNomArt.TabIndex = 2;
            this.lblNomArt.Text = "Nom";
            // 
            // lblPrenomArt
            // 
            this.lblPrenomArt.AutoSize = true;
            this.lblPrenomArt.Location = new System.Drawing.Point(358, 70);
            this.lblPrenomArt.Name = "lblPrenomArt";
            this.lblPrenomArt.Size = new System.Drawing.Size(57, 17);
            this.lblPrenomArt.TabIndex = 4;
            this.lblPrenomArt.Text = "Prénom";
            // 
            // txtNomArt
            // 
            this.txtNomArt.Location = new System.Drawing.Point(574, 35);
            this.txtNomArt.Name = "txtNomArt";
            this.txtNomArt.Size = new System.Drawing.Size(251, 22);
            this.txtNomArt.TabIndex = 6;
            // 
            // txtPrenomArt
            // 
            this.txtPrenomArt.Location = new System.Drawing.Point(574, 70);
            this.txtPrenomArt.Name = "txtPrenomArt";
            this.txtPrenomArt.Size = new System.Drawing.Size(158, 22);
            this.txtPrenomArt.TabIndex = 7;
            // 
            // lblDescArt
            // 
            this.lblDescArt.AutoSize = true;
            this.lblDescArt.Location = new System.Drawing.Point(358, 120);
            this.lblDescArt.Name = "lblDescArt";
            this.lblDescArt.Size = new System.Drawing.Size(79, 17);
            this.lblDescArt.TabIndex = 8;
            this.lblDescArt.Text = "Description";
            // 
            // txtDescArt
            // 
            this.txtDescArt.Location = new System.Drawing.Point(574, 120);
            this.txtDescArt.Multiline = true;
            this.txtDescArt.Name = "txtDescArt";
            this.txtDescArt.Size = new System.Drawing.Size(411, 111);
            this.txtDescArt.TabIndex = 9;
            // 
            // txtImgArt
            // 
            this.txtImgArt.Location = new System.Drawing.Point(574, 257);
            this.txtImgArt.Multiline = true;
            this.txtImgArt.Name = "txtImgArt";
            this.txtImgArt.Size = new System.Drawing.Size(100, 22);
            this.txtImgArt.TabIndex = 10;
            // 
            // txtTelArt
            // 
            this.txtTelArt.Location = new System.Drawing.Point(574, 299);
            this.txtTelArt.Name = "txtTelArt";
            this.txtTelArt.Size = new System.Drawing.Size(158, 22);
            this.txtTelArt.TabIndex = 11;
            // 
            // lblImgArt
            // 
            this.lblImgArt.AutoSize = true;
            this.lblImgArt.Location = new System.Drawing.Point(358, 257);
            this.lblImgArt.Name = "lblImgArt";
            this.lblImgArt.Size = new System.Drawing.Size(46, 17);
            this.lblImgArt.TabIndex = 12;
            this.lblImgArt.Text = "Image";
            // 
            // lblTelArt
            // 
            this.lblTelArt.AutoSize = true;
            this.lblTelArt.Location = new System.Drawing.Point(358, 299);
            this.lblTelArt.Name = "lblTelArt";
            this.lblTelArt.Size = new System.Drawing.Size(76, 17);
            this.lblTelArt.TabIndex = 13;
            this.lblTelArt.Text = "Téléphone";
            // 
            // txtMailArt
            // 
            this.txtMailArt.Location = new System.Drawing.Point(574, 350);
            this.txtMailArt.Name = "txtMailArt";
            this.txtMailArt.Size = new System.Drawing.Size(251, 22);
            this.txtMailArt.TabIndex = 14;
            // 
            // lblMailArt
            // 
            this.lblMailArt.AutoSize = true;
            this.lblMailArt.Location = new System.Drawing.Point(358, 350);
            this.lblMailArt.Name = "lblMailArt";
            this.lblMailArt.Size = new System.Drawing.Size(33, 17);
            this.lblMailArt.TabIndex = 15;
            this.lblMailArt.Text = "Mail";
            // 
            // FormModifArtiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 495);
            this.Controls.Add(this.lblMailArt);
            this.Controls.Add(this.txtMailArt);
            this.Controls.Add(this.lblTelArt);
            this.Controls.Add(this.lblImgArt);
            this.Controls.Add(this.txtTelArt);
            this.Controls.Add(this.txtImgArt);
            this.Controls.Add(this.txtDescArt);
            this.Controls.Add(this.lblDescArt);
            this.Controls.Add(this.txtPrenomArt);
            this.Controls.Add(this.txtNomArt);
            this.Controls.Add(this.lblPrenomArt);
            this.Controls.Add(this.lblNomArt);
            this.Controls.Add(this.BtnAjouter);
            this.Name = "FormModifArtiste";
            this.Text = "FormModifArtiste";
            this.Load += new System.EventHandler(this.FormModifArtiste_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.Label lblNomArt;
        private System.Windows.Forms.Label lblPrenomArt;
        private System.Windows.Forms.TextBox txtNomArt;
        private System.Windows.Forms.TextBox txtPrenomArt;
        private System.Windows.Forms.Label lblDescArt;
        private System.Windows.Forms.TextBox txtDescArt;
        private System.Windows.Forms.TextBox txtImgArt;
        private System.Windows.Forms.TextBox txtTelArt;
        private System.Windows.Forms.Label lblImgArt;
        private System.Windows.Forms.Label lblTelArt;
        private System.Windows.Forms.TextBox txtMailArt;
        private System.Windows.Forms.Label lblMailArt;
    }
}