using SistemaGrafica.Domain.feature.Fornecedores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Application.Feature.Fornecedores
{
    public interface IFornecedorService
    {
        Fornecedor Adicionar(Fornecedor fornecedor);
        Fornecedor Atualizar(Fornecedor fornecedor);
        void Excluir(Fornecedor fornecedor);
        IEnumerable<Fornecedor> BuscarTodos();
        Fornecedor BuscarPorId(int id);
    }
}
