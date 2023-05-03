namespace wfaaad
{
    partial class FormAccueil
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
            this.btnLesArtistes = new System.Windows.Forms.Button();
            this.btnLesSp = new System.Windows.Forms.Button();
            this.btnLesC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLesArtistes
            // 
            this.btnLesArtistes.Location = new System.Drawing.Point(85, 37);
            this.btnLesArtistes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLesArtistes.Name = "btnLesArtistes";
            this.btnLesArtistes.Size = new System.Drawing.Size(233, 68);
            this.btnLesArtistes.TabIndex = 0;
            this.btnLesArtistes.Text = "Les artistes";
            this.btnLesArtistes.UseVisualStyleBackColor = true;
            this.btnLesArtistes.Click += new System.EventHandler(this.btnLesArtistes_Click);
            // 
            // btnLesSp
            // 
            this.btnLesSp.Location = new System.Drawing.Point(85, 128);
            this.btnLesSp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLesSp.Name = "btnLesSp";
            this.btnLesSp.Size = new System.Drawing.Size(233, 68);
            this.btnLesSp.TabIndex = 1;
            this.btnLesSp.Text = "Les spectacles";
            this.btnLesSp.UseVisualStyleBackColor = true;
            this.btnLesSp.Click += new System.EventHandler(this.btnLesSp_Click);
            // 
            // btnLesC
            // 
            this.btnLesC.Location = new System.Drawing.Point(85, 222);
            this.btnLesC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLesC.Name = "btnLesC";
            this.btnLesC.Size = new System.Drawing.Size(233, 68);
            this.btnLesC.TabIndex = 2;
            this.btnLesC.Text = "Les contacts";
            this.btnLesC.UseVisualStyleBackColor = true;
            this.btnLesC.Click += new System.EventHandler(this.btnLesC_Click);
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.btnLesC);
            this.Controls.Add(this.btnLesSp);
            this.Controls.Add(this.btnLesArtistes);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAccueil";
            this.Text = "FormAccueil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLesArtistes;
        private System.Windows.Forms.Button btnLesSp;
        private System.Windows.Forms.Button btnLesC;
    }
}