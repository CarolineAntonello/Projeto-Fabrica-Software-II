using SistemaGrafica.Domain.feature.Produtos;
using SistemaGrafica.Infra.ORM.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Infra.ORM.features.Produtos
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        SistemaGraficaContexto _contexto;

        public ProdutoRepositorio(SistemaGraficaContexto contexto)
        {
            _contexto = contexto;
        }

        public Produto Adicionar(Produto produto)
        {
            produto = _contexto.Produtos.Add(produto);
            _contexto.SaveChanges();
            return produto;
        }

        public Produto Buscar(int id)
        {
            Produto produto = _contexto.Produtos.Find(id);
            return produto;
        }

        public IList<Produto> BuscarTodos()
        {
            return _contexto.Produtos.ToList();
        }

        public Produto Editar(Produto produto)
        {
            _contexto.SaveChanges();
            return produto;
        }

        public void Excluir(Produto produto)
        {
            _contexto.Produtos.Remove(produto);
            _contexto.SaveChanges();
        }
}
}
