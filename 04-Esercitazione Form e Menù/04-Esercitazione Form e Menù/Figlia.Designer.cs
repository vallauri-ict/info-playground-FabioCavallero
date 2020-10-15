namespace _04_Esercitazione_Form_e_Menù
{
    partial class Figlia
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
            this.txtFiglia = new System.Windows.Forms.TextBox();
            this.btnInviaAForm1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFiglia
            // 
            this.txtFiglia.Location = new System.Drawing.Point(13, 13);
            this.txtFiglia.Name = "txtFiglia";
            this.txtFiglia.Size = new System.Drawing.Size(171, 22);
            this.txtFiglia.TabIndex = 0;
            // 
            // btnInviaAForm1
            // 
            this.btnInviaAForm1.Location = new System.Drawing.Point(13, 42);
            this.btnInviaAForm1.Name = "btnInviaAForm1";
            this.btnInviaAForm1.Size = new System.Drawing.Size(171, 98);
            this.btnInviaAForm1.TabIndex = 1;
            this.btnInviaAForm1.Text = "Invia A Form1";
            this.btnInviaAForm1.UseVisualStyleBackColor = true;
            this.btnInviaAForm1.Click += new System.EventHandler(this.btnInviaAForm1_Click);
            // 
            // Figlia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 152);
            this.Controls.Add(this.btnInviaAForm1);
            this.Controls.Add(this.txtFiglia);
            this.Name = "Figlia";
            this.Text = "Figlia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFiglia;
        private System.Windows.Forms.Button btnInviaAForm1;
    }
}