using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FormMDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnApriF1_Click(object sender, EventArgs e)
        {
            Figlia1 f= new Figlia1();
            f.Text = "Figlia1";
            f.MdiParent = this;
            f.Size = new Size(210,180);
            f.StartPosition = FormStartPosition.Manual; //Serve per far 
            f.Location = new Point(0,30);
            f.Show();
        }

        private void btnApriF2_Click(object sender, EventArgs e)
        {
            Figlia_2 f = new Figlia_2();
            f.Text = "Figlia_2";
            f.MdiParent = this;
            f.Size = new Size(210, 180);
            f.StartPosition = FormStartPosition.Manual; //Serve per far funzionare il posizionamento manuale
            f.Location = new Point(215, 30);
            f.Show();
        }
        private void BtnFinestreAperte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sono state aperte "+this.MdiChildren.Length+" finestre");
            foreach (Form f in this.MdiChildren)
            {
                MessageBox.Show("Finestra"+f.Text+" aperta");
            }
        }
        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModalEsci f = new ModalEsci();
            f.Text = "Uscire?";
            if (f.ShowDialog()==DialogResult.OK)
            {
                Close();
            }
        }
        private void apri1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLbl.Text = "Premuto apri 1";
        }
        private void apri2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLbl.Text = "Premuto apri 2";
        }
    }
}