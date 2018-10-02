using SistemaGrafica.Domain.feature.ClientesFisicos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Infra.ORM.features.ClientesFisicos
{
    public class ClienteFisicoConfiguracao : EntityTypeConfiguration<ClienteFisico>
    {
        public ClienteFisicoConfiguracao()
        {
            ToTable("TBClienteFisico");
            HasKey(cf => cf.Id);
            Property(cf => cf.Nome).HasColumnName("Nome").HasColumnType("varchar").HasMaxLength(100).IsRequired();
            Property(cf => cf.CPFisica).HasColumnName("Cpf").HasColumnType("char").HasMaxLength(11).IsRequired();
            Property(cf => cf.TelefonePrincipal).HasColumnName("TelefonePrincipal").HasColumnType("int").IsRequired();
            Property(cf => cf.TelefoneSecundario).HasColumnName("TelefoneSecundario").HasColumnType("int").IsRequired();
            Property(cf => cf.Endereco.Bairro);
            Property(cf => cf.Endereco.Cep);
            Property(cf => cf.Endereco.Cidade);
            Property(cf => cf.Endereco.Complemento);
            Property(cf => cf.Endereco.Numero);
            Property(cf => cf.Endereco.Rua);
            Property(cf => cf.Endereco.Estado);
        }
    }
}
