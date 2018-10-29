using SistemaGrafica.Domain.Exceptions;
using System;
using System.Runtime.Serialization;

namespace SistemaGrafica.Domain.feature.ClientesJuridicos
{

    public class ClienteCNPJuridicaVazioException : BusinessException
    {
        public ClienteCNPJuridicaVazioException() : base("É obrigatório informar CNPJ")
        {
        }
    }
}