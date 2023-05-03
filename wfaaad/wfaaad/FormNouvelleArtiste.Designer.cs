namespace wfaaad
{
    partial class FormNouvelleArtiste
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
            this.lblnom = new System.Windows.Forms.Label();
            this.lbldesc = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.btnajouter = new System.Windows.Forms.Button();
            this.lblmail = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txtimg = new System.Windows.Forms.TextBox();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.lbltel = new System.Windows.Forms.Label();
            this.lblprenom = new System.Windows.Forms.Label();
            this.lblimg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Location = new System.Drawing.Point(20, 11);
            this.lblnom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(37, 17);
            this.lblnom.TabIndex = 0;
            this.lblnom.Text = "Nom";
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Location = new System.Drawing.Point(20, 100);
            this.lbldesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(79, 17);
            this.lbldesc.TabIndex = 1;
            this.lbldesc.Text = "Description";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(119, 7);
            this.txtnom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(132, 22);
            this.txtnom.TabIndex = 2;
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(119, 52);
            this.txtprenom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(132, 22);
            this.txtprenom.TabIndex = 3;
            // 
            // btnajouter
            // 
            this.btnajouter.Location = new System.Drawing.Point(119, 278);
            this.btnajouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(100, 28);
            this.btnajouter.TabIndex = 4;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = true;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Location = new System.Drawing.Point(20, 236);
            this.lblmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(33, 17);
            this.lblmail.TabIndex = 5;
            this.lblmail.Text = "Mail";
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(119, 188);
            this.txttel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(132, 22);
            this.txttel.TabIndex = 6;
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(119, 233);
            this.txtmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(132, 22);
            this.txtmail.TabIndex = 7;
            // 
            // txtimg
            // 
            this.txtimg.Location = new System.Drawing.Point(119, 142);
            this.txtimg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtimg.Name = "txtimg";
            this.txtimg.Size = new System.Drawing.Size(132, 22);
            this.txtimg.TabIndex = 10;
            this.txtimg.TextChanged += new System.EventHandler(this.txtimg_TextChanged);
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(119, 96);
            this.txtdesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(132, 22);
            this.txtdesc.TabIndex = 11;
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Location = new System.Drawing.Point(20, 192);
            this.lbltel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(76, 17);
            this.lbltel.TabIndex = 12;
            this.lbltel.Text = "Téléphone";
            // 
            // lblprenom
            // 
            this.lblprenom.AutoSize = true;
            this.lblprenom.Location = new System.Drawing.Point(17, 55);
            this.lblprenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprenom.Name = "lblprenom";
            this.lblprenom.Size = new System.Drawing.Size(57, 17);
            this.lblprenom.TabIndex = 13;
            this.lblprenom.Text = "Prénom";
            // 
            // lblimg
            // 
            this.lblimg.AutoSize = true;
            this.lblimg.Location = new System.Drawing.Point(20, 145);
            this.lblimg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblimg.Name = "lblimg";
            this.lblimg.Size = new System.Drawing.Size(53, 17);
            this.lblimg.TabIndex = 14;
            this.lblimg.Text = "Images";
            // 
            // FormNouvelleArtiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.lblimg);
            this.Controls.Add(this.lblprenom);
            this.Controls.Add(this.lbltel);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.txtimg);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.lblmail);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.txtprenom);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.lbldesc);
            this.Controls.Add(this.lblnom);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormNouvelleArtiste";
            this.Text = "FormNouvelleArtiste";
            this.Load += new System.EventHandler(this.FormNouvelleArtiste_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txtimg;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.Label lblprenom;
        private System.Windows.Forms.Label lblimg;
    }
}