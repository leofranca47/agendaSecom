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
    public partial class cadTecnico : Form
    {
        public cadTecnico()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text == "")
                {
                    MessageBox.Show("Preencha os campos para salvar o cliente!");
                }
                else
                {
                    classTecnico cli = new classTecnico() { Tecnico = txtNome.Text};

                    //verifica cliente cadastrado
                    string pesquisaCli = "select * from dbo.tecnico where nome = '" + cli.Tecnico + "'";
                    if (classConexao.verifica(pesquisaCli))
                    {
                        MessageBox.Show("Cliente já existe, favor inserir o nome completo!");
                    }
                    else
                    {
                        string query = "INSERT INTO dbo.tecnico (nome) VALUES ('" + cli.Tecnico + "')";
                        classConexao.crud(query);

                        MessageBox.Show("Salvo com sucesso!");

                        LimpaTela();
                    }


                }


            }
            catch (Exception a)
            {

                MessageBox.Show(a.ToString());
            }
        }

        private void LimpaTela()
        {
            txtNome.Clear();
        }
    }
}
