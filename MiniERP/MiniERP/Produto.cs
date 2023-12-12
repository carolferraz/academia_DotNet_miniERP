using System;
using System.Collections.Generic;

namespace MiniERP
{
    public partial class Produto
    {
        public Produto()
        {
            Pedidos = new HashSet<Pedido>();
        }

        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public decimal? Preco { get; set; }
        public int? Estoque { get; set; }
        public int? FkFornecedor { get; set; }

        public virtual Fornecedor? FkFornecedorNavigation { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
