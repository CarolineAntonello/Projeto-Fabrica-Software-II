using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Domain.feature.Produtos
{
    public interface IProdutoRepositorio 
    {
        Produto Adicionar(Produto produto);
        Produto Editar(Produto produto);
        Produto Buscar(int id);
        IList<Produto> BuscarTodos();
        void Excluir(Produto produto);
    }
}
