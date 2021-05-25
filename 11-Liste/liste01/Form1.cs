using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace liste01
{
    public partial class Form1 : Form
    {
        public struct Libro
        {
            public int ID;
            public string Titolo;
            public string Autore;
        }
        List<Libro> miaLista = new List<Libro>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Libro l;

            l.ID = Convert.ToInt32(txtId.Text);
            l.Titolo = txtTitolo.Text;
            l.Autore = txtAutore.Text;

            miaLista.Add(l);
            MessageBox.Show("Libro aggiunto alla lista");
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            string s = "";
            foreach (var elemento in miaLista)
            {
                s += elemento.Titolo + "\n";
            }
            MessageBox.Show(s);
        }

        public class Book
        {
            public int ID;
            public string Title;
            public string Author;
            public Book(int id, string title, string author)
            {
                this.ID = id;
                this.Title = title;
                this.Author = author;
            }
        }

        List<Book> collectionbook = new List<Book>();
        private void btnAggiungiOggetto_Click(object sender, EventArgs e)
        {
            Book b = new Book(Convert.ToInt32(txtId.Text), txtTitolo.Text, txtAutore.Text);
            collectionbook.Add(b);

            MessageBox.Show("Libro aggiunto alla lista");
        }

        private void btnVisualizzaOggetti_Click(object sender, EventArgs e)
        {
            string s = "";
            foreach (var elemento in collectionbook)
            {
                s += elemento.Title + "\n";
            }
            MessageBox.Show(s);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Book ris = collectionbook.Find(bf => bf.Title == txtFind.Text);
            MessageBox.Show($"Il libro '{txtFind.Text}' è di {ris.Author}");
        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            List<Book> collectionAppoggio = new List<Book>();
            collectionAppoggio = collectionbook.FindAll(bf => bf.Author == txtFind.Text);

            string s = "";
            foreach (var elemento in collectionAppoggio)
            {
                s += elemento.Title + "\n";
            }
            MessageBox.Show(s);
        }
    }
}
