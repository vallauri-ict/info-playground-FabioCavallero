using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OOP06_Regex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnControllaTarga_Click(object sender, EventArgs e)
        {
            Regex rgxTarga = new Regex("^[A-Z]{2}[0-9]{3}[A-Z]{2}$");
            //string strTarga = @"^[A-Z]{2}[0-9]{3}[A-Z]{2}$";
            if (txtTarga.Text != "")
            {
                if (rgxTarga.IsMatch(txtTarga.Text))    // devo per forza mettere le lettere maiuscole
                //if (Regex.IsMatch(txtTarga.Text, strTarga, RegexOptions.IgnoreCase))  // posso mettere le lettere anche minuscole, c'è il RegexOptions.IgnoreCase
                {
                    MessageBox.Show("Targa corretta");
                    txtTarga.Text = "";
                }
                else
                {
                    MessageBox.Show("Targa non corretta");
                    txtTarga.Text = "";
                    txtTarga.Focus();
                }
            }
            else
            {
                MessageBox.Show("Compila il campo soprastante prima di verificare la validità della targa");
            }
        }

        private void btnControllaPassword_Click(object sender, EventArgs e)
        {
            Regex rgxPassword = new Regex("^[a-zA-Z]{8}\\d{3}[-?@]$");
            if (txtPassword.Text != "")
            {
                if (rgxPassword.IsMatch(txtPassword.Text))
                {
                    MessageBox.Show("Password accettata");
                    txtPassword.Text = "";
                }
                else
                {
                    MessageBox.Show("Password non accettata");
                    txtPassword.Text = "";
                    txtPassword.Focus();
                }
            }
            else
            {
                MessageBox.Show("Compila il campo soprastante prima di verificare la tua password");
            }
        }
    }
}
