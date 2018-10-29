using SistemaGrafica.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Domain.Features.Fornecedores
{
    public class FornecedorInscricaoMunicipalVazioException : BusinessException
    {
        public FornecedorInscricaoMunicipalVazioException() : base("A inscrição municipal do fornecedor não pode estar vazia")
        {
        }
    }
}
