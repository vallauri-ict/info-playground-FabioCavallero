using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_MultiForm_con_MenuStrip
{
    public partial class Form2 : Form
    {
        int parametro;
        TextBox txtPassataDaFormFiglia;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int parametro)
        {
            InitializeComponent();
            this.parametro = parametro;
        }

        public Form2(TextBox txtPassataDaFormFiglia)
        {
            InitializeComponent();
            this.txtPassataDaFormFiglia = txtPassataDaFormFiglia;
            txtForm2.Text = txtPassataDaFormFiglia.Text;
        }

        private void btnLeggiParametro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Il Parametro Passato A Questa Form E': " + parametro.ToString());
        }

        private void btnInviaAFFiglia_Click(object sender, EventArgs e)
        {
            txtPassataDaFormFiglia.Text = txtForm2.Text;
        }
    }
}
