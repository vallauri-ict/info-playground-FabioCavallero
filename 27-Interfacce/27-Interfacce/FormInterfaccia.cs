using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27_Interfacce
{
    public partial class FormInterfaccia : Form
    {
        MyComponent con = new MyComponent();
        public FormInterfaccia()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnConnetti_Click(object sender, EventArgs e)
        {
            con.connetti("Componente 1");
        }
        private void btnDisconnetti_Click(object sender, EventArgs e)
        {
            con.disconnetti("Componente 1");
        }
        private void btnStato_Click(object sender, EventArgs e)
        {
            con.Stato();
        }
    }
}