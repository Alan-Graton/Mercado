using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Mercado
{
    public partial class CadastroProdutos : Form
    {
        public CadastroProdutos()
        {
            InitializeComponent();
        }

        private void Btn_FazerPedido_Click(object sender, EventArgs e)
        {
            Frm_Pedidos pedidos = new Frm_Pedidos();
            this.Hide(); pedidos.Show();
        }

        private void CadastroProdutos_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            ProdutosDAL produtosDAL = new ProdutosDAL();
            List<Produtos> list = new List<Produtos>();
            list = produtosDAL.ListarProdutos(out string listagemExito);
            Grid_Listagem_Produtos.DataSource = list;
        }

        private void Btn_CadastrarProduto_Click(object sender, EventArgs e)
        {
            Produtos produtos = new Produtos(Txt_NomeProduto.Text, ComboBX_CategoriaProduto.Text);
            ProdutosDAL produtosDAL = new ProdutosDAL();
            MessageBox.Show(produtosDAL.CadastrarProdutos(produtos));

            DataTable table = new DataTable();
            List<Produtos> list = new List<Produtos>();
            list = produtosDAL.ListarProdutos(out string listagemExito);
            Grid_Listagem_Produtos.DataSource = list;
        }
    }
}
