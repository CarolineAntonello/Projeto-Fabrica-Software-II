using SistemaGrafica.Domain.Base;
using SistemaGrafica.Domain.Feature.Servicos;

namespace SistemaGrafica.Domain.feature.Servicos
{
    public class Servico : Entidade
    {
        public string TipoServico { get; set; }
        public decimal ValorUnitario { get; set; }

        public override void Validar()
        {
            if(TipoServico == null)
                throw new ServicoTipoServicoVazioException();
            if (ValorUnitario < 0)
                throw new ServicoValorUnitarioMenorQueZeroException();
        }
    }
}
