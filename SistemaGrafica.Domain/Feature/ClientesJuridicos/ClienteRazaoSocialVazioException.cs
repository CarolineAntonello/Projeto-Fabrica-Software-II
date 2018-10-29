using SistemaGrafica.Domain.Exceptions;
using System;
using System.Runtime.Serialization;

namespace SistemaGrafica.Domain.feature.ClientesJuridicos
{
    public class ClienteRazaoSocialVazioException : BusinessException
    {
        public ClienteRazaoSocialVazioException() : base("É obrigatório informar Razão Social")
        {
        }
    }
}