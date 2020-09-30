namespace Multiform01_project
{
    partial class btnForm2
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnApriForm2 = new System.Windows.Forms.Button();
            this.brnApriForm2b = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnApriForm2
            // 
            this.btnApriForm2.Location = new System.Drawing.Point(12, 12);
            this.btnApriForm2.Name = "btnApriForm2";
            this.btnApriForm2.Size = new System.Drawing.Size(88, 28);
            this.btnApriForm2.TabIndex = 0;
            this.btnApriForm2.Text = "apri form 2";
            this.btnApriForm2.UseVisualStyleBackColor = true;
            this.btnApriForm2.Click += new System.EventHandler(this.button1_Click);
            // 
            // brnApriForm2b
            // 
            this.brnApriForm2b.Location = new System.Drawing.Point(121, 12);
            this.brnApriForm2b.Name = "brnApriForm2b";
            this.brnApriForm2b.Size = new System.Drawing.Size(75, 28);
            this.brnApriForm2b.TabIndex = 1;
            this.brnApriForm2b.Text = "apri form 2b";
            this.brnApriForm2b.UseVisualStyleBackColor = true;
            this.brnApriForm2b.Click += new System.EventHandler(this.brnApriForm2b_Click);
            // 
            // btnForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.brnApriForm2b);
            this.Controls.Add(this.btnApriForm2);
            this.Name = "btnForm2";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApriForm2;
        private System.Windows.Forms.Button brnApriForm2b;
    }
}

