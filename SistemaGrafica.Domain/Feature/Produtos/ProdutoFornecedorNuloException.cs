using SistemaGrafica.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Domain.Feature.Produtos
{
    public class ProdutoFornecedorNuloException : BusinessException
    {
        public ProdutoFornecedorNuloException() : base("O Fornecedor do produto não pode estar nulo ou vazio.")
        {
        }
    }
}
