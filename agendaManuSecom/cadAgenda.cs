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
    public partial class cadAgenda : Form
    {
        classCrud crud = new classCrud();
        public cadAgenda()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNomeCliente.Text == "" || cbtecnico.Text == "")
                {
                    MessageBox.Show("Preencha os campos para salvar o agendamento!");
                }
                else
                {
                    classAgenda cli = new classAgenda() { Tecnico = Convert.ToInt32(cbtecnico.ValueMember), CodigoCliente = txtCodCliente.Text, ContaOperacional = txtContaOperacional.Text, DataAgendamento = dtpAtendimento.Value, Motivo = txtMotivo.Text, NomeCliente = txtNomeCliente.Text, Situacao = cbSituacao.Text };

                    //verifica cliente cadastrado
                    string pesquisaCli = "select * from dbo.agenda where codigo_cliente = '" + cli.CodigoCliente + "' AND data_agendamento = '"+dtpAtendimento.Value+"'";
                    if (classConexao.verifica(pesquisaCli))
                    {
                        MessageBox.Show("Cliente já existe, favor inserir o nome completo!");
                    }
                    else
                    {
                        string query = "INSERT INTO dbo.agenda (nome) VALUES ('" + cli.Tecnico + "')";
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
            txtCodCliente.Clear();
            txtContaOperacional.Clear();
            txtMotivo.Clear();
            txtNomeCliente.Clear();
            cbSituacao.Text = "AGENDADO";
        }

        private void cadAgenda_Load(object sender, EventArgs e)
        {
            cbtecnico.DataSource = null;
            crud.PreencheCombo(cbtecnico, "tecnico", "nome", "id_tecnico");
        }
    }
}
