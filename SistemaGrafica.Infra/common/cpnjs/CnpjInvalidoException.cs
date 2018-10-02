using SistemaGrafica.Infra.exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Infra.common.cpnjs
{
    public class CnpjInvalidoException : InfrastructureException
    {
        public CnpjInvalidoException() : base("O CNPJ é inválido!")
        {
        }
    }
}
