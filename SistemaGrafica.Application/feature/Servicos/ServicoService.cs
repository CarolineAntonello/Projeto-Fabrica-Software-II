using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGrafica.Domain.feature.Servicos;
using SistemaGrafica.Domain.Feature.Servicos;

namespace SistemaGrafica.Aplication.Feature.Servicos
{
    public class ServicoService : IServicoService
    {
        IServicoRepositorio _servicoRepositorio;

        public ServicoService(IServicoRepositorio servicoRepositorio)
        {
            servicoRepositorio = _servicoRepositorio;
        }
        public Servico Adicionar(Servico servico)
        {
            servico.Validar();

            return _servicoRepositorio.Adicionar(servico);
        }

        public Servico Atualizar(Servico servico)
        {
            servico.Validar();

            return _servicoRepositorio.Editar(servico);
        }

        public Servico BuscarPorId(int id)
        {
            return _servicoRepositorio.Buscar(id);
        }

        public IEnumerable<Servico> BuscarTodos()
        {
            return _servicoRepositorio.BuscarTodos();
        }

        public void Excluir(Servico servico)
        {
            _servicoRepositorio.Excluir(servico);
        }
    }
}
