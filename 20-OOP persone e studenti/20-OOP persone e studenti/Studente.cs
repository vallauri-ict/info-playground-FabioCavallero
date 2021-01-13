using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_OOP_persone_e_studenti
{
    class Studente: Persona
    {
        List<int> voti = new List<int>();
        public double media()
        {
            int sommaVoti = 0;
            foreach (var item in voti)
            {
                sommaVoti += item;
            }
            return (double)sommaVoti/voti.Count;
        }
    }
}
