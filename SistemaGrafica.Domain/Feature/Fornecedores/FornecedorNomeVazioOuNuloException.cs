using SistemaGrafica.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Domain.Features.Fornecedores
{
    public class FornecedorNomeVazioOuNuloException : BusinessException
    {
        public FornecedorNomeVazioOuNuloException() : base("O nome do fornecedor não pode estar nulo ou vazio.")
        {
                
        }
    }
}
