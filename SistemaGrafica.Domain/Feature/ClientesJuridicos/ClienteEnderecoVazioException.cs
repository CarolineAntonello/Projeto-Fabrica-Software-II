using SistemaGrafica.Domain.Exceptions;

namespace SistemaGrafica.Domain.feature.ClientesJuridicos
{
    public class ClienteEnderecoVazioException : BusinessException
    {
        public ClienteEnderecoVazioException() : base("É preciso informar o endereço.")
        {
        }
    }
}