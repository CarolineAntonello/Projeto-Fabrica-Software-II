using SistemaGrafica.Domain.Exceptions;

namespace SistemaGrafica.Domain.Feature.Servicos
{
    public class ServicoValorUnitarioMenorQueZeroException : BusinessException
    {
        public ServicoValorUnitarioMenorQueZeroException() : base("O valor unitário não pode ser menor que zero")
        {
        }
    }
}
