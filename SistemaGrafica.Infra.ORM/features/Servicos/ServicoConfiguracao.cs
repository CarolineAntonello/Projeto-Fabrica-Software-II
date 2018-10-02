using SistemaGrafica.Domain.feature.Servicos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Infra.ORM.features.Servicos
{
    public class ServicoConfiguracao : EntityTypeConfiguration<Servico>
    {
        public ServicoConfiguracao()
        {
            ToTable("TBServico");
            HasKey(sf => sf.Id);
            Property(sf => sf.Id).HasColumnName("idServico");
            Property(sf => sf.TipoServico).HasColumnName("tipoServico").HasColumnType("varchar").HasMaxLength(50).IsRequired();
            Property(sf => sf.ValorTotal).HasColumnName("valorTotal").HasColumnType("int").IsRequired();
            Property(sf => sf.ValorUnitario).HasColumnName("valorUnitario").HasColumnType("int").IsRequired();
        }
    }
}
