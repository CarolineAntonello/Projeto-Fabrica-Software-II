using SistemaGrafica.Domain.feature.ClientesJuridicos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Infra.ORM.features.ClientesJuridicos
{
    public class ClienteJuridicoConfiguracao : EntityTypeConfiguration<ClienteJuridico>
    {
        public ClienteJuridicoConfiguracao()
        {
            ToTable("TBClienteJuridico");
            HasKey(cj => cj.Id);
            Property(cf => cf.CNPJuridica).HasColumnName("Cnpj").HasColumnType("char").HasMaxLength(11);
            Property(cj => cj.Nome).HasColumnName("Nome").HasColumnType("varchar").HasMaxLength(100).IsRequired();
            Property(cj => cj.RazaoSocial).HasColumnName("RazaoSocial").HasColumnType("varchar").HasMaxLength(100).IsRequired();
            Property(cj => cj.TelefonePrincipal).HasColumnName("TelefonePrincipal").HasColumnType("int").IsRequired();
            Property(cj => cj.TelefoneSecundario).HasColumnName("TelefoneSecundario").HasColumnType("int").IsRequired();
            HasRequired(cj => cj.InscricaoEstadual);
            Property(cj => cj.InscricaoMunicipal).HasColumnName("InscricaoMunicipal").HasColumnType("int").IsRequired();
            Property(cf => cf.Endereco.Bairro);
            Property(cf => cf.Endereco.Cep);
            Property(cf => cf.Endereco.Cidade);
            Property(cf => cf.Endereco.Complemento);
        }
    }
}
