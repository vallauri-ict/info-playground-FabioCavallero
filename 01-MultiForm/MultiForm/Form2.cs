using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiForm
{
    public partial class Form2 : Form
    {
        private int n;
        private TextBox txt1;

        // il costruttore ha lo stesso nome della form e non ha il parametro
        public Form2()
        {
            InitializeComponent();
        }

        // IL COSTRUTTORE HA LO STESSO NOME, MA QUANDO DEVE ENTRARE IN UNA DELLE
        // DUE SCEGLIE QUELLA CON LO STESSO PARAMETRO   

        public Form2(int n)
        {
            InitializeComponent();
            // this.n è la variabile dell'oggetto del form2
            this.n = n; // this = oggetto della form2
                        // form2 è la classe e l'oggetto è un'istanza di form2
        }

        public Form2(TextBox txt1)
        {
            InitializeComponent();
            this.txt1 = txt1;
        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnLeggiValore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valore = " + n.ToString());
        }

        private void btnInviaF1_Click(object sender, EventArgs e)
        {
            txt1.Text = txtForm2.Text;
        }

        private void btnFormFiglia_Click(object sender, EventArgs e)
        {
            FormFiglia f = new FormFiglia();
            this.AddOwnedForm(f); // per aggiungere una form figlia che quando il padre viene ridotta ad icona viene anch'essa ridotta
            f.Show();
        }
    }
}
