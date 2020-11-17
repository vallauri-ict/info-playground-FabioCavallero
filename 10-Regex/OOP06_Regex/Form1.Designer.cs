namespace OOP06_Regex
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
            this.btnControllaTarga = new System.Windows.Forms.Button();
            this.btnControllaPassword = new System.Windows.Forms.Button();
            this.txtTarga = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnControllaTarga
            // 
            this.btnControllaTarga.Location = new System.Drawing.Point(12, 42);
            this.btnControllaTarga.Name = "btnControllaTarga";
            this.btnControllaTarga.Size = new System.Drawing.Size(98, 23);
            this.btnControllaTarga.TabIndex = 0;
            this.btnControllaTarga.Text = "Controlla targa";
            this.btnControllaTarga.UseVisualStyleBackColor = true;
            this.btnControllaTarga.Click += new System.EventHandler(this.btnControllaTarga_Click);
            // 
            // btnControllaPassword
            // 
            this.btnControllaPassword.Location = new System.Drawing.Point(116, 42);
            this.btnControllaPassword.Name = "btnControllaPassword";
            this.btnControllaPassword.Size = new System.Drawing.Size(112, 23);
            this.btnControllaPassword.TabIndex = 1;
            this.btnControllaPassword.Text = "Controlla password";
            this.btnControllaPassword.UseVisualStyleBackColor = true;
            this.btnControllaPassword.Click += new System.EventHandler(this.btnControllaPassword_Click);
            // 
            // txtTarga
            // 
            this.txtTarga.Location = new System.Drawing.Point(13, 13);
            this.txtTarga.Name = "txtTarga";
            this.txtTarga.Size = new System.Drawing.Size(100, 20);
            this.txtTarga.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(120, 12);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 76);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtTarga);
            this.Controls.Add(this.btnControllaPassword);
            this.Controls.Add(this.btnControllaTarga);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnControllaTarga;
        private System.Windows.Forms.Button btnControllaPassword;
        private System.Windows.Forms.TextBox txtTarga;
        private System.Windows.Forms.TextBox txtPassword;
    }
}

