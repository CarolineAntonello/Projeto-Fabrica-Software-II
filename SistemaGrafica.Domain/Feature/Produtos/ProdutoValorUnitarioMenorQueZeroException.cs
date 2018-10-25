using SistemaGrafica.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Domain.Feature.Produtos
{
    public class ProdutoValorUnitarioMenorQueZeroException : BusinessException
    {
        public ProdutoValorUnitarioMenorQueZeroException() : base("O valor Unitário do produto não pode ser menor ou igual a zero.")
        {
        }
    }
}
