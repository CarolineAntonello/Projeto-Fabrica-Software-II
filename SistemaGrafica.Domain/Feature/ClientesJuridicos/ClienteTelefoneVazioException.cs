using SistemaGrafica.Domain.Exceptions;
using System;
using System.Runtime.Serialization;

namespace SistemaGrafica.Domain.feature.ClientesJuridicos
{
    public class ClienteTelefoneVazioException : BusinessException
    {
        public ClienteTelefoneVazioException() : base("É obrigatório informar pelo menos um telefone válido")
        {
        }
    }
}