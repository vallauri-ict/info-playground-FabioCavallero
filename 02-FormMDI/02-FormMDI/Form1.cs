using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_FormMDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApriF1_Click(object sender, EventArgs e)
        {
            Figlia1 F1 = new Figlia1();
            F1.Text = "Figlia 1";
            F1.MdiParent = this;
            F1.Size = new Size(210, 180);
            // serve x fare posizionamento da codice
            F1.StartPosition = FormStartPosition.Manual;
            F1.Location = new Point(0, 30);
            F1.Show();
        }

        private void btnApriF2_Click(object sender, EventArgs e)
        {
            Figlia2 F2 = new Figlia2();
            F2.Text = "Figlia 2";
            F2.MdiParent = this;
            F2.Size = new Size(210, 180);
            // serve x fare posizionamento da codice
            F2.StartPosition = FormStartPosition.Manual;
            F2.Location = new Point(215, 30);
            F2.Show();
        }

        private void btnFAperte_Click(object sender, EventArgs e)
        {
            // MdiChildren.length = numero di finestre aperte
            MessageBox.Show("Sono state aperte " + this.MdiChildren.Length + " finestre");
            foreach (Form F in this.MdiChildren)
            {
                MessageBox.Show("Finestra " + F.Text + " aperta");
            }
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModalEsci ME = new ModalEsci();
            ME.Text = "Uscire?";
            if (ME.ShowDialog() == DialogResult.Yes)
            {
                Close();
            }
        }

        private void apri1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLbl.Text = "Premuto Apri 1";
        }

        private void apri2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLbl.Text = "Premuto Apri 2";
        }
    }
}
