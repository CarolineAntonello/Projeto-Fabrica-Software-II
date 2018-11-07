using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGrafica.Aplication.Feature.Produtos;
using SistemaGrafica.Domain.feature.Produtos;

namespace SistemaGrafica.Presentation.Feature.Inicio
{
    public partial class ControlProduto : UserControl
    {
        private ProdutoService _produtoService;

        public ControlProduto(ProdutoService produtoService)
        {
            _produtoService = produtoService;
            InitializeComponent();
        }
        internal Produto ObtemProdutoSelecionado()
        {
            return (Produto)listProduto.SelectedItem;

            //Pegar a primeira linha com os dados do SelectedRows(collection com as linhas selecionadas);
            //Converter os dados dessa linha para o tipo Produto;
            //Retornar o objeto produto gerado.
        }

        public void PopularListagemProdutos(IEnumerable<Produto> produtos)
        {
            if (produtos != null)
            {
                listProduto.Items.Clear();

                foreach (Produto c in produtos)
                {
                    listProduto.Items.Add(c);
                }
            }
        }
    }
}
