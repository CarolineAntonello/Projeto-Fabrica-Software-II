using SistemaGrafica.Domain.feature.ClientesFisicos;
using SistemaGrafica.Domain.Feature.ClientesFisicos;
using SistemaGrafica.Infra.ORM.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Infra.ORM.Features.ClientesFisicos
{
    public class ClienteFisicoRepositorio : IClienteFisicoRepositorio
    {
        SistemaGraficaContexto _contexto;
        public ClienteFisicoRepositorio(SistemaGraficaContexto contexto)
        {
            _contexto = contexto;
        }
        public ClienteFisicoRepositorio()
        {

        }
        public ClienteFisico Adicionar(ClienteFisico clienteFisico)
        {
            clienteFisico = _contexto.ClientesFisicos.Add(clienteFisico);
            _contexto.SaveChanges();
            return clienteFisico;
        }

        public ClienteFisico Buscar(int id)
        {
            ClienteFisico cliente = _contexto.ClientesFisicos.Find(id);
            return cliente;
        }

        public IList<ClienteFisico> BuscarTodos()
        {
            return _contexto.ClientesFisicos.ToList();
        }

        public ClienteFisico Editar(ClienteFisico clienteFisico)
        {
            _contexto.SaveChanges();
            return clienteFisico;
        }

        public void Excluir(ClienteFisico clienteFisico)
        {
            _contexto.ClientesFisicos.Remove(clienteFisico);
            _contexto.SaveChanges();
        }
    }
}
