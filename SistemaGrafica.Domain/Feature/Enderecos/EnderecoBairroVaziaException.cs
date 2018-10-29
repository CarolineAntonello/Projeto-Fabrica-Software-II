using SistemaGrafica.Domain.Exceptions;
using System;
using System.Runtime.Serialization;

namespace SistemaGrafica.Domain.feature.Enderecos
{

    public class EnderecoBairroVaziaException : BusinessException
    {
        public EnderecoBairroVaziaException() : base("É necessário informar o bairro.")
        {
        }
    }
}