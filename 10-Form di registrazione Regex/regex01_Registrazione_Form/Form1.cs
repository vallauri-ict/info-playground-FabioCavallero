using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace regex01_Registrazione_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistra_Click(object sender, EventArgs e)
        {
            bool valido = true; // per controllare la validità delle regex

            // cognome
            Regex regCognome = new Regex(@"^[A-Z]{1}[a-z]+$");  // + --> 1 o più lettere minuscole
            if (txtCognome.Text == "")
            {
                MessageBox.Show("Cognome non inserito");
                valido = false;
                txtCognome.BackColor = Color.Red;   // coloro anche il campo
            }
            else if (!regCognome.IsMatch(txtCognome.Text))  // controllo se NON è valido
            {
                MessageBox.Show("Cognome NON valido");
                valido = false;
                txtCognome.BackColor = Color.Red;
            }

            // nome
            Regex regNome = new Regex(@"^[A-Z]{1}[a-z]+$");
            if (txtNome.Text == "")
            {
                MessageBox.Show("Nome non inserito");
                valido = false;
                txtNome.BackColor = Color.Red;
            }
            else if (!regNome.IsMatch(txtNome.Text))
            {
                MessageBox.Show("Nome NON valido");
                valido = false;
                txtNome.BackColor = Color.Red;
            }

            // indirizzo
            Regex regIndirizzo = new Regex(@"^[\w]{3,}\s[\w\s\d]{3,}\s[\d/]{1,}$");
            if (txtIndirizzo.Text == "")
            {
                MessageBox.Show("Indirizzo non inserito");
                valido = false;
                txtIndirizzo.BackColor = Color.Red;
            }
            else if (!regIndirizzo.IsMatch(txtIndirizzo.Text))
            {
                MessageBox.Show("Indirizzo NON valido");
                valido = false;
                txtIndirizzo.BackColor = Color.Red;
            }

            // città
            Regex regCittà = new Regex(@"^[\w\s]{3,}$");
            if (txtCittà.Text == "")
            {
                MessageBox.Show("Città non inserita");
                valido = false;
                txtCittà.BackColor = Color.Red;
            }
            else if (!regCittà.IsMatch(txtCittà.Text))
            {
                MessageBox.Show("Città NON valida");
                valido = false;
                txtCittà.BackColor = Color.Red;
            }

            // CAP
            Regex regCAP = new Regex(@"^\d{5}$");
            if (txtCAP.Text == "")
            {
                MessageBox.Show("CAP non inserito");
                valido = false;
                txtCAP.BackColor = Color.Red;
            }
            else if (!regCAP.IsMatch(txtCAP.Text))
            {
                MessageBox.Show("CAP NON valido");
                valido = false;
                txtCAP.BackColor = Color.Red;
            }

            // mail
            Regex regMail = new Regex(@"^[\w._-]+[\@][a-z]{5,}[.][a-z]{2,4}$");
            if (txtMail.Text == "")
            {
                MessageBox.Show("Indirizzo mail non inserito");
                valido = false;
                txtMail.BackColor = Color.Red;
            }
            else if (!regMail.IsMatch(txtMail.Text))
            {
                MessageBox.Show("Indirizzo mail NON valido");
                valido = false;
                txtMail.BackColor = Color.Red;
            }

            /* MAIL 
             * inizia con dei caratteri, '.', '_', '-'
             * '@'
             * alcuni caratteri
             * '.'
             * da 2 a 4 caratteri (.it / .com / .info) */

            // codice fiscale
            Regex regCodiceFiscale = new Regex(@"^[a-zA-Z]{6}[0-9]{2}[abcdehlmprstABCDEHLMPRST]{1}[0-9]{2}([a-zA-Z]{1}[0-9]{3})[a-zA-Z]{1}$");
            if (txtCodiceFiscale.Text == "")
            {
                MessageBox.Show("Codice fiscale non inserito");
                valido = false;
                txtCodiceFiscale.BackColor = Color.Red;
            }
            else if (!regCodiceFiscale.IsMatch(txtCodiceFiscale.Text))
            {
                MessageBox.Show("Codice fiscale NON valido");
                valido = false;
                txtCodiceFiscale.BackColor = Color.Red;
            }

            // username
            Regex regUsername = new Regex(@"^[\w\d._]+$");
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Username non inserito");
                valido = false;
                txtUsername.BackColor = Color.Red;
            }
            else if (!regUsername.IsMatch(txtUsername.Text))
            {
                MessageBox.Show("Username NON valido");
                valido = false;
                txtUsername.BackColor = Color.Red;
            }

            // password
            Regex regPassword = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,20}$");
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Username non inserito");
                valido = false;
                txtPassword.BackColor = Color.Red;
            }
            else if (!regPassword.IsMatch(txtPassword.Text))
            {
                MessageBox.Show("Username NON valido");
                valido = false;
                txtPassword.BackColor = Color.Red;
            }

            if (valido)
            {
                Utenti u = Utenti.GetUtenti();
                bool presente = u.controllaUsername(txtUsername.Text);
                if (!presente)
                {
                    u.creaFile(txtCognome.Text, txtNome.Text, txtIndirizzo.Text, txtCittà.Text, txtCAP.Text, txtMail.Text, txtCodiceFiscale.Text, txtUsername.Text, txtPassword.Text);
                    MessageBox.Show("Registrazione completata con successo");
                    pulisci();
                }
                else
                {
                    MessageBox.Show("Username già presente");
                    txtUsername.Text = "";
                    txtUsername.BackColor = Color.Red;
                }
            }
        }

        private void pulisci()
        {
            txtCognome.Text = "";
            txtCognome.BackColor = Color.White;
            txtNome.Text = "";
            txtNome.BackColor = Color.White;
            txtIndirizzo.Text = "";
            txtIndirizzo.BackColor = Color.White;
            txtCittà.Text = "";
            txtCittà.BackColor = Color.White;
            txtCAP.Text = "";
            txtCAP.BackColor = Color.White;
            txtMail.Text = "";
            txtMail.BackColor = Color.White;
            txtCodiceFiscale.Text = "";
            txtCodiceFiscale.BackColor = Color.White;
            txtUsername.Text = "";
            txtUsername.BackColor = Color.White;
            txtPassword.Text = "";
            txtPassword.BackColor = Color.White;
        }
    }
}
