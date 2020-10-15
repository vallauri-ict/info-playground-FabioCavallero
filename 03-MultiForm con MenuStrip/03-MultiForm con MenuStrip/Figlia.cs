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
    public partial class Figlia : Form
    {
        public Figlia()
        {
            InitializeComponent();
        }

        private void btnPassaAF2_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2(txtDaPassareAForm2);
            F2.Show();
        }
    }
}
