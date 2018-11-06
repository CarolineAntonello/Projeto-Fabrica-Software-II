using SistemaGrafica.Aplication.Feature.Servicos;
using SistemaGrafica.Domain.feature.Servicos;
using SistemaGrafica.Presentation.feature.Inicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGrafica.Presentation.Feature.Inicio
{
    public class GerenciadorServico : GerenciadorFormulario
    {
        ServicoService _service;

        public GerenciadorServico(ServicoService service)
        {
            _service = service;
        }

        public override void Adicionar()
        {
            TelaInicial form = new TelaInicial(_service);
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                _service.Adicionar(form.NovoServico);
                IEnumerable<Servico> servicos = _service.BuscarTodos();
                //_controlSerie.PopularListagemSeries(series);
            }
        }

        public override UserControl CarregarListagem()
        {
            throw new NotImplementedException();
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override string ObtemTipoCadastro()
        {
            throw new NotImplementedException();
        }

        public override void Remover()
        {
            throw new NotImplementedException();
        }
    }
}
