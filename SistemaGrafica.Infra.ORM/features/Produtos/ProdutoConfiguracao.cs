using SistemaGrafica.Domain.feature.Produtos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Infra.ORM.features.Produtos
{
    public class ProdutoConfiguracao : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguracao()
        {
            ToTable("TBProduto");
            HasKey(p => p.Id);
            Property(p => p.Id).HasColumnName("idProduto");

            Property(p => p.Nome).HasColumnName("Nome").HasColumnType("varchar").HasMaxLength(100).IsRequired();
            Property(p => p.Descricao).HasColumnName("Descricao").HasColumnType("varchar").HasMaxLength(200).IsRequired();
            Property(p => p.ValorUnitario).HasColumnName("ValorUnitario").HasColumnType("decimal").IsRequired();
            HasRequired(p => p.Fornecedor).WithMany().HasForeignKey(p => p.FornecedorId);
        }
    }
}
