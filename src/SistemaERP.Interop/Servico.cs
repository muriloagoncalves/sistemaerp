using AutoMapper;
using SimpleInjector;
using SistemaERP.Core.Interfaces.Repositorios;
using SistemaERP.Core.Interfaces.Servicos;
using SistemaERP.Interop.Entidades;
using SistemaERP.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SistemaERP.Interop
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class Servico
    {
        public string ConnectionString;
        private IServicoVenda _servicoVenda;
        private readonly Container _container;
        private readonly IMapper _mapper;
        public Servico()
        {
            _container = ContainerIoc.ObterContainer();
            //Se for obter por arquivo config, senão usar o iniciar - O vb6 não aceita construtor com parametro, e obriga ter um construtor simples
            //var contexto = _container.GetInstance<IContexto>();
            //contexto.SetarConnectionString(ConnectionString);
            //_servicoVenda = _container.GetInstance<IServicoVenda>();

            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Venda, Core.Entidades.Venda>();
                cfg.CreateMap<VendaItem, Core.Entidades.VendaItem>();
            });
            _mapper = configuration.CreateMapper();
        }
        public void Iniciar(string conn)
        {
            ConnectionString = conn;
            var contexto = _container.GetInstance<IContexto>();
            contexto.SetarConnectionString(ConnectionString);
            _servicoVenda = _container.GetInstance<IServicoVenda>();
        }
        public void Migration()
        {
            var contexto = _container.GetInstance<IContexto>();
            contexto.SetarConnectionString(ConnectionString);
            contexto.Migrate();
        }
        public void AdicionarVenda(Venda venda)
        {
            var vendaCore = _mapper.Map<Core.Entidades.Venda>(venda);
            _servicoVenda.AdicionarVenda(vendaCore);
        }
        public void AlterarVenda(Venda venda)
        {
            var vendaCore = _mapper.Map<Core.Entidades.Venda>(venda);
            _servicoVenda.AlterarVenda(vendaCore);
        }
    }
}
