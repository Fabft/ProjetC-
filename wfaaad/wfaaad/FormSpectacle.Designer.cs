namespace wfaaad
{
    partial class FormSpectacle
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
            this.dgvSp = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSp
            // 
            this.dgvSp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSp.Location = new System.Drawing.Point(215, 49);
            this.dgvSp.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSp.Name = "dgvSp";
            this.dgvSp.Size = new System.Drawing.Size(552, 199);
            this.dgvSp.TabIndex = 0;
            this.dgvSp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSp_CellContentClick);
            // 
            // FormSpectacle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 348);
            this.Controls.Add(this.dgvSp);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSpectacle";
            this.Text = "FormSpectacle";
            this.Load += new System.EventHandler(this.FormSpectacle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSp;
    }
}