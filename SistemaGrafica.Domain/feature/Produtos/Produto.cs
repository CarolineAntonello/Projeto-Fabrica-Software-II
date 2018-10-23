using SistemaGrafica.Domain.Base;
using SistemaGrafica.Domain.feature.Fornecedores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Domain.feature.Produtos
{
    public class Produto : Entidade
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal ValorUnitario { get; set; }
        public int FornecedorId { get; set; }
        public Fornecedor Fornecedor { get; set; }

        public override void Validar()
        {
            //if (string.IsNullOrEmpty(Nome))
            //    throw new 

            if (string.IsNullOrEmpty(Descricao))
                throw new

            if (ValorUnitario <= 0)
                throw new

            if (Fornecedor == null)

        }
    }
}
