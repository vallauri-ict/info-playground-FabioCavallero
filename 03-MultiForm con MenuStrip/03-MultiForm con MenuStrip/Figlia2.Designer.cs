namespace _03_MultiForm_con_MenuStrip
{
    partial class Figlia2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeFModale = new System.Windows.Forms.TextBox();
            this.txtEtaFModale = new System.Windows.Forms.TextBox();
            this.btnApriFModale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Età";
            // 
            // txtNomeFModale
            // 
            this.txtNomeFModale.Location = new System.Drawing.Point(15, 29);
            this.txtNomeFModale.Name = "txtNomeFModale";
            this.txtNomeFModale.ReadOnly = true;
            this.txtNomeFModale.Size = new System.Drawing.Size(100, 22);
            this.txtNomeFModale.TabIndex = 4;
            // 
            // txtEtaFModale
            // 
            this.txtEtaFModale.Location = new System.Drawing.Point(146, 29);
            this.txtEtaFModale.Name = "txtEtaFModale";
            this.txtEtaFModale.ReadOnly = true;
            this.txtEtaFModale.Size = new System.Drawing.Size(100, 22);
            this.txtEtaFModale.TabIndex = 5;
            // 
            // btnApriFModale
            // 
            this.btnApriFModale.Location = new System.Drawing.Point(15, 109);
            this.btnApriFModale.Name = "btnApriFModale";
            this.btnApriFModale.Size = new System.Drawing.Size(231, 23);
            this.btnApriFModale.TabIndex = 6;
            this.btnApriFModale.Text = "Apri La Form Modale";
            this.btnApriFModale.UseVisualStyleBackColor = true;
            this.btnApriFModale.Click += new System.EventHandler(this.btnApriFModale_Click);
            // 
            // Figlia2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 144);
            this.Controls.Add(this.btnApriFModale);
            this.Controls.Add(this.txtEtaFModale);
            this.Controls.Add(this.txtNomeFModale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Figlia2";
            this.Text = "Figlia2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeFModale;
        private System.Windows.Forms.TextBox txtEtaFModale;
        private System.Windows.Forms.Button btnApriFModale;
    }
}