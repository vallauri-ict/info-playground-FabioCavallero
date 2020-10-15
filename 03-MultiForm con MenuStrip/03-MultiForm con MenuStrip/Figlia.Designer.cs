namespace _03_MultiForm_con_MenuStrip
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
            this.txtDaPassareAForm2 = new System.Windows.Forms.TextBox();
            this.btnPassaAF2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDaPassareAForm2
            // 
            this.txtDaPassareAForm2.Location = new System.Drawing.Point(13, 13);
            this.txtDaPassareAForm2.Name = "txtDaPassareAForm2";
            this.txtDaPassareAForm2.Size = new System.Drawing.Size(100, 22);
            this.txtDaPassareAForm2.TabIndex = 0;
            // 
            // btnPassaAF2
            // 
            this.btnPassaAF2.Location = new System.Drawing.Point(119, 13);
            this.btnPassaAF2.Name = "btnPassaAF2";
            this.btnPassaAF2.Size = new System.Drawing.Size(118, 22);
            this.btnPassaAF2.TabIndex = 1;
            this.btnPassaAF2.Text = "Passa A Form2";
            this.btnPassaAF2.UseVisualStyleBackColor = true;
            this.btnPassaAF2.Click += new System.EventHandler(this.btnPassaAF2_Click);
            // 
            // Figlia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 46);
            this.Controls.Add(this.btnPassaAF2);
            this.Controls.Add(this.txtDaPassareAForm2);
            this.Name = "Figlia";
            this.Text = "Figlia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDaPassareAForm2;
        private System.Windows.Forms.Button btnPassaAF2;
    }
}