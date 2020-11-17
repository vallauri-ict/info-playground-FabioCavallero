using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace regex01_Registrazione_Form
{
    class Utenti
    {
        private static Utenti instance = null;
        public static Utenti GetUtenti()
        {
            if (instance == null)
            {
                instance = new Utenti();
            }
            return instance;
        }

        public bool controllaUsername(string username)
        {
            bool presente = false;
            StreamReader sr = new StreamReader("utenti.txt");
            string s;
            string[] dato = new string[9];
            while ((sr.Peek() != -1) && (!presente))
            {
                s = sr.ReadLine();
                dato = s.Split('-');
                if (dato[7] == username)  //ho trovato l'username
                    presente = true;
            }
            sr.Close();
            return presente;
        }
        public void creaFile(string cognome, string nome, string indirizzo, string città, string CAP, string mail, string codiceFiscale, string username, string password)
        {
            string s = $"{cognome}-{nome}-{indirizzo}-{città}-{CAP}-{mail}-{codiceFiscale}-{username}-{password}";
            StreamWriter sw = new StreamWriter("utenti.txt", true);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
        }
    }
}
