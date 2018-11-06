using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGrafica.Domain.feature.Fornecedores;
using SistemaGrafica.Domain.Feature.Fornecedores;

namespace SistemaGrafica.Aplication.Feature.Fornecedores
{
    public class FornecedorService : IFornecedorService
    {
        IFornecedorRepositorio _fornecedorRepositorio;

        public FornecedorService(IFornecedorRepositorio fornecedorRepositorio)
        {
            fornecedorRepositorio = _fornecedorRepositorio;
        }
        public Fornecedor Adicionar(Fornecedor fornecedor)
        {
            fornecedor.Validar();

            return _fornecedorRepositorio.Adicionar(fornecedor);
        }

        public Fornecedor Atualizar(Fornecedor fornecedor)
        {
            fornecedor.Validar();

            return _fornecedorRepositorio.Editar(fornecedor);
        }

        public Fornecedor BuscarPorId(int id)
        {
            return _fornecedorRepositorio.Buscar(id);
        }

        public IEnumerable<Fornecedor> BuscarTodos()
        {
            return _fornecedorRepositorio.BuscarTodos();
        }

        public void Excluir(Fornecedor fornecedor)
        {
            _fornecedorRepositorio.Excluir(fornecedor);
        }
    }
}
