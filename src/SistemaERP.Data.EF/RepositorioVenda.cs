using SistemaERP.Core.Entidades;
using SistemaERP.Core.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaERP.Data.EF
{
    public class RepositorioVenda : IRepositorioVenda
    {
        private readonly Contexto _contexto;
        public RepositorioVenda(Contexto contexto)
        {
            _contexto = contexto;
        }
        public void AdicionarItem(VendaItem item)
        {
            _contexto.VendaItem.Add(item);
        }

        public void AdicionarVenda(Venda venda)
        {
            _contexto.Venda.Add(venda);
        }

        public void AlterarVenda(Venda venda)
        {
            _contexto.Venda.Update(venda);
        }

        public void DeletarVenda(Venda venda)
        {
            _contexto.Venda.Remove(venda);
        }
    }
}
