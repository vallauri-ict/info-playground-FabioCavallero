using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ospedale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct paziente
        {
            public string nome;
            public int eta;
            public string colore;
            public float temperatura;
        }
        List<paziente> elenco = new List<paziente>();

        //dichiarazione code
        public static Queue<string> rosso = new Queue<string>();
        public static Queue<string> giallo = new Queue<string>();
        public static Queue<string> verde = new Queue<string>();
        public static Queue<string> bianco = new Queue<string>();

        //dichiarazione temperatura max e min;
        string nomePaziente = "";
        float max = 0;
        string _max="";
        string _min="";
        float min = 100;

        private void BtnInserisci_Click(object sender, EventArgs e)
        {
            paziente p;
            p.nome = txtnome.Text;
            p.eta = Convert.ToInt32(txtEtà.Text);
            p.colore = cmbCodice.Text;
            nomePaziente = p.nome;
            switch (p.colore)
            {
                case "Rosso":
                    inserisciPaziente(nomePaziente,rosso,"rosso");
                    //rosso.Enqueue(nomePaziente);
                    //MessageBox.Show("Paziente "+nomePaziente+" inserito in codice rosso");
                    break;
                case "Giallo":
                    inserisciPaziente(nomePaziente, giallo, "giallo");
                    //giallo.Enqueue(p.nome);
                    //MessageBox.Show("Paziente " + p.nome + " inserito in codice giallo");
                    break;
                case "Verde":
                    inserisciPaziente(nomePaziente, verde, "verde");
                    //verde.Enqueue(p.nome);
                    //MessageBox.Show("Paziente " + p.nome + " inserito in codice verde");
                    break;
                case "Bianco":
                    inserisciPaziente(nomePaziente, bianco, "bianco");
                    //bianco.Enqueue(p.nome);
                    //MessageBox.Show("Paziente " + p.nome + " inserito in codice bianco");
                    break;
                default:
                    break;
            }
            p.temperatura = Convert.ToInt32(txtTemperatura.Text);
            if(p.temperatura>max)
            {
                max = p.temperatura;
                _max = p.nome;
            }
            else
            {
                if(p.temperatura==max)
                {
                    _max += " " + p.nome;
                }
                else
                {
                    if(p.temperatura<min)
                    {
                        min = p.temperatura;
                        _min = p.nome;
                    }
                    else
                    {
                        if(p.temperatura==min)
                        {
                            _min += " " + p.nome;
                        }
                    }
                }
            }
            elenco.Add(p);
        }

        private void inserisciPaziente(string nome, Queue<string> coda, string codice)
        {
            coda.Enqueue(nome);
            MessageBox.Show("Paziente "+nome+" inserito in codice "+codice);
        }

        private void BtnCura_Click(object sender, EventArgs e)
        {
            string current="";
            string cod = "";
            bool fine = false;
            if(rosso.Count!=0)
            {
                current = rosso.Dequeue();
                cod = "rosso";
            }
            else
            {
                if(giallo.Count!=0)
                {
                    current = giallo.Dequeue();
                    cod = "giallo";
                }
                else
                {
                    if(verde.Count!=0)
                    {
                        current = verde.Dequeue();
                        cod = "verde";
                    }
                    else
                    {
                        if(bianco.Count!=0)
                        {
                            current = bianco.Dequeue();
                            cod = "bianco";
                        }
                        else
                        {
                            fine = true;
                        }
                    }
                }
            }
            if(!fine)
            {
                MessageBox.Show("Curato il paziente " + current + " in codice "+cod);
            }
            else
                MessageBox.Show("Pazienti finiti");
        }

        private void BtnTemperature_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La temperatura massima rilevata è "+max+" di: \n"+_max);
            MessageBox.Show("La temperatura minima rilevata è " + min + " di: \n" + _min);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            foreach (var paziente in elenco)
            {
                MessageBox.Show("Nome: "+paziente.nome+"\nEta: "+paziente.eta+"\nCodice: "+paziente.colore+"\nTemperatura: "+paziente.temperatura);
            }
        }
    }
}
