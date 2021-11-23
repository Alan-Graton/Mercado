using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Pedidos
    {
        private string Prod_Nome;
        private string Prod_Categoria;

        public Pedidos()
        {

        }

        public Pedidos(string nome, string categoria)
        {
            Prod_Nome = nome;
            Prod_Categoria = categoria;
        }

        public string Nome { get => Prod_Nome; set => Prod_Nome = value; }
        public string Categoria { get => Prod_Categoria; set => Prod_Categoria = value; }
    }
}
