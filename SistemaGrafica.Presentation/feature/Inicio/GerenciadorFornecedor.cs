using SistemaGrafica.Aplication.Feature.Fornecedores;
using SistemaGrafica.Domain.feature.Fornecedores;
using SistemaGrafica.Presentation.feature.Inicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGrafica.Presentation.Feature.Inicio
{
    class GerenciadorFornecedor : GerenciadorFormulario
    {
        FornecedorService _service;

        public GerenciadorFornecedor(FornecedorService service)
        {
            _service = service;
        }
        public override void Adicionar()
        {
            TelaInicial form = new TelaInicial(_service);
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                _service.Adicionar(form.NovoFornecedor);
                IEnumerable<Fornecedor> fornecedores = _service.BuscarTodos();
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


