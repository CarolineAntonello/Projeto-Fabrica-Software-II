using SistemaGrafica.Domain.feature.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Aplication.Feature.Produtos
{
    public interface IProdutoService
    {
        Produto Adicionar(Produto produto);
        Produto Atualizar(Produto produto);
        void Excluir(Produto produto);
        IEnumerable<Produto> BuscarTodos();
        Produto BuscarPorId(int id);
    }
}
