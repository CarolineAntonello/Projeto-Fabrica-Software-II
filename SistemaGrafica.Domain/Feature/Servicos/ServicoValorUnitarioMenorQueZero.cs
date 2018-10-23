using SistemaGrafica.Domain.Exceptions;

namespace SistemaGrafica.Domain.Feature.Servicos
{
    public class ServicoValorUnitarioMenorQueZero : BusinessException
    {
        public ServicoValorUnitarioMenorQueZero() : base("O valor unitário não pode ser menor que zero")
        {
        }
    }
}
