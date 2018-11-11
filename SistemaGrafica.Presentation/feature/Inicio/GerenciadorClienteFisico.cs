using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGrafica.Aplication.Feature.ClientesFisicos;
using SistemaGrafica.Domain.feature.ClientesFisicos;
using SistemaGrafica.Domain.feature.Servicos;
using SistemaGrafica.Presentation.feature.Inicio;

namespace SistemaGrafica.Presentation.Feature.Inicio
{
    class GerenciadorClienteFisico : GerenciadorFormulario
    {
        ClienteFisicoService _service;

        public GerenciadorClienteFisico(ClienteFisicoService service)
        {
            _service = service;
        }
        public override void Adicionar()
        {
            TelaInicial form = new TelaInicial(_service);
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                _service.Adicionar(form.NovoClienteFisico);
                IEnumerable<ClienteFisico> clientesFisicos = _service.BuscarTodos();
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
