using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace agendaManuSecom
{
    class classCrud
    {
        public int Salvar(string[] campos, string[] valores, string sqlIncluir)
        {
            int regAfetados = -1;
            try
            {
                SqlCommand cmd = new SqlCommand(sqlIncluir, classConexao.conectar());
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlIncluir;

                for (int i = 0; i < valores.Length; i++)
                {
                    cmd.Parameters.AddWithValue(campos[i], valores[i]);
                }

                regAfetados = cmd.ExecuteNonQuery();
                return regAfetados;
                
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            finally
            {
                classConexao.fechar();
            }
        }

        public int Deletar(string[] campos, string[] valores, string sqlDeletar)
        {
            int regAfetados = -1;
            try
            {
                SqlCommand cmd = new SqlCommand(sqlDeletar, classConexao.conectar());
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlDeletar;

                for (int i = 0; i < valores.Length; i++)
                {
                    cmd.Parameters.AddWithValue(campos[i], Convert.ToInt32(valores[i]));
                }

                regAfetados = cmd.ExecuteNonQuery();
                return regAfetados;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                classConexao.fechar();
            }
        }

        public DataTable getRegistro(string sql, DataGridView grid = null)
        {

            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, classConexao.conectar());
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                

                if (grid != null)
                {
                    // elimina a linha em branco do datagrid
                    grid.AllowUserToAddRows = false;

                    //cor sim cor não no datagrid
                    grid.RowsDefaultCellStyle.BackColor = Color.LightBlue;
                    grid.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                    
                }

                return dt;
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                classConexao.fechar();
            }
        }

        public void PreencheCombo(ComboBox cb, string tabela, string nome, string id)
        {
            cb.DataSource = getRegistro("select * from " + tabela + "");
            cb.DisplayMember = nome;
            cb.ValueMember = id;
        }

        public string [] returnValue(string query, string [] campo )
        {
            string [] retorno = new string[campo.Length] ;
            SqlCommand cmd = new SqlCommand(query, classConexao.conectar());
            SqlDataReader ler = cmd.ExecuteReader();

            if (ler.HasRows)
            {
                ler.Read();

                for (int i = 0; i < campo.Length; i++)
                {
                    retorno[i] = ler[campo[i]].ToString();
                }

                
            }


            return retorno;
        }

        public string sumValue(string query)
        {
            string value;
            try
            {
                SqlCommand cmd = new SqlCommand(query, classConexao.conectar());

                value = cmd.ExecuteScalar().ToString();

                if (value != "")
                {
                    value = Convert.ToDouble(value).ToString();   
                    return value;
                }
                else
                {
                    return "0";
                }
                

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());

                throw;
            }
 
            
        }
        
    }
}
