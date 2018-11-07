using SistemaGrafica.Domain.Exceptions;

namespace SistemaGrafica.Domain.common.cpfs
{
    public class CpfInvalidoException : InfrastructureException
    {
        public CpfInvalidoException() : base("O CPF é inválido!")
        {
        }
    }
}