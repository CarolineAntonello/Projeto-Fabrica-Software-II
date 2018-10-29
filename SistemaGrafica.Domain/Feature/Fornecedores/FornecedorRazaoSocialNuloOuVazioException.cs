using SistemaGrafica.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Domain.Features.Fornecedores
{
    public class FornecedorRazaoSocialNuloOuVazioException : BusinessException
    {
        public FornecedorRazaoSocialNuloOuVazioException() : base("A razão social do fornecedor não pode ser nula ou vazia.")
        {

        }
    }
}
