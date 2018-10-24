using SistemaGrafica.Domain.Exceptions;
using System;
using System.Runtime.Serialization;

namespace SistemaGrafica.Domain.feature.Enderecos
{

    public class EnderecoEstadoVaziaException : BusinessException
    {
        public EnderecoEstadoVaziaException() : base("É necessário informar o Estado.")
        {
        }
    }
}