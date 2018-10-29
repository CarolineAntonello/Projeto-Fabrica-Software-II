using SistemaGrafica.Domain.Exceptions;
using System;
using System.Runtime.Serialization;

namespace SistemaGrafica.Domain.feature.Enderecos
{

    public class EnderecoCepVaziaException : BusinessException
    {
        public EnderecoCepVaziaException() : base("É necessário informar o CEP.")
        {
        }
    }
}