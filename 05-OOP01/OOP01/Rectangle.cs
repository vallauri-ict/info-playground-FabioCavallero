using System.Drawing;

namespace OOP01
{
    class Rectangle
    {
        // lati del rettangolo
        private int side1, side2;
        private string descrizione;
        // colore del rettangolo
        public Color colore;

        // "genera tutto" --> "deseleziona tutto" --> "ok"
        public Rectangle() : this(1)  // costruttore, deve essere scritto senza specificare cosa ritorna
        {
            // assegno dei valori ai campi private
            //side1 = 1;
            //side2 = 1;
            descrizione = "Sono un rettangolo";
        }
        public Rectangle(int l) : this(l, l)
        {

        }
        public Rectangle(int baseRettangolo, int altezzaRettangolo)
        {
            side1 = baseRettangolo;
            side2 = altezzaRettangolo;
        }
        public string getSide() // metodo per mostrare side1 e side2
        {
            return "Base: " + side1.ToString() + "\nAltezza: " + side2.ToString();
        }
    }
}
