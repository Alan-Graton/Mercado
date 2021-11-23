using ConexaoSQL;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PedidosDAL
    {
        public string CadastrarPedidos(Pedidos pedidos)
        {
            string procedureExito = "";
            try
            {
                SqlConnection connection = new StrConexao().GetConnection();
                SqlCommand sqlProcedure = new SqlCommand("RealizarPedidos", connection);
                sqlProcedure.CommandType = System.Data.CommandType.StoredProcedure;

                sqlProcedure.Parameters.Add("NomeProduto", SqlDbType.VarChar).Value = pedidos.Nome;
                sqlProcedure.Parameters.Add("CategoriaProduto", SqlDbType.VarChar).Value = pedidos.Categoria;

                sqlProcedure.ExecuteNonQuery();

                return procedureExito = "Produto Cadastrado com Sucesso!";
            }
            catch (SqlException err)
            {
                throw new Exception(err.Message);
            }
        }

        public List<Pedidos> ListarProdutos(out string listagemExito)
        {
            List<Pedidos> pedidosListados = new List<Pedidos>();
            SqlConnection connection = new StrConexao().GetConnection();
            try
            {
                string query = "SELECT * from TB_Pedidos";
                SqlCommand comando = new SqlCommand(query, connection);
                SqlDataReader result = comando.ExecuteReader();
                while (result.Read())
                {
                    pedidosListados.Add(new Pedidos()
                    {
                        Nome = result["NomeProduto"].ToString(),
                        Categoria = result["CategoriaProduto"].ToString()
                    });
                }

                listagemExito = "Pedidos Localizados com Sucesso!";
                return pedidosListados;
            }
            catch (SqlException err)
            {
                throw new Exception(err.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
