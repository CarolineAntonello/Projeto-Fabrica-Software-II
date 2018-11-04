using SistemaGrafica.Domain.feature.Orcamentos;
using SistemaGrafica.Domain.Feature.Orcamentos;
using SistemaGrafica.Infra.ORM.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Infra.ORM.Features.Orcamentos
{
    public class OrcamentoRepositorio : IOrcamentoRepositorio
    {
        SistemaGraficaContexto _contexto;
        public OrcamentoRepositorio(SistemaGraficaContexto contexto)
        {
            _contexto = contexto;
        }
        public Orcamento Adicionar(Orcamento Orcamento)
        {
            Orcamento = _contexto.Orcamentos.Add(Orcamento);
            _contexto.SaveChanges();
            return Orcamento;
        }

        public Orcamento Buscar(int id)
        {
            Orcamento Orcamento = _contexto.Orcamentos.Find(id);
            return Orcamento;
        }

        public IList<Orcamento> BuscarTodos()
        {
            return _contexto.Orcamentos.ToList();
        }

        public Orcamento Editar(Orcamento Orcamento)
        {
            _contexto.SaveChanges();
            return Orcamento;
        }

        public void Excluir(Orcamento Orcamento)
        {
            _contexto.Orcamentos.Remove(Orcamento);
            _contexto.SaveChanges();
        }
    }
}
