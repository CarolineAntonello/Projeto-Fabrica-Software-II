using SistemaGrafica.Presentation.feature.Inicio;
using System;
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
            //string usuario = "admin";
            //string senha = "123";
            //if(txtUsuario.Text == usuario && txtSenha.Text == senha)
            //{
            //    TelaInicial inicial = new TelaInicial();
            //    inicial.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Login Incorreto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            
        }
    }
}
