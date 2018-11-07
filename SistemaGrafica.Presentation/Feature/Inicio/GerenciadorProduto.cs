using SistemaGrafica.Aplication.Feature.Produtos;
using SistemaGrafica.Domain.feature.Produtos;
using SistemaGrafica.Presentation.feature.Inicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGrafica.Presentation.Feature.Inicio
{
    public class GerenciadorProduto : GerenciadorFormulario
    {
        ControlProduto _controlProduto;
        ProdutoService _produtoService;
        public GerenciadorProduto(ProdutoService produtoService)
        {
            _produtoService = produtoService;
            CarregarListagem();
        }
        public override void Adicionar()
        {
            TelaInicial form = new TelaInicial(_produtoService);
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                _produtoService.Adicionar(form.NovoProduto);
                IEnumerable<Produto> produtos = _produtoService.BuscarTodos();
                _controlProduto.PopularListagemProdutos(produtos);
            }
        }

        public override UserControl CarregarListagem()
        {
            if (_controlProduto == null)
                _controlProduto = new ControlProduto(_produtoService);
            _controlProduto.PopularListagemProdutos(_produtoService.BuscarTodos());
            return _controlProduto;
        }

        public override void Editar()
        {
            try
            {
                Produto produtoSelecionado = _controlProduto.ObtemProdutoSelecionado();
                TelaInicial form = new TelaInicial(_produtoService);
                form.EditarProduto = produtoSelecionado;
                DialogResult result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _produtoService.Atualizar(form.EditarProduto);
                }
                IEnumerable<Produto> produtos = _produtoService.BuscarTodos();
                _controlProduto.PopularListagemProdutos(produtos);

            }
            catch (NullReferenceException)
            {
                throw new Exception("Selecione um Produto!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
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
