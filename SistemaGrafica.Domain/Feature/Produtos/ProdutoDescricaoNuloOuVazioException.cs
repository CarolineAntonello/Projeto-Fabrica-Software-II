using SistemaGrafica.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Domain.Feature.Produtos
{
    public class ProdutoDescricaoNuloOuVazioException : BusinessException
    {
        public ProdutoDescricaoNuloOuVazioException() : base("A descrição do produto não pode estar nula ou vazia.")
        {
        }
    }
}
