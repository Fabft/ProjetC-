namespace wfaaad
{
    partial class FormArtiste
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
            this.dgvartiste = new System.Windows.Forms.DataGridView();
            this.BtnAjouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvartiste)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvartiste
            // 
            this.dgvartiste.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvartiste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvartiste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvartiste.Location = new System.Drawing.Point(13, 13);
            this.dgvartiste.Margin = new System.Windows.Forms.Padding(4);
            this.dgvartiste.Name = "dgvartiste";
            this.dgvartiste.Size = new System.Drawing.Size(1190, 481);
            this.dgvartiste.TabIndex = 0;
            this.dgvartiste.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvartiste_CellContentClick);
            this.dgvartiste.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvartiste_CellDoubleClick);
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Location = new System.Drawing.Point(506, 510);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(163, 58);
            this.BtnAjouter.TabIndex = 1;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.UseVisualStyleBackColor = true;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // FormArtiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 580);
            this.Controls.Add(this.BtnAjouter);
            this.Controls.Add(this.dgvartiste);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormArtiste";
            this.Text = "FormArtiste";
            this.Load += new System.EventHandler(this.FormArtiste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvartiste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvartiste;
        private System.Windows.Forms.Button BtnAjouter;
    }
}