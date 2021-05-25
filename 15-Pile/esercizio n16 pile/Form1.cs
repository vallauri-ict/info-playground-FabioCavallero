using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esercizio_n16_pile
{
    public partial class Form1 : Form
    {
        public struct Containers
        {
            public int codice;
            public int peso;
            public int tara;
        }
        Stack<Containers> pila = new Stack<Containers>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            Containers container;
            container.codice = Convert.ToInt32(textBox1.Text);
            container.peso = Convert.ToInt32(textBox2.Text);
            container.tara = Convert.ToInt32(textBox3.Text);

            pila.Push(container);
            MessageBox.Show("elemento inserito nello stack");
        }

        private void btnEstrai_Click(object sender, EventArgs e)
        {
            try
            {
                Containers estratto = pila.Pop();
                MessageBox.Show("codice: "+estratto.codice+"\npeso: "+estratto.peso + "\nTara" +estratto.tara);
            }
            catch (Exception)
            {
                MessageBox.Show("nessuna pila");
            }
        }
    }
}
