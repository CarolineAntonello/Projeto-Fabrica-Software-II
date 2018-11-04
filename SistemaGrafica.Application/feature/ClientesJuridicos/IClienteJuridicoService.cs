using SistemaGrafica.Domain.feature.ClientesJuridicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Application.Feature.ClientesJuridicos
{
    public interface IClienteJuridicoService
    {
        ClienteJuridico Adicionar(ClienteJuridico clienteJuridico);
        ClienteJuridico Atualizar(ClienteJuridico clienteJuridico);
        void Excluir(ClienteJuridico clienteJuridico);
        IEnumerable<ClienteJuridico> BuscarTodos();
        ClienteJuridico BuscarPorId(int id);
    }
}
