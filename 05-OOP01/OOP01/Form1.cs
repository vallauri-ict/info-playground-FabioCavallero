using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOP01
{
    public partial class Form1 : Form
    {
        Rectangle r;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreaRettangolo_Click(object sender, EventArgs e)
        {
            /*
            r.side1 = Convert.ToInt32(txtBase.Text);
            r.side2 = Convert.ToInt32(txtAltezza.Text);
            Rectangle t;
            t = r;  // t punta all'area di memoria a cui punta r
            // visualizzo gli stessi dati sia per r che per t perché puntano alla stessa area di mem
            MessageBox.Show("Base: "+r.side1+"\nAltezza: "+r.side2);
            MessageBox.Show("Per l'oggetto t\nBase: "+ t.side1 + "\nAltezza: " + t.side2);
            t.side1 = 10;   // modifico il valore di t, si modifica anche quello di r
            MessageBox.Show("Oggetto r dopo le modifiche\nBase: " + r.side1 + "\nAltezza: " + r.side2);
            */

            r = new Rectangle(Convert.ToInt32(txtBase.Text), Convert.ToInt32(txtAltezza.Text));
            r.colore = Color.White;
            MessageBox.Show(r.getSide());   // ho valorizzato i valori nel costruttore, appariranno quelli nella mbox indipendentemente dal vallore che ho inserito nelle txt
            MessageBox.Show(r.getSide());

            r = new Rectangle();    // richiamo il costruttore senza parametri che richiama l'altro costruttore a cui passa l,l
            r.colore = Color.White;
            MessageBox.Show(r.getSide());
        }

        private void btnNFattura_Click(object sender, EventArgs e)
        {
            Fatture.visualizza();
        }

        private void btnCreaFattura_Click(object sender, EventArgs e)
        {
            Fatture f = new Fatture();
            MessageBox.Show("Fattura creata!");
        }

        private void btnClasseStatica_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pigreco " + MiaMath.pi + "\n3 x 4 = " + MiaMath.prodotto(3, 4));
        }
    }
}
