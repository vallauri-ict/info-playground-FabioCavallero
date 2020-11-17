namespace OOP05_Classe_Indexata
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
            this.btnCrea = new System.Windows.Forms.Button();
            this.txtElementi = new System.Windows.Forms.TextBox();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCrea
            // 
            this.btnCrea.Location = new System.Drawing.Point(16, 39);
            this.btnCrea.Name = "btnCrea";
            this.btnCrea.Size = new System.Drawing.Size(75, 23);
            this.btnCrea.TabIndex = 0;
            this.btnCrea.Text = "Crea classe";
            this.btnCrea.UseVisualStyleBackColor = true;
            this.btnCrea.Click += new System.EventHandler(this.btnCrea_Click);
            // 
            // txtElementi
            // 
            this.txtElementi.Location = new System.Drawing.Point(116, 10);
            this.txtElementi.Name = "txtElementi";
            this.txtElementi.Size = new System.Drawing.Size(100, 20);
            this.txtElementi.TabIndex = 1;
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(97, 39);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizza.TabIndex = 2;
            this.btnVisualizza.Text = "Visualizza";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero di elementi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 74);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.txtElementi);
            this.Controls.Add(this.btnCrea);
            this.Name = "Form1";
            this.Text = "Classe indexata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrea;
        private System.Windows.Forms.TextBox txtElementi;
        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.Label label1;
    }
}

