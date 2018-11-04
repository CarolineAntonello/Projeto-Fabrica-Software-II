using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGrafica.Domain.feature.Orcamentos;
using SistemaGrafica.Domain.Feature.Orcamentos;

namespace SistemaGrafica.Application.Feature.Orcamentos
{
    public class OrcamentoService : IOrcamentoService
    {
        IOrcamentoRepositorio _orcamentoRepositorio;

        public OrcamentoService(IOrcamentoRepositorio orcamentoRepositorio)
        {
            orcamentoRepositorio = _orcamentoRepositorio;
        }
        public Orcamento Adicionar(Orcamento orcamento)
        {
            orcamento.Validar();

            return _orcamentoRepositorio.Adicionar(orcamento);
        }

        public Orcamento Atualizar(Orcamento orcamento)
        {
            orcamento.Validar();

            return _orcamentoRepositorio.Editar(orcamento);
        }

        public Orcamento BuscarPorId(int id)
        {
            return _orcamentoRepositorio.Buscar(id);
        }

        public IEnumerable<Orcamento> BuscarTodos()
        {
            return _orcamentoRepositorio.BuscarTodos();
        }

        public void Excluir(Orcamento orcamento)
        {
            _orcamentoRepositorio.Excluir(orcamento);
        }
    }
}
