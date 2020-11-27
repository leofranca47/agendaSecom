using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace agendaManuSecom
{
    class classConexao
    { 
        //acesso local 
        private static string StringConexao = @"Server=localhost\SQLEXPRESS ;Database=agenda_secom; User ID=sa;Password= 8804";
        //acesso rede bela gula
        //private static string StringConexao = @"Server=192.168.1.8 ;Database=easy_caixa; User ID=sa;Password= 8804";

        private static SqlConnection conn;
       

        public static SqlConnection conectar()
        {
            try
            {
                conn = new SqlConnection(StringConexao);

                conn.Open();

            }
            catch (Exception error)
            {
                //Log log = new Log();
                //log.gravaLog("Conexao ao banco de dados!", error.ToString());
                MessageBox.Show("conexao nao realizada");
            }
            
            
            return conn;
               

        }
        public static SqlConnection fechar()
        {
            try
            {
                
                conn.Close();

            }
            catch (Exception error)
            {
                //Log log = new Log();
                //log.gravaLog("Erro ao fechar a conexao banco de dados!", error.ToString());
                MessageBox.Show("Falha ao fechar a conexao de bancode dados");
            }
            return conn;


        }
        //preenche datagrid view

        public static void preenche_grid(DataGridView grid, string cmd)
        {
            try
            {
                string query = cmd;
                SqlCommand busca = new SqlCommand(query, conectar());
                SqlDataAdapter da = new SqlDataAdapter(busca);
                DataTable preenche = new DataTable();
                da.Fill(preenche);
                grid.DataSource = preenche;
                



                // elimina a linha em branco do datagrid
                grid.AllowUserToAddRows = false;

                //cor sim cor não no datagrid
                grid.RowsDefaultCellStyle.BackColor = Color.LightBlue;
                grid.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                
            }
            catch (Exception er)
            {
                //Log log = new Log();
                //log.gravaLog("preenche grid", er.ToString());
            }
            finally
            {
                classConexao.fechar();
            }

        }


        public static bool verifica(string query)
        {
            bool a;
            string query1 = query;
            SqlCommand cmd = new SqlCommand(query1, conectar());
            int cont = 0;
            if (conn.State == ConnectionState.Open)
            {
                cont = Convert.ToInt32(cmd.ExecuteScalar());
            }
           
            

            if (cont > 0)
            {
                a = true;

                return a;

            }
            else { a = false; return a; }


        }

        //moeda

        public static void Moeda(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;

            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;


            }
            catch (Exception error)
            {
                //Log log = new Log();
                //log.gravaLog("Erro na mascara de moeda!", error.ToString());

                throw new Exception("Insira somente numeros por favor");
            }
        }
        public static bool crud(string query)
        {
            
            SqlCommand cmd = new SqlCommand(query, conectar());
            cmd.CommandType = CommandType.Text;
            try
            {
                int retorno = cmd.ExecuteNonQuery();
                if (retorno > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }catch(Exception error){
                //Log log = new Log();
                //log.gravaLog("Erro  no  metodo crud!", error.ToString());
                throw new Exception("Ocorreu algum erro! Consulte o suporte");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    fechar();   
                }
                
            }

        }

        public static bool criaBanco(string query)
        {

            SqlCommand cmd = new SqlCommand(query, conectar());
            cmd.CommandType = CommandType.Text;
            try
            {
                int retorno = cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception error)
            {
                //Log log = new Log();
                //log.gravaLog("Erro  no  metodo crud!", error.ToString());
                throw new Exception("Ocorreu algum erro! Consulte o suporte");
            }
            finally
            {
                classConexao.fechar();
            }

        }

        public static bool existeUsuario(string usuario)
        {
            bool retorno;
            string sql = "SELECT usuario FROM easy_caixa.usuarios WHERE usuario = '" + usuario + "'";
            SqlCommand cmd = new SqlCommand(sql, conectar());
            SqlDataReader read = cmd.ExecuteReader();
            
            if (read.Read())
            {
                retorno = true;
            }
            else
            {
                retorno = false;
            }
            classConexao.fechar();
            return retorno;
        }

        public static void limpar(Control controles)
        {
            foreach (Control ctl in controles.Controls)
            {

                if (ctl.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    ((TextBox)ctl).Text = String.Empty;
                }
                limpar(ctl);
                
               

            }
            
        }


        

        

    }
    
    
}
