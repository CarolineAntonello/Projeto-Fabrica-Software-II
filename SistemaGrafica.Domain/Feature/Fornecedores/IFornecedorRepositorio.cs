using SistemaGrafica.Domain.feature.Fornecedores;
using System.Collections.Generic;

namespace SistemaGrafica.Domain.Feature.Fornecedores
{
    public interface IFornecedorRepositorio
    {
        Fornecedor Adicionar(Fornecedor fornecedor);
        Fornecedor Editar(Fornecedor fornecedor);
        Fornecedor Buscar(int id);
        IList<Fornecedor> BuscarTodos();
        void Excluir(Fornecedor fornecedor);
    }
}
