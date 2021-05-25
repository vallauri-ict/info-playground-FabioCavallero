using System.Windows.Forms;

namespace _31_delegate02_EsDispense01
{
    // Dichiaro il delegate
    public delegate void salvataggioEseguitoEventHandler(int id);

    class GestoreSalvataggio
    {
        // Dichiaro l'evento
        public event salvataggioEseguitoEventHandler salvataggioEseguito;

        public void SalvaSuFile(int id)
        {
            MessageBox.Show("Sto eseguendo il salvataggio");
            salvataggioEseguito(id);
        }
    }
}
