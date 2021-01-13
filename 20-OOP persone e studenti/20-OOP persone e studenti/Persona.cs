using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _20_OOP_persone_e_studenti
{
    class Persona
    {
        private string nome, cognome, sesso;
        private int età;
        public void SetAttribute(string nome,string cognome,string sesso,int età)
        {
            if (true)//Eventuali controlli sui parametri
            {

            }
            this.nome = nome;
            this.cognome = cognome;
            this.sesso = sesso;
            this.età = età;
        }
        public string Getnome()
        {
            return this.nome;
        }
        public string GetCognome()
        {
            return this.cognome;
        }
        public string GetSesso()
        {
            return this.sesso;
        }
        public int GetEtà()
        {
            return this.età;
        }
    }
}
