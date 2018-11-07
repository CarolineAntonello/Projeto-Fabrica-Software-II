using SistemaGrafica.Domain.Exceptions;

namespace SistemaGrafica.Domain.common.cpnjs
{
    public class CnpjInvalidoException : InfrastructureException
    {
        public CnpjInvalidoException() : base("O CNPJ é inválido!")
        {
        }
    }
}
