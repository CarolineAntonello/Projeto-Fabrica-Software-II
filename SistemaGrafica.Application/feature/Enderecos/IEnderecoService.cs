using SistemaGrafica.Domain.feature.Enderecos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Aplication.Feature.Enderecos
{
    public interface IEnderecoService
    {
        Endereco Adicionar(Endereco endereco);
        Endereco Atualizar(Endereco endereco);
        void Excluir(Endereco endereco);
        IEnumerable<Endereco> BuscarTodos();
        Endereco BuscarPorId(long id);
    }
}
