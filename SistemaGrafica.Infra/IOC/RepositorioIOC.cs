using SistemaGrafica.Domain.feature.Produtos;
using SistemaGrafica.Domain.Feature.ClientesFisicos;
using SistemaGrafica.Domain.Feature.ClientesJuridicos;
using SistemaGrafica.Domain.Feature.Fornecedores;
using SistemaGrafica.Domain.Feature.Servicos;
using SistemaGrafica.Infra.ORM.features.Produtos;
using SistemaGrafica.Infra.ORM.Features.ClientesFisicos;
using SistemaGrafica.Infra.ORM.Features.ClientesJuridicos;
using SistemaGrafica.Infra.ORM.Features.Fornecedores;
using SistemaGrafica.Infra.ORM.Features.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Infra.IOC
{
    public class RepositorioIOC
    {
        public static IProdutoRepositorio produto { get; internal set; }
        public static IServicoRepositorio servico { get; internal set; }
        public static IClienteJuridicoRepositorio clienteJuridico { get; internal set; }
        public static IClienteFisicoRepositorio clienteFisico { get; internal set; }
        public static IFornecedorRepositorio fornecedor { get; internal set; }

        public RepositorioIOC()
        {
            produto = SingletonHelper<ProdutoRepositorio>.Instance();
            servico = SingletonHelper<ServicoRepositorio>.Instance();
            clienteJuridico = SingletonHelper<ClienteJuridicoRepositorio>.Instance();
            clienteFisico = SingletonHelper<ClienteFisicoRepositorio>.Instance();
            fornecedor = SingletonHelper<FornecedoresRespositorio>.Instance();
        }
    }
}
