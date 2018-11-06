using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGrafica.Domain.feature.ClientesJuridicos;
using SistemaGrafica.Domain.Feature.ClientesJuridicos;

namespace SistemaGrafica.Aplication.Feature.ClientesJuridicos
{
    public class ClienteJuridicoService : IClienteJuridicoService
    {
        IClienteJuridicoRepositorio _clienteJuridicoRepositorio;

        public ClienteJuridicoService(IClienteJuridicoRepositorio clienteJuridicoRepositorio)
        {
            clienteJuridicoRepositorio = _clienteJuridicoRepositorio;
        }
        public ClienteJuridico Adicionar(ClienteJuridico clienteJuridico)
        {
            clienteJuridico.Validar();

            return _clienteJuridicoRepositorio.Adicionar(clienteJuridico);
        }

        public ClienteJuridico Atualizar(ClienteJuridico clienteJuridico)
        {
            clienteJuridico.Validar();

            return _clienteJuridicoRepositorio.Editar(clienteJuridico);
        }

        public ClienteJuridico BuscarPorId(int id)
        {
            return _clienteJuridicoRepositorio.Buscar(id);
        }

        public IEnumerable<ClienteJuridico> BuscarTodos()
        {
            return _clienteJuridicoRepositorio.BuscarTodos();
        }

        public void Excluir(ClienteJuridico clienteJuridico)
        {
            _clienteJuridicoRepositorio.Excluir(clienteJuridico);
        }
    }
}
