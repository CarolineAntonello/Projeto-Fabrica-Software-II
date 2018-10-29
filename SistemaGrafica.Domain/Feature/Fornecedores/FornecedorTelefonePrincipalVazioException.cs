using SistemaGrafica.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Domain.Features.Fornecedores
{
    public class FornecedorTelefonePrincipalVazioException : BusinessException
    {
        public FornecedorTelefonePrincipalVazioException() : base("O telefone principal do fornecedor não pode estar vazio.")
        {
        }
    }
}
