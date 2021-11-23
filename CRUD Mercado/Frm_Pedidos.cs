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
    public partial class Frm_Pedidos : Form
    {
        public Frm_Pedidos()
        {
            InitializeComponent();
        }

        private void Btn_VoltarCadastro_Click(object sender, EventArgs e)
        {
            CadastroProdutos cadastroprodutos = new CadastroProdutos();
            this.Hide(); cadastroprodutos.Show();
        }

        private void Frm_Pedidos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Frm_Pedidos_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            PedidosDAL pedidosDAL = new PedidosDAL();
            List<Pedidos> list = new List<Pedidos>();
            list = pedidosDAL.ListarProdutos(out string listagemExito);
            Grid_Pedidos_Feitos.DataSource = list;
        }

        private void Btn_SalvarPedido_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos(Txt_NomeProduto_Pedido.Text, ComboBX_CategoriaProduto.Text);
            PedidosDAL pedidosDAL = new PedidosDAL();
            MessageBox.Show(pedidosDAL.CadastrarPedidos(pedidos));

            DataTable table = new DataTable();
            List<Pedidos> list = new List<Pedidos>();
            list = pedidosDAL.ListarProdutos(out string listagemExito);
            Grid_Pedidos_Feitos.DataSource = list;
        }
    }
}
