using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaERP.Interop.Entidades
{
    public class Venda
    {
        public int IdVenda { get; set; }
        public string ChaveDeAcesso { get; set; }
        public DateTime DataEmissao { get; set; }
        public double TotalProdutos { get; set; }
        public double TotalDaNota { get; set; }
        public double TotalDesconto { get; set; }
        public double TotalAcrescimo { get; set; }
        public List<VendaItem> Itens { get; set; }
        public Venda()
        {
            Itens = new List<VendaItem>();
        }
        public void AddItem(VendaItem item) => Itens.Add(item);
        public void RemoverItem(VendaItem item) => Itens.Remove(item);
        public int ItensCount() => Itens.Count;
        public VendaItem ObterItem(int index) => Itens[index];
        public int ObterIndex(VendaItem item) => Itens.IndexOf(item);
    }
}
