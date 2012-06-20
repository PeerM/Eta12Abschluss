namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelZumReinzeichnen = new System.Windows.Forms.Panel();
            this.buttonZumKreisMalen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelZumReinzeichnen
            // 
            this.panelZumReinzeichnen.Location = new System.Drawing.Point(12, 107);
            this.panelZumReinzeichnen.Name = "panelZumReinzeichnen";
            this.panelZumReinzeichnen.Size = new System.Drawing.Size(463, 298);
            this.panelZumReinzeichnen.TabIndex = 0;
            this.panelZumReinzeichnen.Paint += new System.Windows.Forms.PaintEventHandler(this.panelZumReinzeichnen_Paint);
            // 
            // buttonZumKreisMalen
            // 
            this.buttonZumKreisMalen.Location = new System.Drawing.Point(12, 12);
            this.buttonZumKreisMalen.Name = "buttonZumKreisMalen";
            this.buttonZumKreisMalen.Size = new System.Drawing.Size(75, 23);
            this.buttonZumKreisMalen.TabIndex = 1;
            this.buttonZumKreisMalen.Text = "Kreis Zeichen";
            this.buttonZumKreisMalen.UseVisualStyleBackColor = true;
            this.buttonZumKreisMalen.Click += new System.EventHandler(this.buttonZumKreisMalen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 417);
            this.Controls.Add(this.buttonZumKreisMalen);
            this.Controls.Add(this.panelZumReinzeichnen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelZumReinzeichnen;
        private System.Windows.Forms.Button buttonZumKreisMalen;
    }
}

