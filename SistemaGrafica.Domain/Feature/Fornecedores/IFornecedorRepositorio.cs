using SistemaGrafica.Domain.feature.Fornecedores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
