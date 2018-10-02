using SistemaGrafica.Domain.feature.ClientesFisicos;
using SistemaGrafica.Domain.feature.ClientesJuridicos;
using SistemaGrafica.Domain.feature.Fornecedores;
using SistemaGrafica.Domain.feature.Orcamentos;
using SistemaGrafica.Domain.feature.Produtos;
using SistemaGrafica.Domain.feature.Servicos;
using SistemaGrafica.Infra.ORM.features.ClientesFisicos;
using SistemaGrafica.Infra.ORM.features.ClientesJuridicos;
using SistemaGrafica.Infra.ORM.features.Fornecedores;
using SistemaGrafica.Infra.ORM.features.Orcamentos;
using SistemaGrafica.Infra.ORM.features.Produtos;
using SistemaGrafica.Infra.ORM.features.Servicos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Infra.ORM.Base
{
    public class SistemaGraficaContexto : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Orcamento> Orcamentos { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<ClienteJuridico> ClientesJuridicos { get; set; }
        public DbSet<ClienteFisico> ClientesFisicos { get; set; }

        public SistemaGraficaContexto() : base("DBGrafica")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new ProdutoConfiguracao());
            modelBuilder.Configurations.Add(new ServicoConfiguracao());
            modelBuilder.Configurations.Add(new OrcamentoConfiguracao());
            modelBuilder.Configurations.Add(new ClienteJuridicoConfiguracao());
            modelBuilder.Configurations.Add(new ClienteFisicoConfiguracao());
            modelBuilder.Configurations.Add(new FornecedorConfiguracao());
            base.OnModelCreating(modelBuilder);
        }
    }
}
