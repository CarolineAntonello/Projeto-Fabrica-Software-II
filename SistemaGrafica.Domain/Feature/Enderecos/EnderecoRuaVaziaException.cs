using SistemaGrafica.Domain.Exceptions;
using System;
using System.Runtime.Serialization;

namespace SistemaGrafica.Domain.feature.Enderecos
{

    public class EnderecoRuaVaziaException : BusinessException
    {
        public EnderecoRuaVaziaException() : base("É necessário informar a rua.")
        {
        }
    }
}