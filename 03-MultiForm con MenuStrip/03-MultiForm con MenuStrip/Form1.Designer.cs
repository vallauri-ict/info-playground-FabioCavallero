namespace _03_MultiForm_con_MenuStrip
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menùToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriForm2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriForm2BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passaTestoAForm2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriFormModaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menùToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menùToolStripMenuItem
            // 
            this.menùToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apriForm2ToolStripMenuItem,
            this.apriForm2BToolStripMenuItem,
            this.passaTestoAForm2ToolStripMenuItem,
            this.apriFormModaleToolStripMenuItem,
            this.esciToolStripMenuItem});
            this.menùToolStripMenuItem.Name = "menùToolStripMenuItem";
            this.menùToolStripMenuItem.Size = new System.Drawing.Size(60, 26);
            this.menùToolStripMenuItem.Text = "&Menù";
            this.menùToolStripMenuItem.Click += new System.EventHandler(this.menùToolStripMenuItem_Click);
            // 
            // apriForm2ToolStripMenuItem
            // 
            this.apriForm2ToolStripMenuItem.Name = "apriForm2ToolStripMenuItem";
            this.apriForm2ToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.apriForm2ToolStripMenuItem.Text = "Apri Form 2";
            this.apriForm2ToolStripMenuItem.Click += new System.EventHandler(this.apriForm2ToolStripMenuItem_Click);
            // 
            // apriForm2BToolStripMenuItem
            // 
            this.apriForm2BToolStripMenuItem.Name = "apriForm2BToolStripMenuItem";
            this.apriForm2BToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.apriForm2BToolStripMenuItem.Text = "Apri Form 2B";
            this.apriForm2BToolStripMenuItem.Click += new System.EventHandler(this.apriForm2BToolStripMenuItem_Click);
            // 
            // passaTestoAForm2ToolStripMenuItem
            // 
            this.passaTestoAForm2ToolStripMenuItem.Name = "passaTestoAForm2ToolStripMenuItem";
            this.passaTestoAForm2ToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.passaTestoAForm2ToolStripMenuItem.Text = "Passa Testo a Form 2";
            this.passaTestoAForm2ToolStripMenuItem.Click += new System.EventHandler(this.passaTestoAForm2ToolStripMenuItem_Click);
            // 
            // apriFormModaleToolStripMenuItem
            // 
            this.apriFormModaleToolStripMenuItem.Name = "apriFormModaleToolStripMenuItem";
            this.apriFormModaleToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.apriFormModaleToolStripMenuItem.Text = "Apri Form Modale";
            this.apriFormModaleToolStripMenuItem.Click += new System.EventHandler(this.apriFormModaleToolStripMenuItem_Click);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.esciToolStripMenuItem.Text = "&Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLbl});
            this.statusStrip.Location = new System.Drawing.Point(0, 426);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 24);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusStripLbl
            // 
            this.statusStripLbl.Name = "statusStripLbl";
            this.statusStripLbl.Size = new System.Drawing.Size(0, 18);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menùToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apriForm2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apriForm2BToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passaTestoAForm2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apriFormModaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLbl;
    }
}

