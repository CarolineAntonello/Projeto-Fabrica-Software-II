using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGrafica.Domain.Base
{
    public abstract class Entidade
    {
        public virtual int Id { get; set; }

        public abstract void Validar();
    }
}
