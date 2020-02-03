using SimpleInjector;
using SistemaERP.Core.Interfaces.Repositorios;
using SistemaERP.Core.Interfaces.Servicos;
using SistemaERP.Core.Servicos;
using SistemaERP.Data;
using SistemaERP.Data.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaERP.Ioc
{
    public class ContainerIoc
    {
        public static Container ObterContainer()
        {
            var container = new Container();
            container.RegisterSingleton<IServicoVenda, ServicoVenda>();
            container.RegisterSingleton<IRepositorioVenda, RepositorioVenda>();
            container.RegisterSingleton<Contexto>();
            container.RegisterSingleton<IContexto, Contexto>();
            return container;
        }
    }
}
