using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(); // dichiarazione form2
            f2.Text = "Aperto Senza Parametro";
            f2.Show(); // visualizza form

            Form2 f2b = new Form2(10);
            f2b.Text = "Aperto Con Parametro";
            f2b.Show();
        }

        private void btnForm2B_Click(object sender, EventArgs e)
        {
            Form f2b = new Form(); // senza utilizzare classi
            f2b.Text = "Aperta Form Dinamica";
            f2b.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPassa_Click(object sender, EventArgs e)
        {
            Form2 f2b = new Form2(txtPassata);
            f2b.Text = "Form 2 con passaggio di textbox";
            f2b.Show();
        }

        private void btnFormModale_Click(object sender, EventArgs e)
        {
            FormModale fm = new FormModale();
            // si apre la form su ShowDialog()
            if (fm.ShowDialog() == DialogResult.OK)
            {
                txtNomeFM.Text = fm.nome;
                txtEtaFM.Text = fm.eta;
                MessageBox.Show("Premuto OK!");
            }
            else
            {
                txtNomeFM.Text = "";
                txtEtaFM.Text = "";
                MessageBox.Show("Premuto Annulla!");
            }
        }
    }
}
