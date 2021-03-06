﻿using SistemaGrafica.Domain.feature.Servicos;
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
            Property(sf => sf.TipoServico).HasColumnName("tipoServico").HasColumnType("varchar").HasMaxLength(50).IsRequired();
            Property(sf => sf.ValorUnitario).HasColumnName("valorUnitario").IsRequired();
            Property(sf => sf.Descricao).HasColumnName("descricao");
        }
    }
}
