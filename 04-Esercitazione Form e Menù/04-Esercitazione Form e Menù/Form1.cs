using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _04_Esercitazione_Form_e_Menù
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void newSecondariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            if(F2.ShowDialog() == DialogResult.OK)
            {
                txtNomeF1.Text = F2.nome;
                txtCognomeF1.Text = F2.cognome;
                MessageBox.Show("Operazione Eseguita Con Successo");
            }
            else
            {
                txtNomeF1.Text = F2.nome;
                txtCognomeF1.Text = F2.cognome;
                MessageBox.Show("Operazione Annullata");
            }
        }
        private void newFigliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Figlia Figlia = new Figlia(txtForm1);
            Figlia.Show();
        }
        private void btnInviaAFiglia_Click(object sender, EventArgs e)
        {
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void newMDIToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}