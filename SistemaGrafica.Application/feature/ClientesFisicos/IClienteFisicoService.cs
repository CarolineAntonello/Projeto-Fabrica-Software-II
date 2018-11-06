using SistemaGrafica.Domain.feature.ClientesFisicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Aplication.Feature.ClientesFisicos
{
    public interface IClienteFisicoService
    {
        ClienteFisico Adicionar(ClienteFisico clienteFisico);
        ClienteFisico Atualizar(ClienteFisico clienteFisico);
        void Excluir(ClienteFisico clienteFisico);
        IEnumerable<ClienteFisico> BuscarTodos();
        ClienteFisico BuscarPorId(int id);
    }
}
