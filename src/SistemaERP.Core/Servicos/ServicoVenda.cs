using SistemaERP.Core.Entidades;
using SistemaERP.Core.Interfaces.Repositorios;
using SistemaERP.Core.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaERP.Core.Servicos
{
    public class ServicoVenda : IServicoVenda
    {
        private readonly IRepositorioVenda _repositorioVenda;
        public ServicoVenda(IRepositorioVenda repositorioVenda)
        {
            _repositorioVenda = repositorioVenda;
        }
        public void AdicionarVenda(Venda venda)
        {
            //Validações - Colocar algum retorno com os erros
            if (venda == null) return;
            _repositorioVenda.AdicionarVenda(venda);
        }

        public void AlterarVenda(Venda venda)
        {
            _repositorioVenda.AlterarVenda(venda);
        }

        public void DeletarVenda(Venda venda)
        {
            _repositorioVenda.DeletarVenda(venda);
        }

        public void VendaItem(Venda venda, VendaItem item)
        {
            if (venda == null) return;
            if (item == null) return;
            venda.Itens.Add(item);
            if (item.IdVenda == 0) item.IdVenda = venda.IdVenda;
            _repositorioVenda.AdicionarItem(item);
        }
    }
}
