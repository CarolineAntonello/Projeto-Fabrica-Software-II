﻿using SistemaGrafica.Domain.Base;
using SistemaGrafica.Domain.feature.ClientesJuridicos;
using SistemaGrafica.Domain.feature.Enderecos;
using SistemaGrafica.Infra.common.cpfs;
using System;

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

        public override void Validar()
        {
            if (String.IsNullOrEmpty(Nome))
                throw new ClienteNomeVazioException();
            if (String.IsNullOrEmpty(CPFisica))
                throw new ClienteCPFVazioException();
            if (TelefonePrincipal < 0 || TelefoneSecundario < 0)
                throw new ClienteTelefoneVazioException();
        }
    }
}
