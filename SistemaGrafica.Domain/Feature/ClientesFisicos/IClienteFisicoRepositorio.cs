using SistemaGrafica.Domain.feature.ClientesFisicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Domain.Feature.ClientesFisicos
{
    public interface IClienteFisicoRepositorio
    {
        ClienteFisico Adicionar(ClienteFisico clienteFisico);
        ClienteFisico Editar(ClienteFisico clienteFisico);
        ClienteFisico Buscar(int id);
        IList<ClienteFisico> BuscarTodos();
        void Excluir(ClienteFisico clienteFisico);
    }
}
