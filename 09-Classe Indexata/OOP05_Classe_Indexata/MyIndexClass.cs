namespace OOP05_Classe_Indexata
{
    class MyIndexClass
    {
        private string[] element;

        // Costruttore
        public MyIndexClass(int elementNumber)
        {
            // crea un vettore di *numero* elementi
            element = new string[elementNumber];
            for (int i = 0; i < elementNumber; i++)
            {
                element[i] = "empty";
            }
        }

        // Iteratore, property
        // metodo pubblico che restituisce una stringa perché la classe è una classe di stringhe
        public string this[int pos] // int pos --> parametro che metto tra le quadre quando richiamo il metodo
        {
            get { return element[pos]; }    // ritorna un valore quando si richiede un valore al vettore
            set { element[pos] = value; }   // imposta un valore all'interno del vettore alla posizione pos
        }

        // Metodo che ritorna la lunghezza
        public int length()
        {
            return element.Length;
        }
    }
}
