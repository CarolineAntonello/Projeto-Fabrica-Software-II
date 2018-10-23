using SistemaGrafica.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Domain.Features.Fornecedores
{
    public class FornecedorCNPJNuloOuVazioException : BusinessException
    {
        public FornecedorCNPJNuloOuVazioException() : base("O CNPJ do fornecedor não pode ser nulo ou vazio.")
        {
        }
    }
}
