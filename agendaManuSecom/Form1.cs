using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agendaManuSecom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tECNICOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["cadTecnico"] == null)
            {
                cadTecnico produto = new cadTecnico();
                produto.Show();
            }
            else
            {
                MessageBox.Show("Tela já aberta");
            }
        }

        private void aGENDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["cadAgenda"] == null)
            {
                cadAgenda produto = new cadAgenda();
                produto.Show();
            }
            else
            {
                MessageBox.Show("Tela já aberta");
            }
        }
    }
}
