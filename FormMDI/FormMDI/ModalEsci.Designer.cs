namespace FormMDI
{
    partial class ModalEsci
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
            this.LblEsci = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.BtnAnnulla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblEsci
            // 
            this.LblEsci.AutoSize = true;
            this.LblEsci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEsci.Location = new System.Drawing.Point(76, 28);
            this.LblEsci.Name = "LblEsci";
            this.LblEsci.Size = new System.Drawing.Size(86, 15);
            this.LblEsci.TabIndex = 0;
            this.LblEsci.Text = "Vuoi uscire?";
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(24, 44);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // BtnAnnulla
            // 
            this.BtnAnnulla.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnAnnulla.Location = new System.Drawing.Point(105, 44);
            this.BtnAnnulla.Name = "BtnAnnulla";
            this.BtnAnnulla.Size = new System.Drawing.Size(75, 23);
            this.BtnAnnulla.TabIndex = 2;
            this.BtnAnnulla.Text = "Annulla";
            this.BtnAnnulla.UseVisualStyleBackColor = true;
            // 
            // ModalEsci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 167);
            this.Controls.Add(this.BtnAnnulla);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.LblEsci);
            this.Name = "ModalEsci";
            this.Text = "ModalEsci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEsci;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button BtnAnnulla;
    }
}