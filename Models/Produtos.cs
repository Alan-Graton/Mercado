using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Produtos
    {
        private string Nome;
        private string Categoria;

        public Produtos()
        {

        }

        public Produtos(string nome, string categoria)
        {
            Nome = nome;
            Categoria = categoria;
        }

        public string Prod_Nome { get => Nome; set => Nome = value; }
        public string Prod_Categoria { get => Categoria; set => Categoria = value; }
    }
}
