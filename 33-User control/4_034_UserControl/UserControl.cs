using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_034_UserControl
{
    public partial class UserControl: System.Windows.Forms.UserControl
    {
        public UserControl()
        {
            InitializeComponent();
        }
        private bool numero = false;    //se true la txt accetta solo numeri
        private string testo; //testo della txt
        private int cifreDecimali = 0;//contiene il numero di cifre decimali (dopo la virgola)

        public bool Numero { get => numero; set => numero = value; }
        public string Testo
        {
            get => testo = txtTesto.Text; set
            {
                testo = value;
                txtTesto.Text = testo;
            }
        }
        public int CifreDecimali
        {
            get => cifreDecimali; set
            {
                cifreDecimali = value;
                ReimpostaTesto();
            }
        }

        private void ReimpostaTesto()
        {
            if (numero && Testo != "")
            {
                try
                {
                    //controllo che max 1 virgola
                    if (ContaVirgola(Testo))
                    {
                        throw new Exception("Ci sono troppe virgole");
                    }
                    //controllo decimali
                    double numero = Math.Round(Convert.ToDouble(Testo), CifreDecimali);
                    Testo = numero.ToString();

                    //gestione degli 00 dopo la virgola se num intero
                }
                catch (Exception e)
                {
                    //MessageBox.Show(e.Message);
                    throw new Exception("Valore non valido");
                }
            }
        }

        private bool ContaVirgola(string text)
        {
            int cont = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char c = Convert.ToChar(text[i]);
                if (c == ',')
                {
                    cont++;
                }
            }
            return cont > 1;
        }

        /*private void TxtTesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (numero)
            {                                     //char.IsPunctuation(e.KeyChar) //char.IsSymbol()
                if (!(char.IsDigit(e.KeyChar) || (e.KeyChar)==','||char.IsControl(e.KeyChar)))
                {
                    throw new NotImplementedException();
                }
            }
        }*/

        public void PulisciTxt()
        {
            Testo = "";
        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (Numero)
            {
                if (!(char.IsDigit(e.KeyChar) || (e.KeyChar) == ',' || char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                    //throw new Exception();
                }
            }
        }
        private void OnLeave(object sender, EventArgs e)
        {
            ReimpostaTesto();
        }
    }
}
