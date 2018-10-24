using SistemaGrafica.Domain.Base;
using SistemaGrafica.Domain.feature.Enderecos;
using SistemaGrafica.Infra.common.cpnj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Domain.feature.Fornecedores
{
    public class Fornecedor : Entidade
    {
        public string Nome { get; set; }
        public string RazaoSocial { get; set; }
        public CNPJ Cnpj { get; set; }
        public string CNPJuridica { get; set; }
        public int InscricaoEstadual { get; set; }
        public int InscricaoMunicipal { get; set; }
        public Endereco Endereco { get; set; }
        public int TelefonePrincipal { get; set; }
        public int TelefoneSecundario { get; set; }

        public override void Validar()
        {
            throw new NotImplementedException();
        }
    }
}
