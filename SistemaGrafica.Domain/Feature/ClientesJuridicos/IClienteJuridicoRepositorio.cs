using SistemaGrafica.Domain.feature.ClientesJuridicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Domain.Feature.ClientesJuridicos
{
    public interface IClienteJuridicoRepositorio
    {
        ClienteJuridico Adicionar(ClienteJuridico clienteJuridico);
        ClienteJuridico Editar(ClienteJuridico clienteJuridico);
        ClienteJuridico Buscar(int id);
        IList<ClienteJuridico> BuscarTodos();
        void Excluir(ClienteJuridico clienteJuridico);
    }
}
