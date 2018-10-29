using SistemaGrafica.Domain.feature.ClientesJuridicos;
using SistemaGrafica.Domain.Feature.ClientesJuridicos;
using SistemaGrafica.Infra.ORM.Base;
using System.Collections.Generic;
using System.Linq;

namespace SistemaGrafica.Infra.ORM.Features.ClientesJuridicos
{
    public class ClienteJuridicoRepositorio : IClienteJuridicoRepositorio
    {
        SistemaGraficaContexto _contexto;
        public ClienteJuridicoRepositorio(SistemaGraficaContexto contexto)
        {
            _contexto = contexto;
        }
        public ClienteJuridico Adicionar(ClienteJuridico clienteJuridico)
        {
            clienteJuridico = _contexto.ClientesJuridicos.Add(clienteJuridico);
            _contexto.SaveChanges();
            return clienteJuridico;
        }

        public ClienteJuridico Buscar(int id)
        {
            ClienteJuridico cliente = _contexto.ClientesJuridicos.Find(id);
            return cliente;
        }

        public IList<ClienteJuridico> BuscarTodos()
        {
            return _contexto.ClientesJuridicos.ToList();
        }

        public ClienteJuridico Editar(ClienteJuridico clienteJuridico)
        {
            _contexto.SaveChanges();
            return clienteJuridico;
        }

        public void Excluir(ClienteJuridico clienteJuridico)
        {
            _contexto.ClientesJuridicos.Remove(clienteJuridico);
            _contexto.SaveChanges();
        }
    }
}
