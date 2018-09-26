using SistemaGrafica.Presentation.feature.Inicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGrafica.Presentation
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void TelaAcesso_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            TelaInicial inicial = new TelaInicial();
            inicial.Show();
            this.Hide();
        }
    }
}
