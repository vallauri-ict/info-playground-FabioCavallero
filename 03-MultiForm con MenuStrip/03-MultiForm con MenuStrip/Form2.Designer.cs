namespace _03_MultiForm_con_MenuStrip
{
    partial class Form2
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
            this.btnLeggiParametro = new System.Windows.Forms.Button();
            this.btnInviaAFFiglia = new System.Windows.Forms.Button();
            this.txtForm2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLeggiParametro
            // 
            this.btnLeggiParametro.Location = new System.Drawing.Point(13, 13);
            this.btnLeggiParametro.Name = "btnLeggiParametro";
            this.btnLeggiParametro.Size = new System.Drawing.Size(226, 72);
            this.btnLeggiParametro.TabIndex = 0;
            this.btnLeggiParametro.Text = "Leggi Il Parametro Passato";
            this.btnLeggiParametro.UseVisualStyleBackColor = true;
            this.btnLeggiParametro.Click += new System.EventHandler(this.btnLeggiParametro_Click);
            // 
            // btnInviaAFFiglia
            // 
            this.btnInviaAFFiglia.Location = new System.Drawing.Point(118, 127);
            this.btnInviaAFFiglia.Name = "btnInviaAFFiglia";
            this.btnInviaAFFiglia.Size = new System.Drawing.Size(121, 58);
            this.btnInviaAFFiglia.TabIndex = 1;
            this.btnInviaAFFiglia.Text = "Invia A Form Figlia";
            this.btnInviaAFFiglia.UseVisualStyleBackColor = true;
            this.btnInviaAFFiglia.Click += new System.EventHandler(this.btnInviaAFFiglia_Click);
            // 
            // txtForm2
            // 
            this.txtForm2.Location = new System.Drawing.Point(12, 128);
            this.txtForm2.Name = "txtForm2";
            this.txtForm2.Size = new System.Drawing.Size(100, 22);
            this.txtForm2.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 322);
            this.Controls.Add(this.txtForm2);
            this.Controls.Add(this.btnInviaAFFiglia);
            this.Controls.Add(this.btnLeggiParametro);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeggiParametro;
        private System.Windows.Forms.Button btnInviaAFFiglia;
        private System.Windows.Forms.TextBox txtForm2;
    }
}