using System;
using System.Windows.Forms;

namespace OOP04_Classe_Singleton_Coda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserisciElemento_Click(object sender, EventArgs e)
        {
            if (txtElemento.Text != "")
            {
                SingletonQueue s = SingletonQueue.GetSingletonQueue();
                // s.coda non si può fare perché coda non è statica e quindi è accessibile soltanto all'interno della classe SingletonQueue
                s.accodaElemento(txtElemento.Text);
                txtElemento.Text = "";
            }
            else
            {
                MessageBox.Show("Devi inserire un valore nella textbox per inserirlo nella coda.");
            }
        }

        private void btnStampaElemento_Click(object sender, EventArgs e)
        {
            SingletonQueue s = SingletonQueue.GetSingletonQueue();
            s.stampaElemento();
        }
    }
}
