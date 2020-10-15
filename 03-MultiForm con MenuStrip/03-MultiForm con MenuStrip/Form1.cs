using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_MultiForm_con_MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void apriForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Text = "Form 2 Senza Parametro";
            Form2.Show();

            Form2 Form2P = new Form2(10);
            Form2P.Text = "Form 2 Con Parametro";
            Form2P.Show();

            statusStripLbl.Text = "Premuto Apri Form 2";
        }

        private void apriForm2BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form F2B = new Form(); // senza utilizzare classi
            F2B.Text = "Aperta Form Dinamica";
            F2B.Show();

            statusStripLbl.Text = "Premuto Apri Form 2B";
        }

        private void passaTestoAForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Figlia FormFiglia = new Figlia();
            FormFiglia.Text = "Passa Un Testo A Form 2";
            FormFiglia.MdiParent = this;
            FormFiglia.Show();

            statusStripLbl.Text = "Premuto Passa Testo A Form 2";
        }

        private void apriFormModaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Figlia2 Figlia2 = new Figlia2();
            Figlia2.MdiParent = this;
            Figlia2.Show();

            statusStripLbl.Text = "Premuto Apri Form Modale";
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menùToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStripLbl.Text = "Premuto Menù";
        }
    }
}
