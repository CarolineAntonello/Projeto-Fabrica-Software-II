﻿using SistemaGrafica.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Domain.Features.Fornecedores
{
    public class FornecedorInscricaoEstadualVazioException : BusinessException
    {
        public FornecedorInscricaoEstadualVazioException() : base ("A inscrição estadual do fornecedor não pode estar vazia")
        {
        }
    }
}
