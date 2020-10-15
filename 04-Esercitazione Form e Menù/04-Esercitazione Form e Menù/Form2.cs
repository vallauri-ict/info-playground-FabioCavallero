using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Esercitazione_Form_e_Menù
{
    public partial class Form2 : Form
    {
        public string nome;
        public string cognome;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            nome = txtNomeF2.Text;
            cognome = txtCognomeF2.Text;
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            nome = "";
            cognome = "";
        }
    }
}
