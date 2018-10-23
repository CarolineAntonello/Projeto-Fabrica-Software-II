using SistemaGrafica.Domain.Exceptions;

namespace SistemaGrafica.Domain.Feature.Servicos
{
    public class ServicoTipoServicoVazioException : BusinessException
    {
        public ServicoTipoServicoVazioException() : base("É preciso selecionar um tipo de serviço")
        {
        }
    }
}
