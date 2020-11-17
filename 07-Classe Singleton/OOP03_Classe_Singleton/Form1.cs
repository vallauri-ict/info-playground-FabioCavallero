using System;
using System.Windows.Forms;

namespace OOP03_Classe_Singleton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreaClasse_Click(object sender, EventArgs e)
        {
            // essendo un metodo non devo fare la new
            EsSingleton s = EsSingleton.GetEsSingleton(Convert.ToInt32(txtValore.Text));
            MessageBox.Show("Valore = " + s.val);
            EsSingleton s1 = EsSingleton.GetEsSingleton(0);
            MessageBox.Show("Valore di s1 = " + s1.val);
            MessageBox.Show("Valore di s = " + s.val);  // il valore di s è uguale a quello di s1
        }
    }
}
