using MiniERP;
using System;
using System.Collections.Generic;

namespace MiniERP
{
    public partial class Pedido
    {
        public int Id { get; set; }
        public int? FkCliente { get; set; }
        public int? FkProduto { get; set; }
        public int? Quantidade { get; set; }
        public decimal? TotalItem { get; set; }
        public DateTime? Emissao { get; set; }

        public virtual Cliente? FkClienteNavigation { get; set; }
        public virtual Produto? FkProdutoNavigation { get; set; }
    }
}
