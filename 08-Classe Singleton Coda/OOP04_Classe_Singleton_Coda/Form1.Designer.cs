namespace OOP04_Classe_Singleton_Coda
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.btnInserisciElemento = new System.Windows.Forms.Button();
            this.btnStampaElemento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserisci un elemento nella coda";
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(178, 13);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(100, 20);
            this.txtElemento.TabIndex = 1;
            // 
            // btnInserisciElemento
            // 
            this.btnInserisciElemento.Location = new System.Drawing.Point(284, 13);
            this.btnInserisciElemento.Name = "btnInserisciElemento";
            this.btnInserisciElemento.Size = new System.Drawing.Size(155, 23);
            this.btnInserisciElemento.TabIndex = 2;
            this.btnInserisciElemento.Text = "INSERISCI ELEMENTO";
            this.btnInserisciElemento.UseVisualStyleBackColor = true;
            this.btnInserisciElemento.Click += new System.EventHandler(this.btnInserisciElemento_Click);
            // 
            // btnStampaElemento
            // 
            this.btnStampaElemento.Location = new System.Drawing.Point(16, 43);
            this.btnStampaElemento.Name = "btnStampaElemento";
            this.btnStampaElemento.Size = new System.Drawing.Size(136, 23);
            this.btnStampaElemento.TabIndex = 3;
            this.btnStampaElemento.Text = "STAMPA ELEMENTO";
            this.btnStampaElemento.UseVisualStyleBackColor = true;
            this.btnStampaElemento.Click += new System.EventHandler(this.btnStampaElemento_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 81);
            this.Controls.Add(this.btnStampaElemento);
            this.Controls.Add(this.btnInserisciElemento);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Button btnInserisciElemento;
        private System.Windows.Forms.Button btnStampaElemento;
    }
}

