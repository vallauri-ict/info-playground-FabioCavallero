using System;

namespace OOP02_Metodo_Factory
{
    class Quadrato
    {
        private int lato;

        // creo il costruttore
        private Quadrato(int lato)
        {
            this.lato = lato;
        }

        public static Quadrato creaQuadrato(int lato)
        {
            if (lato <= 0)
            {
                throw new Exception("Il lato del quadrato deve essere > di 0");
            }
            else
            {
                return new Quadrato(lato);
            }
        }
    }
}
