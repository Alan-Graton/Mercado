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
    public class ProdutosDAL
    {
        public string CadastrarProdutos(Produtos produtos)
        {
            string procedureExito = "";
            try
            {
                SqlConnection connection = new StrConexao().GetConnection();
                SqlCommand sqlProcedure = new SqlCommand("CadastrarProdutos", connection);
                sqlProcedure.CommandType = System.Data.CommandType.StoredProcedure;

                sqlProcedure.Parameters.Add("Nome", SqlDbType.VarChar).Value = produtos.Prod_Nome;
                sqlProcedure.Parameters.Add("Categoria", SqlDbType.VarChar).Value = produtos.Prod_Categoria;

                sqlProcedure.ExecuteNonQuery();

                return procedureExito = "Produto Cadastrado com Sucesso!";
            }
            catch(SqlException err)
            {
                throw new Exception(err.Message);
            }
        }

        public List<Produtos> ListarProdutos(out string listagemExito)
        {
            List<Produtos> produtosListados = new List<Produtos>();
            SqlConnection connection = new StrConexao().GetConnection();
            try
            {
                string query = "SELECT * from TB_Produtos";
                SqlCommand comando = new SqlCommand(query, connection);
                SqlDataReader result = comando.ExecuteReader();
                while (result.Read())
                {
                    produtosListados.Add(new Produtos()
                    {
                        Prod_Nome = result["Nome"].ToString(),
                        Prod_Categoria = result["Categoria"].ToString()
                    });
                }

                listagemExito = "Produtos Localizados com Sucesso!";
                return produtosListados;
            }
            catch(SqlException err)
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
