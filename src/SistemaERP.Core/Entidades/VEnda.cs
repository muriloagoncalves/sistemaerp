using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaERP.Core.Entidades
{
    public class Venda
    {
        public int IdVenda { get; set; }
        public string ChaveDeAcesso { get; set; }
        public DateTime DataEmissao { get; set; }
        public decimal TotalProdutos { get; set; }
        public decimal TotalDaNota { get; set; }
        public decimal TotalDesconto { get; set; }
        public decimal TotalAcrescimo { get; set; }
        public List<VendaItem> Itens { get; set; }//Colocar proteção para adicionar
        public Venda()
        {
            Itens = new List<VendaItem>();
        }
    }
}
