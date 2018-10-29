using SistemaGrafica.Domain.Exceptions;
using System;
using System.Runtime.Serialization;

namespace SistemaGrafica.Domain.feature.ClientesJuridicos
{ 
    public class ClienteNomeVazioException : BusinessException
    {
        public ClienteNomeVazioException() : base("É obrigatório informar o nome")
        {
        }
    }
}