using SistemaGrafica.Domain.Exceptions;
using System;
using System.Runtime.Serialization;

namespace SistemaGrafica.Domain.feature.Enderecos
{

    public class EnderecoNumeroEComplementoNuloException : BusinessException
    {
        public EnderecoNumeroEComplementoNuloException() : base("Quando não houver número é obrigatório preencher complemento")
        {
        }
    }
}