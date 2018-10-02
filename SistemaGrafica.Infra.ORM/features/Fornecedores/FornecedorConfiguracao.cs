using SistemaGrafica.Domain.feature.Fornecedores;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Infra.ORM.features.Fornecedores
{
    public class FornecedorConfiguracao : EntityTypeConfiguration<Fornecedor>
    {
        public FornecedorConfiguracao()
        {
            ToTable("TBFornecedor");
            HasKey(fc => fc.Id);
            Property(fc => fc.Id).HasColumnName("idFornecedor");
            Property(fc => fc.Nome).HasColumnName("Nome").HasColumnType("varchar").HasMaxLength(100).IsRequired();
            Property(fc => fc.CNPJuridica).HasColumnName("Cnpj").HasColumnType("char").HasMaxLength(11).IsRequired();
            Property(fc => fc.RazaoSocial).HasColumnName("RazaoSocial").HasColumnType("varchar").HasMaxLength(100).IsRequired();
            Property(fc => fc.TelefonePrincipal).HasColumnName("TelefonePrincipal").HasColumnType("int").IsRequired();
            Property(fc => fc.TelefoneSecundario).HasColumnName("TelefoneSecundario").HasColumnType("int").IsRequired();
            Property(fc => fc.InscricaoEstadual).HasColumnName("InscricaoEstadual").HasColumnType("int").IsRequired();
            Property(fc => fc.InscricaoMunicipal).HasColumnName("InscricaoMunicipal").HasColumnType("int").IsRequired();
            Property(fc => fc.Endereco.Bairro);
            Property(fc => fc.Endereco.Cep);
            Property(fc => fc.Endereco.Cidade);
            Property(fc => fc.Endereco.Complemento);
            Property(fc => fc.Endereco.Numero);
        }
    }
}
