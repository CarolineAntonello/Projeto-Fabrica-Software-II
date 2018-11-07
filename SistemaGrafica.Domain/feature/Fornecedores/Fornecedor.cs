using SistemaGrafica.Domain.Base;
using SistemaGrafica.Domain.common.cnpjs;
using SistemaGrafica.Domain.feature.Enderecos;
using SistemaGrafica.Domain.Features.Fornecedores;

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
            if (string.IsNullOrEmpty(Nome))
                throw new FornecedorNomeVazioOuNuloException();

            if (string.IsNullOrEmpty(RazaoSocial))
                throw new FornecedorRazaoSocialNuloOuVazioException();

            if (string.IsNullOrEmpty(CNPJuridica))
                throw new FornecedorCNPJNuloOuVazioException();

            if (InscricaoEstadual <= 0)
                throw new FornecedorInscricaoEstadualVazioException();

            if (InscricaoMunicipal <= 0)
                throw new FornecedorInscricaoMunicipalVazioException();

            if (Endereco == null)
                throw new FornecedorEnderecoNuloException();

            if (TelefonePrincipal <= 0)
                throw new FornecedorTelefonePrincipalVazioException();
        }
    }
}
