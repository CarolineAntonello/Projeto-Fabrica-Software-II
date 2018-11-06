using SistemaGrafica.Domain.feature.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Aplication.Feature.Servicos
{
    public interface IServicoService
    {
        Servico Adicionar(Servico servico);
        Servico Atualizar(Servico servico);
        void Excluir(Servico servico);
        IEnumerable<Servico> BuscarTodos();
        Servico BuscarPorId(int id);
    }
}
