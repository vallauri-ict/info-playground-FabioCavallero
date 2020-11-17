namespace _04_Esercitazione_Form_e_Menù
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSecondariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFigliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMDIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeF1 = new System.Windows.Forms.TextBox();
            this.txtCognomeF1 = new System.Windows.Forms.TextBox();
            this.txtForm1 = new System.Windows.Forms.TextBox();
            this.btnInviaAFiglia = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(179, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSecondariaToolStripMenuItem,
            this.newFigliaToolStripMenuItem,
            this.newMDIToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // newSecondariaToolStripMenuItem
            // 
            this.newSecondariaToolStripMenuItem.Name = "newSecondariaToolStripMenuItem";
            this.newSecondariaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.newSecondariaToolStripMenuItem.Text = "New Secondaria";
            this.newSecondariaToolStripMenuItem.Click += new System.EventHandler(this.newSecondariaToolStripMenuItem_Click);
            // 
            // newFigliaToolStripMenuItem
            // 
            this.newFigliaToolStripMenuItem.Name = "newFigliaToolStripMenuItem";
            this.newFigliaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.newFigliaToolStripMenuItem.Text = "New Figlia";
            this.newFigliaToolStripMenuItem.Click += new System.EventHandler(this.newFigliaToolStripMenuItem_Click);
            // 
            // newMDIToolStripMenuItem
            // 
            this.newMDIToolStripMenuItem.Name = "newMDIToolStripMenuItem";
            this.newMDIToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newMDIToolStripMenuItem.Text = "New MDI";
            this.newMDIToolStripMenuItem.Click += new System.EventHandler(this.newMDIToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(139, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cognome:";
            // 
            // txtNomeF1
            // 
            this.txtNomeF1.Enabled = false;
            this.txtNomeF1.Location = new System.Drawing.Point(68, 22);
            this.txtNomeF1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomeF1.Name = "txtNomeF1";
            this.txtNomeF1.ReadOnly = true;
            this.txtNomeF1.Size = new System.Drawing.Size(76, 20);
            this.txtNomeF1.TabIndex = 3;
            // 
            // txtCognomeF1
            // 
            this.txtCognomeF1.Enabled = false;
            this.txtCognomeF1.Location = new System.Drawing.Point(68, 44);
            this.txtCognomeF1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCognomeF1.Name = "txtCognomeF1";
            this.txtCognomeF1.ReadOnly = true;
            this.txtCognomeF1.Size = new System.Drawing.Size(76, 20);
            this.txtCognomeF1.TabIndex = 4;
            // 
            // txtForm1
            // 
            this.txtForm1.Location = new System.Drawing.Point(11, 104);
            this.txtForm1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtForm1.Name = "txtForm1";
            this.txtForm1.Size = new System.Drawing.Size(76, 20);
            this.txtForm1.TabIndex = 5;
            // 
            // btnInviaAFiglia
            // 
            this.btnInviaAFiglia.Location = new System.Drawing.Point(92, 104);
            this.btnInviaAFiglia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInviaAFiglia.Name = "btnInviaAFiglia";
            this.btnInviaAFiglia.Size = new System.Drawing.Size(73, 36);
            this.btnInviaAFiglia.TabIndex = 6;
            this.btnInviaAFiglia.Text = "Invia A Figlia";
            this.btnInviaAFiglia.UseVisualStyleBackColor = true;
            this.btnInviaAFiglia.Click += new System.EventHandler(this.btnInviaAFiglia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 150);
            this.Controls.Add(this.btnInviaAFiglia);
            this.Controls.Add(this.txtForm1);
            this.Controls.Add(this.txtCognomeF1);
            this.Controls.Add(this.txtNomeF1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSecondariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFigliaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeF1;
        private System.Windows.Forms.TextBox txtCognomeF1;
        private System.Windows.Forms.ToolStripMenuItem newMDIToolStripMenuItem;
        private System.Windows.Forms.TextBox txtForm1;
        private System.Windows.Forms.Button btnInviaAFiglia;
    }
}

