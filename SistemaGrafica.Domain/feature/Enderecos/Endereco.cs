using SistemaGrafica.Domain.Base;
using System;

namespace SistemaGrafica.Domain.feature.Enderecos
{
    ///Caso mudar forma de preenchimento Cidade/Estado lembrar de mudar Exceptions
    public class Endereco : Entidade
    {
        public int Numero { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }

        public override void Validar()
        {
            if (Numero == 0 && Complemento == null)
                throw new EnderecoNumeroEComplementoNuloException();
            if (String.IsNullOrEmpty(Rua))
                throw new EnderecoRuaVaziaException();
            if (String.IsNullOrEmpty(Bairro))
                throw new EnderecoBairroVaziaException();
            if (String.IsNullOrEmpty(Cidade))
                throw new EnderecoCidadeVaziaException();
            if (String.IsNullOrEmpty(Estado))
                throw new EnderecoEstadoVaziaException();
            if (String.IsNullOrEmpty(Cep))
                throw new EnderecoCepVaziaException();
        }
    }
}
