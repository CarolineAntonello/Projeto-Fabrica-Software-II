using SistemaGrafica.Domain.Base;
using SistemaGrafica.Domain.feature.Enderecos;
using SistemaGrafica.Infra.common.cpnj;
using SistemaGrafica.Infra.common.inscricoesEstaduais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Domain.feature.ClientesJuridicos
{
    public class ClienteJuridico : Entidade
    {
        public string Nome { get; set; }
        public string RazaoSocial { get; set; }
        public CNPJ cnpj { get; set; }
        public string CNPJuridica { get; set; }
        public InscricaoEstadual InscricaoEstadual { get; set; }
        public int inscricaoEstadual { get; set; }
        public int InscricaoMunicipal { get; set; }
        public Endereco Endereco { get; set; }
        public int TelefonePrincipal { get; set; }
        public int TelefoneSecundario { get; set; }

        public override void Validar()
        {
            if (String.IsNullOrEmpty(Nome))
                throw new ClienteNomeVazioException();
            if (String.IsNullOrEmpty(RazaoSocial))
                throw new ClienteRazaoSocialVazioException();
            if (String.IsNullOrEmpty(CNPJuridica))
                throw new ClienteCNPJuridicaVazioException();
            if (TelefonePrincipal < 0 || TelefoneSecundario <0)
                throw new ClienteTelefoneVazioException();
            if (Endereco == null)
                throw new ClienteEnderecoVazioException();
        }
    }
}
