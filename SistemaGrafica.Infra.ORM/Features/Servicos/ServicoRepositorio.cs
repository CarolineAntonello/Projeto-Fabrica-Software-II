using SistemaGrafica.Domain.feature.Servicos;
using SistemaGrafica.Domain.Feature.Servicos;
using SistemaGrafica.Infra.ORM.Base;
using System.Collections.Generic;
using System.Linq;

namespace SistemaGrafica.Infra.ORM.Features.Servicos
{
    public class ServicoRepositorio : IServicoRepositorio
    {
        SistemaGraficaContexto _contexto;
        public ServicoRepositorio(SistemaGraficaContexto contexto)
        {
            _contexto = contexto;
        }
        public ServicoRepositorio()
        {

        }
        public Servico Adicionar(Servico servico)
        {
            servico = _contexto.Servicos.Add(servico);
            _contexto.SaveChanges();
            return servico;
        }

        public Servico Buscar(int id)
        {
            Servico servico = _contexto.Servicos.Find(id);
            return servico;
        }

        public IList<Servico> BuscarTodos()
        {
            return _contexto.Servicos.ToList();
        }

        public Servico Editar(Servico servico)
        {
            _contexto.SaveChanges();
            return servico;
        }

        public void Excluir(Servico servico)
        {
            _contexto.Servicos.Remove(servico);
            _contexto.SaveChanges();
        }
    }
}
