using SistemaGrafica.Domain.feature.Orcamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Domain.Feature.Orcamentos
{
    public interface IOrcamentoRepositorio
    {
        Orcamento Adicionar(Orcamento orcamento);
        Orcamento Editar(Orcamento orcamento);
        Orcamento Buscar(int id);
        IList<Orcamento> BuscarTodos();
        void Excluir(Orcamento orcamento);
    }
}
