using SistemaGrafica.Domain.feature.Fornecedores;
using SistemaGrafica.Domain.Feature.Fornecedores;
using SistemaGrafica.Infra.ORM.Base;
using System.Collections.Generic;
using System.Linq;

namespace SistemaGrafica.Infra.ORM.Features.Fornecedores
{
    public class FornecedoresRespositorio : IFornecedorRepositorio
    {
        SistemaGraficaContexto _contexto;
        public FornecedoresRespositorio(SistemaGraficaContexto contexto)
        {
            _contexto = contexto;
        }
        public FornecedoresRespositorio()
        {

        }

        public Fornecedor Adicionar(Fornecedor fornecedor)
        {
            fornecedor = _contexto.Fornecedores.Add(fornecedor);
            _contexto.SaveChanges();
            return fornecedor;
        }

        public Fornecedor Buscar(int id)
        {
            Fornecedor fornecedor = _contexto.Fornecedores.Find(id);
            return fornecedor;
        }

        public IList<Fornecedor> BuscarTodos()
        {
            return _contexto.Fornecedores.ToList();
        }

        public Fornecedor Editar(Fornecedor fornecedor)
        {
            _contexto.SaveChanges();
            return fornecedor;
        }

        public void Excluir(Fornecedor fornecedor)
        {
            _contexto.Fornecedores.Remove(fornecedor);
            _contexto.SaveChanges();
        }
    }
}
