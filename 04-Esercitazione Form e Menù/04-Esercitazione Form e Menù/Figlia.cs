using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Esercitazione_Form_e_Menù
{
    public partial class Figlia : Form
    {
        TextBox txtForm1;
        TextBox txtACuiInviare;

        public Figlia(TextBox txtForm1)
        {
            InitializeComponent();
            this.txtForm1 = txtForm1;
            txtFiglia.Text = this.txtForm1.Text;
            txtACuiInviare = txtForm1;
        }

        private void btnInviaAForm1_Click(object sender, EventArgs e)
        {
            txtACuiInviare.Text = txtFiglia.Text;
        }
    }
}
