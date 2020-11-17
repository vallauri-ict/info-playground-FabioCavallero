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
            this.txtFiglia.Location = new System.Drawing.Point(10, 11);
            this.txtFiglia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFiglia.Name = "txtFiglia";
            this.txtFiglia.Size = new System.Drawing.Size(129, 20);
            this.txtFiglia.TabIndex = 0;
            // 
            // btnInviaAForm1
            // 
            this.btnInviaAForm1.Location = new System.Drawing.Point(10, 34);
            this.btnInviaAForm1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInviaAForm1.Name = "btnInviaAForm1";
            this.btnInviaAForm1.Size = new System.Drawing.Size(128, 80);
            this.btnInviaAForm1.TabIndex = 1;
            this.btnInviaAForm1.Text = "Invia A Form1";
            this.btnInviaAForm1.UseVisualStyleBackColor = true;
            this.btnInviaAForm1.Click += new System.EventHandler(this.btnInviaAForm1_Click);
            // 
            // Figlia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(147, 124);
            this.Controls.Add(this.btnInviaAForm1);
            this.Controls.Add(this.txtFiglia);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Figlia";
            this.Text = "Figlia";
            this.Load += new System.EventHandler(this.Figlia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFiglia;
        private System.Windows.Forms.Button btnInviaAForm1;
    }
}