using SistemaGrafica.Aplication.Feature.ClientesFisicos;
using SistemaGrafica.Aplication.Feature.Servicos;
using SistemaGrafica.Domain.feature.ClientesFisicos;
using SistemaGrafica.Domain.feature.Servicos;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaGrafica.Presentation.feature.Inicio
{
    public partial class TelaInicial : Form
    {
        private Servico _servico;
        private ClienteFisico _clienteFisico;
        ServicoService _serviceServico;
        ClienteFisicoService _serviceClienteFisico;
        public TelaInicial(ServicoService service)
        {
            _serviceServico = service;
            InitializeComponent();
            btnSalvar.Enabled = false;
            //lblErro.Text = "Teste de erro";
        }
        public TelaInicial(ClienteFisicoService service)
        {
            _serviceClienteFisico = service;
            InitializeComponent();
            btnCSalvar.Enabled = false;
        }

        #region ClienteFisico
        public ClienteFisico NovoClienteFisico
        {
            get
            {
                _clienteFisico = new ClienteFisico();
                _clienteFisico.Nome = txtFNome.Text;
                _clienteFisico.Cpf.Numero = txtFCPF.Text;
                _clienteFisico.Endereco.Bairro = txtBairro.Text;
                _clienteFisico.Endereco.Cep = txtCEP.Text;
                _clienteFisico.Endereco.Cidade = txtCidade.Text;
                _clienteFisico.Endereco.Complemento = txtComplemento.Text;
                _clienteFisico.Endereco.Estado = cmxUf.Text;
                //TODO: Implementar Campos Telefone e Telefone Secundário
                return _clienteFisico;
            }

        }

        public ClienteFisico EditarClienteFisico
        {
            get
            {
                _clienteFisico.Nome = txtNome.Text;
                _clienteFisico.Cpf.Numero = txtCpf.Text;
                _clienteFisico.Endereco.Bairro = txtBairro.Text;
                _clienteFisico.Endereco.Cep = txtCEP.Text;
                _clienteFisico.Endereco.Cidade = txtCidade.Text;
                _clienteFisico.Endereco.Complemento = txtComplemento.Text;
                _clienteFisico.Endereco.Estado = cmxUf.Text;
                //TODO: Implementar Campos Telefone e Telefone Secundário
                return _clienteFisico;
            }
            set
            {
                txtNome.Text = string.Empty;
                txtCpf.Text = string.Empty;
                txtBairro.Text = string.Empty;
                txtCEP.Text = string.Empty;
                txtCidade.Text = string.Empty;
                txtComplemento.Text = string.Empty;
                cmxUf.Text = string.Empty;
                _clienteFisico = value;
                txtNome.Text = _clienteFisico.Nome;
                txtCpf.Text = _clienteFisico.Cpf.Numero;
                txtBairro.Text = _clienteFisico.Endereco.Bairro;
                txtCEP.Text = _clienteFisico.Endereco.Cep;
                txtCidade.Text = _clienteFisico.Endereco.Cidade;
                txtComplemento.Text = _clienteFisico.Endereco.Complemento;
                cmxUf.Text = _clienteFisico.Endereco.Estado;

            }
            
        }
        //CF == Cliente Fisico
        //TODO: Criar lblERROCF na tela Inicial
        public void NomeCF(object Sender, EventArgs e)
        {
            try
            {
                lblErroCF.Text = string.Empty;
                if (_clienteFisico == null)
                {
                    _clienteFisico = new ClienteFisico();
                }
                _clienteFisico.Nome = txtNome.Text;
                _servico.Validar();
                btnCSalvar.Enabled = true;
            }
            catch (Exception ex)
            {
                btnCSalvar.Enabled = false;
                lblErroCF.ForeColor = Color.Red;
                lblErroCF.Text = ex.Message;
            }

        }
        public void CpfCF(object Sender, EventArgs e)
        {
            try
            {
                lblErroCF.Text = string.Empty;
                if (_clienteFisico == null)
                {
                    _clienteFisico = new ClienteFisico();
                }
                _clienteFisico.Cpf.Numero = txtCpf.Text;
                _servico.Validar();
                btnCSalvar.Enabled = true;
            }
            catch (Exception ex)
            {
                btnCSalvar.Enabled = false;
                lblErroCF.ForeColor = Color.Red;
                lblErroCF.Text = ex.Message;
            }

        }
        public void BairroCF(object Sender, EventArgs e)
        {
            try
            {
                lblErroCF.Text = string.Empty;
                if (_clienteFisico == null)
                {
                    _clienteFisico = new ClienteFisico();
                }
                _clienteFisico.Endereco.Bairro = txtBairro.Text;
                _servico.Validar();
                btnCSalvar.Enabled = true;
            }
            catch (Exception ex)
            {
                btnCSalvar.Enabled = false;
                lblErroCF.ForeColor = Color.Red;
                lblErroCF.Text = ex.Message;
            }

        }
        public void CepCF(object Sender, EventArgs e)
        {
            try
            {
                lblErroCF.Text = string.Empty;
                if (_clienteFisico == null)
                {
                    _clienteFisico = new ClienteFisico();
                }
                _clienteFisico.Endereco.Cep = txtCEP.Text;
                _servico.Validar();
                btnCSalvar.Enabled = true;
            }
            catch (Exception ex)
            {
                btnCSalvar.Enabled = false;
                lblErroCF.ForeColor = Color.Red;
                lblErroCF.Text = ex.Message;
            }

        }
        public void CidadeCF(object Sender, EventArgs e)
        {
            try
            {
                lblErroCF.Text = string.Empty;
                if (_clienteFisico == null)
                {
                    _clienteFisico = new ClienteFisico();
                }
                _clienteFisico.Endereco.Cidade = txtCidade.Text;
                _servico.Validar();
                btnCSalvar.Enabled = true;
            }
            catch (Exception ex)
            {
                btnCSalvar.Enabled = false;
                lblErroCF.ForeColor = Color.Red;
                lblErroCF.Text = ex.Message;
            }

        }
        public void ComplementoCF(object Sender, EventArgs e)
        {
            try
            {
                lblErroCF.Text = string.Empty;
                if (_clienteFisico == null)
                {
                    _clienteFisico = new ClienteFisico();
                }
                _clienteFisico.Endereco.Complemento = txtComplemento.Text;
                _servico.Validar();
                btnCSalvar.Enabled = true;
            }
            catch (Exception ex)
            {
                btnCSalvar.Enabled = false;
                lblErroCF.ForeColor = Color.Red;
                lblErroCF.Text = ex.Message;
            }
        }
        public void EstadoCF(object Sender, EventArgs e)
        {
            try
            {
                lblErroCF.Text = string.Empty;
                if (_clienteFisico == null)
                {
                    _clienteFisico = new ClienteFisico();
                }
                _clienteFisico.Endereco.Estado = cmxUf.Text;
                _servico.Validar();
                btnCSalvar.Enabled = true;
            }
            catch (Exception ex)
            {
                btnCSalvar.Enabled = false;
                lblErroCF.ForeColor = Color.Red;
                lblErroCF.Text = ex.Message;
            }
        }

        #endregion

        public Servico NovoServico
        {
            get
            {
                _servico = new Servico();
                _servico.ValorUnitario = Convert.ToInt32(txtValor.Text);
                _servico.TipoServico = cbxTipo.Text;
                _servico.Descricao = txtDescricao.Text;
                return _servico;
            }
        }

        public Servico EditarServico
        {
            get
            {
                _servico.ValorUnitario = Convert.ToInt32(txtValor.Text);
                _servico.TipoServico = cbxTipo.Text;
                _servico.Descricao = txtDescricao.Text;
                return _servico;
            }
            set
            {
                txtValor.Text = string.Empty;
                cbxTipo.Text = string.Empty;
                txtDescricao.Text = string.Empty;
                _servico = value;
                txtValor.Text = Convert.ToString(_servico.ValorUnitario);
                cbxTipo.Text = _servico.TipoServico;
                txtDescricao.Text = _servico.Descricao;

            }
        }

        private void TipoServico(object sender, EventArgs e)
        {
            try
            {
                lblErro.Text = string.Empty;
                if (_servico == null)
                {
                    _servico = new Servico();
                }
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

        private void Valor(object sender, EventArgs e)
        {
            try
            {
                lblErro.Text = string.Empty;
                if (_servico == null)
                {
                    _servico = new Servico();
                }
                _servico.ValorUnitario = Convert.ToInt32(txtValor.Text);
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

        private void DescricaoServico(object sender, EventArgs e)
        {
            try
            {
                lblErro.Text = string.Empty;
                if (_servico == null)
                {
                    _servico = new Servico();
                }
                _servico.Descricao = txtDescricao.Text;
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
    }
}
