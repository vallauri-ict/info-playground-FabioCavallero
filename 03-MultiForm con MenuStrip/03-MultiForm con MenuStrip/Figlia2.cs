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
    public partial class Figlia2 : Form
    {
        public Figlia2()
        {
            InitializeComponent();
        }

        private void btnApriFModale_Click(object sender, EventArgs e)
        {
            FormModale fm = new FormModale();
            // si apre la form su ShowDialog()
            if (fm.ShowDialog() == DialogResult.OK)
            {
                txtNomeFModale.Text = fm.nome;
                txtEtaFModale.Text = fm.eta;
                MessageBox.Show("Premuto OK!");
            }
            else
            {
                txtNomeFModale.Text = "";
                txtEtaFModale.Text = "";
                MessageBox.Show("Premuto Annulla!");
            }
        }
    }
}
