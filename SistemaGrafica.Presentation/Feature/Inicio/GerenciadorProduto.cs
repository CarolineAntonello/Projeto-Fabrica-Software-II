using SistemaGrafica.Aplication.Feature.Produtos;
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
        ProdutoService _produtoService;
        public GerenciadorProduto(ProdutoService produtoService)
        {
            _produtoService = produtoService;
        }
        public override void Adicionar()
        {
            throw new NotImplementedException();
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
