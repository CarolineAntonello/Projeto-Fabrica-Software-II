using SistemaGrafica.Aplication.Feature.Servicos;
using SistemaGrafica.Domain.feature.Servicos;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaGrafica.Presentation.feature.Inicio
{
    public partial class TelaInicial : Form
    {
        private Servico _servico;
        ServicoService _service;
        public TelaInicial(ServicoService service)
        {
            _service = service;
            InitializeComponent();
            btnSalvar.Enabled = false;
        }

        public Servico NovoServico
        {
            get
            {
                _servico = new Servico();
                _servico.ValorUnitario = Convert.ToInt32(txtValor.Text);
                _servico.TipoServico = cbxTipo.Text;
                return _servico;
            }
        }

        public Servico EditarServico
        {
            get
            {
                _servico.ValorUnitario = Convert.ToInt32(txtValor.Text);
                _servico.TipoServico = cbxTipo.Text;
                return _servico;
            }
            set
            {
                txtValor.Text = string.Empty;
                cbxTipo.Text = string.Empty;
                _servico = value;
                txtValor.Text = Convert.ToString(_servico.ValorUnitario);
                cbxTipo.Text = _servico.TipoServico;

            }
        }

        private void tabPageCliente_Click(object sender, EventArgs e)
        {

        }

        private void txtEstadual_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblErro.Text = string.Empty;
                if (_servico == null)
                {
                    _servico = new Servico();
                }
                _servico.ValorUnitario = Convert.ToInt32(txtValor.Text);
                _servico.TipoServico = cbxTipo.Text;
                _servico.Validar();
                btnSalvar.Enabled = true;
            }
            catch (Exception ex)
            {
                btnSalvar.Enabled = false;
                lblErro.ForeColor = Color.Red;
                lblErro.Text = ex.Message;
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
