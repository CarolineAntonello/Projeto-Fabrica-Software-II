using SistemaGrafica.Domain.feature.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Domain.Feature.Servicos
{
    public interface IServicoRepositorio
    {
        Servico Adicionar(Servico servico);
        Servico Editar(Servico servico);
        Servico Buscar(int id);
        IList<Servico> BuscarTodos();
        void Excluir(Servico servico);
    }
}
