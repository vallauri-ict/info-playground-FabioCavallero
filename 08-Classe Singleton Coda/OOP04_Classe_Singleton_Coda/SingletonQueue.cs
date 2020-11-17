using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OOP04_Classe_Singleton_Coda
{
    class SingletonQueue
    {
        private static SingletonQueue instance = null;

        // La coda non deve essere dichiarata statica perché deve essere accessibile solo all'interno della classe
        private Queue<string> coda = new Queue<string>();

        private SingletonQueue()
        {

        }

        public static SingletonQueue GetSingletonQueue()
        {
            if (instance == null)
            {
                instance = new SingletonQueue();
            }
            return instance;
        }

        public void accodaElemento(string valore)
        {
            coda.Enqueue(valore);
        }

        public void stampaElemento()
        {
            // Controllo se sono presenti degli elementi all'interno della coda
            if (coda.Any())
            {
                MessageBox.Show($"Eliminato l'elemento '{coda.Dequeue()}' dalla coda");
            }
            else
            {
                MessageBox.Show("Non ci sono elementi nella coda.");
            }
        }
    }
}
