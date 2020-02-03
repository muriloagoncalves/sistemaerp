using SistemaERP.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaERP.Core.Interfaces.Repositorios
{
    public interface IRepositorioVenda
    {
        void AdicionarVenda(Venda venda);
        void AlterarVenda(Venda venda);
        void DeletarVenda(Venda venda);
        void AdicionarItem(VendaItem item);
    }
}
