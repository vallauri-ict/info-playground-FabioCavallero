namespace Ospedale
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.txtEtà = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.btnCura = new System.Windows.Forms.Button();
            this.cmbCodice = new System.Windows.Forms.ComboBox();
            this.btnTemperature = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Età";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Colore";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Temperatura";
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(118, 138);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(100, 20);
            this.txtTemperatura.TabIndex = 4;
            // 
            // txtEtà
            // 
            this.txtEtà.Location = new System.Drawing.Point(118, 61);
            this.txtEtà.Name = "txtEtà";
            this.txtEtà.Size = new System.Drawing.Size(100, 20);
            this.txtEtà.TabIndex = 6;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(118, 25);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 7;
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(41, 178);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(106, 23);
            this.btnInserisci.TabIndex = 8;
            this.btnInserisci.Text = "Inserisci";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.BtnInserisci_Click);
            // 
            // btnCura
            // 
            this.btnCura.Location = new System.Drawing.Point(153, 178);
            this.btnCura.Name = "btnCura";
            this.btnCura.Size = new System.Drawing.Size(75, 23);
            this.btnCura.TabIndex = 9;
            this.btnCura.Text = "Cura";
            this.btnCura.UseVisualStyleBackColor = true;
            this.btnCura.Click += new System.EventHandler(this.BtnCura_Click);
            // 
            // cmbCodice
            // 
            this.cmbCodice.FormattingEnabled = true;
            this.cmbCodice.Items.AddRange(new object[] {
            "Rosso",
            "Giallo",
            "Verde",
            "Bianco"});
            this.cmbCodice.Location = new System.Drawing.Point(118, 101);
            this.cmbCodice.Name = "cmbCodice";
            this.cmbCodice.Size = new System.Drawing.Size(100, 21);
            this.cmbCodice.TabIndex = 10;
            // 
            // btnTemperature
            // 
            this.btnTemperature.Location = new System.Drawing.Point(153, 207);
            this.btnTemperature.Name = "btnTemperature";
            this.btnTemperature.Size = new System.Drawing.Size(75, 23);
            this.btnTemperature.TabIndex = 11;
            this.btnTemperature.Text = "Temperature";
            this.btnTemperature.UseVisualStyleBackColor = true;
            this.btnTemperature.Click += new System.EventHandler(this.BtnTemperature_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Visualizza pazienti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 258);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTemperature);
            this.Controls.Add(this.cmbCodice);
            this.Controls.Add(this.btnCura);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtEtà);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.TextBox txtEtà;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.Button btnCura;
        private System.Windows.Forms.ComboBox cmbCodice;
        private System.Windows.Forms.Button btnTemperature;
        private System.Windows.Forms.Button button1;
    }
}

