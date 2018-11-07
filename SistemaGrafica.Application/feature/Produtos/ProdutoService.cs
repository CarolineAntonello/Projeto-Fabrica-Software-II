using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGrafica.Domain.feature.Produtos;

namespace SistemaGrafica.Aplication.Feature.Produtos
{
    public class ProdutoService : IProdutoService
    {
        IProdutoRepositorio _produtoRepositorio;

        public ProdutoService(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }
        public Produto Adicionar(Produto produto)
        {
            produto.Validar();

            return _produtoRepositorio.Adicionar(produto);
        }

        public Produto Atualizar(Produto produto)
        {
            produto.Validar();

            return _produtoRepositorio.Editar(produto);
        }

        public Produto BuscarPorId(int id)
        {
            return _produtoRepositorio.Buscar(id);
        }

        public IEnumerable<Produto> BuscarTodos()
        {
            return _produtoRepositorio.BuscarTodos();
        }

        public void Excluir(Produto produto)
        {
            _produtoRepositorio.Excluir(produto);
        }
    }
}
