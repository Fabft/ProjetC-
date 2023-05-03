namespace wfaaad
{
    partial class FormContact
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
            this.dgvCtc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCtc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCtc
            // 
            this.dgvCtc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCtc.Location = new System.Drawing.Point(254, 67);
            this.dgvCtc.Name = "dgvCtc";
            this.dgvCtc.RowTemplate.Height = 24;
            this.dgvCtc.Size = new System.Drawing.Size(672, 219);
            this.dgvCtc.TabIndex = 0;
            // 
            // FormContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 463);
            this.Controls.Add(this.dgvCtc);
            this.Name = "FormContact";
            this.Text = "FormContact";
            this.Load += new System.EventHandler(this.FormContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCtc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCtc;
    }
}