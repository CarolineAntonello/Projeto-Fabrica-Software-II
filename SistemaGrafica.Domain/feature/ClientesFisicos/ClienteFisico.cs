using SistemaGrafica.Domain.Base;
using SistemaGrafica.Domain.feature.Enderecos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Domain.feature.ClientesFisicos
{
    public class ClienteFisico : Entidade
    {
        public string Nome { get; set; }
        public CPF Cpf { get; set; }
        public string CPFisica { get; set; }
        public Endereco Endereco { get; set; }
        public int TelefonePrincipal { get; set; }
        public int TelefoneSecundario { get; set; }
    }
}
