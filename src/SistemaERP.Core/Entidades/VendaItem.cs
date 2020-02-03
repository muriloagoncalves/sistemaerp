using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaERP.Core.Entidades
{
    public class VendaItem
    {
        public int IdVenda { get; set; }
        public int IdVendaItem { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string EAN { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal DescontoItem { get; set; }
        public decimal AcrescimoItem { get; set; }
        public Venda Venda { get; set; }

    }
}
