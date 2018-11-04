using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGrafica.Domain.feature.ClientesFisicos;
using SistemaGrafica.Domain.Feature.ClientesFisicos;

namespace SistemaGrafica.Application.Feature.ClientesFisicos
{
    public class ClienteFisicoService : IClienteFisicoService
    {
        IClienteFisicoRepositorio _clienteFisicoRepositorio;
        
        public ClienteFisicoService(IClienteFisicoRepositorio clienteFisicoRepositorio)
        {
            clienteFisicoRepositorio = _clienteFisicoRepositorio;
        }
        public ClienteFisico Adicionar(ClienteFisico clienteFisico)
        {
            clienteFisico.Validar();

            return _clienteFisicoRepositorio.Adicionar(clienteFisico);
        }

        public ClienteFisico Atualizar(ClienteFisico clienteFisico)
        {
            clienteFisico.Validar();

            return _clienteFisicoRepositorio.Editar(clienteFisico);
        }

        public ClienteFisico BuscarPorId(int id)
        {
            return _clienteFisicoRepositorio.Buscar(id);
        }

        public IEnumerable<ClienteFisico> BuscarTodos()
        {
            return _clienteFisicoRepositorio.BuscarTodos();
        }

        public void Excluir(ClienteFisico clienteFisico)
        {
            _clienteFisicoRepositorio.Excluir(clienteFisico);
        }
    }
}
