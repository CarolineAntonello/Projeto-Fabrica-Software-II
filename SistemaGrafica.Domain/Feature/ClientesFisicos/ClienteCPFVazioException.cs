using SistemaGrafica.Domain.Exceptions;

namespace SistemaGrafica.Domain.feature.ClientesFisicos
{
    public class ClienteCPFVazioException : BusinessException
    {
        public ClienteCPFVazioException() : base("É obrigatorio informar o CPF.")
        {
        }
    }
}