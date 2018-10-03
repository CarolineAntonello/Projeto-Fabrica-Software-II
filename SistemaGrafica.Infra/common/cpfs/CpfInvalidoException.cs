using SistemaGrafica.Infra.exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Infra.common.cpfs
{
    public class CpfInvalidoException : InfrastructureException
    {
        public CpfInvalidoException() : base("O CPF é inválido!")
        {
        }
    }
}