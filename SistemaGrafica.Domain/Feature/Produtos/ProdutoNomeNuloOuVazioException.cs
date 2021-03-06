﻿using SistemaGrafica.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Domain.Feature.Produtos
{
    public class ProdutoNomeNuloOuVazioException : BusinessException
    {
        public ProdutoNomeNuloOuVazioException() : base("O nome do produto não pode estar nulo ou vazio")
        {
        }
    }
}
