using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dictionary01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct Libro
        {
            public string titolo;
            public string autore;
        }
        public int i = 0;
        Dictionary<int, Libro> dizionarioLibri = new Dictionary<int, Libro>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Libro l;
            l.titolo = txtTitolo.Text;
            l.autore = txtAutore.Text;

            dizionarioLibri.Add(i,l);
            i++;
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            // stampa gli indici degli elementi presenti all'interno di dizionarioLibro
            foreach (var key in dizionarioLibri.Keys)
            {
                MessageBox.Show(key.ToString());
            }

            // stampa il titolo e l'autore dei libri che ho inserito
            foreach (Libro l in dizionarioLibri.Values)
            {
                MessageBox.Show($"{l.titolo} {l.autore}");
            }
        }
    }
}
