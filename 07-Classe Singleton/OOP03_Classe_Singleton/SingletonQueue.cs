namespace OOP03_Classe_Singleton
{
    class EsSingleton
    {
        public int val;
        private static EsSingleton instance = null;

        // il costruttore private lo devo creare a mano
        private EsSingleton()
        {

        }

        public EsSingleton(int val)
        {
            // non posso usare il this con una variabile statica (EsSingleton.val=val)
            this.val = val;
        }

        public static EsSingleton GetEsSingleton(int valore)
        {
            if (instance == null)
            {
                instance = new EsSingleton(valore);
            }
            else
            {
                instance.val = valore;  // per modificare il valore se lo cambio
            }
            return instance;
        }
    }
}
