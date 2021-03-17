using System;
using System.Windows.Forms;

namespace _4_035_UsoUserControl
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void chkNum_CheckedChanged(object sender, EventArgs e)
        {
            txtMiaText.Numero = chkNum.Checked;
        }

        private void numCifreDec_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtMiaText.CifreDecimali = Convert.ToInt32(numCifreDec.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPulisci_Click(object sender, EventArgs e)
        {
            txtMiaText.PulisciTxt();
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtMiaText.Testo);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ImpostaProperty(false);
        }

        private void ImpostaProperty(bool numero)
        {
            try
            {
                txtMiaText.PulisciTxt();
                numCifreDec.Value = 0;
                chkNum.Checked = numero;
                txtMiaText.Numero = numero;
                txtMiaText.CifreDecimali = Convert.ToInt32(numCifreDec.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
