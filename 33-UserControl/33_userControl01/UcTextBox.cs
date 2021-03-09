using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33_userControl01
{
    public partial class UcTextBox : UserControl
    {
        private bool numero = false;    // Se true la txt accetta solo numeri
        private string testo;   // Testo della txt
        private int cifreDecimali = 0;  // Contiene il numero di cifre decimali dopo la virgola
        public UcTextBox()
        {
            InitializeComponent();
        }

        public bool Numero { get => numero; set => numero = value; }
        public string Testo { get => testo = txtTesto.Text; set { testo = value; txtTesto.Text = testo; } }
        public int CifreDecimali { get => cifreDecimali; set { cifreDecimali = value; reimpostaTesto(); } }

        private void  txtTesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (numero)
            {
                if (!char.IsDigit(e.KeyChar)||e.KeyChar==','||char.IsControl(e.KeyChar))
                {

                }
            }
        }
        private void reimpostaTesto()
        {
            if (numero && testo!="")
            {
                try
                {
                    if (contaVirgola(txtTesto.Text)>1)
                    {
                        throw new Exception("Ci sono troppe virgole");
                    }
                    // Controllo dei decimali
                    double numero = Math.Round(Convert.ToDouble(testo),CifreDecimali);
                    Testo = numero.ToString();

                    // Gestione degli 00 dopo la virgola in caso di numero intero
                }
                catch (Exception ex)
                {

                    throw new Exception("Valore non valido");
                }
            }
        }

        private int contaVirgola(string t)
        {
            int count = 0;
            for (int i = 0; i < t.Length; i++)
            {
                char c = Convert.ToChar(t.Substring(i, 1));
                if (c==',')
                {
                    count++;
                }
            }
            return count;
        }
        public void pulisci()
        {
            Testo = "";
        }
    }
}
