using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_dictionary02_negozio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public struct Dizionario
        {
            public string articolo;
        }
        Dictionary<int, Dizionario> dictionary = new Dictionary<int, Dizionario>();

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            Dizionario d;

            d.articolo = txtArticolo.Text;

            dictionary.Add(Convert.ToInt32(txtKey.Text), d);
            MessageBox.Show("Articolo inserito correttamente");
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            lblElementi.Text = $"Numero elementi: {dictionary.Count()}";
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            lblArticolo.Text = $"Articolo cercato: {dictionary[Convert.ToInt32(txtKey.Text)].articolo}";
        }
    }
}
