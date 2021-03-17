
namespace _4_035_UsoUserControl
{
    partial class FormMain
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
            this.txtMiaText = new _4_034_UserControl.UserControl();
            this.chkNum = new System.Windows.Forms.CheckBox();
            this.numCifreDec = new System.Windows.Forms.NumericUpDown();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.btnPulisci = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCifreDec)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMiaText
            // 
            this.txtMiaText.CifreDecimali = 0;
            this.txtMiaText.Location = new System.Drawing.Point(12, 31);
            this.txtMiaText.Name = "txtMiaText";
            this.txtMiaText.Numero = false;
            this.txtMiaText.Size = new System.Drawing.Size(99, 20);
            this.txtMiaText.TabIndex = 0;
            this.txtMiaText.Testo = "";
            // 
            // chkNum
            // 
            this.chkNum.AutoSize = true;
            this.chkNum.Location = new System.Drawing.Point(118, 33);
            this.chkNum.Name = "chkNum";
            this.chkNum.Size = new System.Drawing.Size(119, 17);
            this.chkNum.TabIndex = 1;
            this.chkNum.Text = "Accetta solo numeri";
            this.chkNum.UseVisualStyleBackColor = true;
            this.chkNum.CheckedChanged += new System.EventHandler(this.chkNum_CheckedChanged);
            // 
            // numCifreDec
            // 
            this.numCifreDec.Location = new System.Drawing.Point(244, 33);
            this.numCifreDec.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCifreDec.Name = "numCifreDec";
            this.numCifreDec.Size = new System.Drawing.Size(38, 20);
            this.numCifreDec.TabIndex = 2;
            this.numCifreDec.ValueChanged += new System.EventHandler(this.numCifreDec_ValueChanged);
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(12, 58);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizza.TabIndex = 3;
            this.btnVisualizza.Text = "Visualizza";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // btnPulisci
            // 
            this.btnPulisci.Location = new System.Drawing.Point(118, 58);
            this.btnPulisci.Name = "btnPulisci";
            this.btnPulisci.Size = new System.Drawing.Size(75, 23);
            this.btnPulisci.TabIndex = 4;
            this.btnPulisci.Text = "Pulisci";
            this.btnPulisci.UseVisualStyleBackColor = true;
            this.btnPulisci.Click += new System.EventHandler(this.btnPulisci_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPulisci);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.numCifreDec);
            this.Controls.Add(this.chkNum);
            this.Controls.Add(this.txtMiaText);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCifreDec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _4_034_UserControl.UserControl txtMiaText;
        private System.Windows.Forms.CheckBox chkNum;
        private System.Windows.Forms.NumericUpDown numCifreDec;
        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.Button btnPulisci;
    }
}

