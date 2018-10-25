using SistemaGrafica.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Domain.Features.Fornecedores
{
    public class FornecedorEnderecoNuloException : BusinessException
    {
        public FornecedorEnderecoNuloException() : base ("O endereço do fornecedor não pode estar nulo.")
        {
        }
    }
}
