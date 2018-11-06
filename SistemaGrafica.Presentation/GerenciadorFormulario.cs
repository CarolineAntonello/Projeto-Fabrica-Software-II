using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGrafica.Presentation
{
    public abstract class GerenciadorFormulario
    {
        public abstract void Adicionar();
        public abstract void Editar();
        public abstract void Remover();
        public abstract UserControl CarregarListagem();
        public abstract string ObtemTipoCadastro();
        public virtual void Pesquisa(string texto) { }
    }
}
