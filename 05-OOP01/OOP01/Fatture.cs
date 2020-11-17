using System.Windows.Forms;
namespace OOP01
{
    class Fatture
    {
        // se tolgo lo static non ho più una variabile condivisa. il suo valore ripartirà sempre da 1
        private static int cntFatture = 0;
        public readonly int nFattura;

        public Fatture()
        {
            cntFatture++;
            this.nFattura = cntFatture;
        }
        public static void visualizza()
        {
            // posso avere informazioni solo su elementi statici (es. cntFatture)
            MessageBox.Show("Numero fatture create: "+cntFatture);
            // MessageBox.Show("Numero fattura corrente: "+nFattura);  // non è statico, viene creato solo quando viene creato l'oggetto
        }
    }
}
