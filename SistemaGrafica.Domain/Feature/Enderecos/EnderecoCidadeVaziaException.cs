using SistemaGrafica.Domain.Exceptions;
using System;
using System.Runtime.Serialization;

namespace SistemaGrafica.Domain.feature.Enderecos
{
    public class EnderecoCidadeVaziaException : BusinessException
    {
        public EnderecoCidadeVaziaException() : base("É necessário informar a Cidade.")
        {
        }
    }
}