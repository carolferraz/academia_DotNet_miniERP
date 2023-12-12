using MiniERP;
using System;
using System.Collections.Generic;

namespace MiniERP
{
    public partial class Fornecedor
    {
        public Fornecedor()
        {
            Produtos = new HashSet<Produto>();
        }

        public int Id { get; set; }
        public string? Nome { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
