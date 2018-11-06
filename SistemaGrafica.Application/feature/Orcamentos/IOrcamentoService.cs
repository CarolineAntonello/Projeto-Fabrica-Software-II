using SistemaGrafica.Domain.feature.Orcamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Aplication.Feature.Orcamentos
{
    public interface IOrcamentoService
    {
        Orcamento Adicionar(Orcamento orcamento);
        Orcamento Atualizar(Orcamento orcamento);
        void Excluir(Orcamento orcamento);
        IEnumerable<Orcamento> BuscarTodos();
        Orcamento BuscarPorId(int id);
    }
}
