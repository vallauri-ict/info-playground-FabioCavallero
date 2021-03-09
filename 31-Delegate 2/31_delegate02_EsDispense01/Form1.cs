using System;
using System.Windows.Forms;

namespace _31_delegate02_EsDispense01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            GestoreSalvataggio gest = new GestoreSalvataggio();
            gest.salvataggioEseguito += new salvataggioEseguitoEventHandler(miaFunzione);
            gest.salvataggioEseguito += new salvataggioEseguitoEventHandler(miaFunzione2);  // Posso aggiungerne quanti ne voglio
            gest.SalvaSuFile(5);
        }

        private void miaFunzione2(int id)
        {
            MessageBox.Show("Secondo gestore di evento");
        }

        private void miaFunzione(int id)
        {
            MessageBox.Show("Elemento " + id + " salvato correttamente");
        }
    }
}
