using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _28_Interfaccia_comparabile
{
    public partial class Intefaccia : Form
    {
        Persona[] vet = { new Persona("Luca", "Bonelli", "Fossano"), new Persona("Antonio", "Ariaudo", "Alba"), new Persona("Zeta", "Kappa", "Bra") };
        public Intefaccia()
        {
            InitializeComponent();
            showPersona();
        }
        public void showPersona()
        {
            string s = "";
            foreach (var item in vet)
            {
                s += item.ToString()+"\n";
            }
            MessageBox.Show(s);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnOrdina_Click(object sender, EventArgs e)
        {
            Array.Sort(vet);
            showPersona();
        }
    }
}