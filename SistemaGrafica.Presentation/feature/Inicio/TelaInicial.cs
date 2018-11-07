using SistemaGrafica.Aplication.Feature.ClientesFisicos;
using SistemaGrafica.Aplication.Feature.ClientesJuridicos;
using SistemaGrafica.Aplication.Feature.Fornecedores;
using SistemaGrafica.Aplication.Feature.Servicos;
using SistemaGrafica.Domain.feature.ClientesFisicos;
using SistemaGrafica.Domain.feature.ClientesJuridicos;
using SistemaGrafica.Domain.feature.Fornecedores;
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
        private ClienteJuridico _clienteJuridico;
        private Fornecedor _fornecedor;
        ServicoService _serviceServico;
        ClienteFisicoService _serviceClienteFisico;
        ClienteJuridicoService _serviceClienteJuridico;
        FornecedorService _serviceFornecedor;
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
        public TelaInicial(ClienteJuridicoService service)
        {
            _serviceClienteJuridico = service;
            InitializeComponent();
            btnSalvar.Enabled = false;
        }
        public TelaInicial(FornecedorService service)
        {
            _serviceFornecedor = service;
            InitializeComponent();
            btnFSalvar.Enabled = false;
        }

        #region Fornecedor

        public Fornecedor NovoFornecedor
        {
            get
            {
                _fornecedor = new Fornecedor();
                _fornecedor.Nome = txtFNome.Text;
                _fornecedor.CNPJuridica = txtFCPF.Text;
                _fornecedor.Endereco.Bairro = txtFBairro.Text;
                _fornecedor.Endereco.Cep = txtFCep.Text;
                _fornecedor.Endereco.Cidade = txtFCidade.Text;
                _fornecedor.Endereco.Complemento = txtFComplemento.Text;
                _fornecedor.Endereco.Estado = cmxFUf.Text;
                //TODO: Implementar Campos Telefone e Telefone Secundário
                return _fornecedor;
            }

        }

        public Fornecedor EditarFornecedor
        {
            get
            {
                _fornecedor = new Fornecedor();
                _fornecedor.Nome = txtFNome.Text;
                _fornecedor.CNPJuridica = txtFCPF.Text;
                _fornecedor.Endereco.Bairro = txtFBairro.Text;
                _fornecedor.Endereco.Cep = txtFCep.Text;
                _fornecedor.Endereco.Cidade = txtFCidade.Text;
                _fornecedor.Endereco.Complemento = txtFComplemento.Text;
                _fornecedor.Endereco.Estado = cmxFUf.Text;
                //TODO: Implementar Campos Telefone e Telefone Secundário
                return _fornecedor;
            }
            set
            {
                txtFNome.Text = string.Empty;
                txtFCPF.Text = string.Empty;
                txtFBairro.Text = string.Empty;
                txtFCep.Text = string.Empty;
                txtFCidade.Text = string.Empty;
                txtFComplemento.Text = string.Empty;
                cmxFUf.Text = string.Empty;
                _fornecedor = value;
                txtFNome.Text = _fornecedor.Nome;
                txtFCPF.Text = _fornecedor.CNPJuridica;
                txtFBairro.Text = _fornecedor.Endereco.Bairro;
                txtFCep.Text = _fornecedor.Endereco.Cep;
                txtFCidade.Text = _fornecedor.Endereco.Cidade;
                txtFComplemento.Text = _fornecedor.Endereco.Complemento;
                cmxFUf.Text = _fornecedor.Endereco.Estado;

            }

        }

        //TODO: Criar lblERROCF na tela Inicial
        public void NomeF(object Sender, EventArgs e)
        {
            try
            {
                lblErroF.Text = string.Empty;
                if (_fornecedor == null)
                {
                    _fornecedor = new Fornecedor();
                }
                _fornecedor.Nome = txtFNome.Text;
                _fornecedor.Validar();
                btnCSalvar.Enabled = true;
            }
            catch (Exception ex)
            {
                btnCSalvar.Enabled = false;
                lblErroF.ForeColor = Color.Red;
                lblErroF.Text = ex.Message;
            }

        }
        public void CpfF(object Sender, EventArgs e)
        {
            try
            {
                lblErroF.Text = string.Empty;
                if (_fornecedor == null)
                {
                    _fornecedor = new Fornecedor();
                }
                _fornecedor.CNPJuridica = txtFCPF.Text;
                _fornecedor.Validar();
                btnCSalvar.Enabled = true;
            }
            catch (Exception ex)
            {
                btnCSalvar.Enabled = false;
                lblErroF.ForeColor = Color.Red;
                lblErroF.Text = ex.Message;
            }

        }
        public void BairroF(object Sender, EventArgs e)
        {
            try
            {
                lblErroF.Text = string.Empty;
                if (_fornecedor == null)
                {
                    _fornecedor = new Fornecedor();
                }
                _fornecedor.Endereco.Bairro = txtFBairro.Text;
                _fornecedor.Validar();
                btnCSalvar.Enabled = true;
            }
            catch (Exception ex)
            {
                btnCSalvar.Enabled = false;
                lblErroF.ForeColor = Color.Red;
                lblErroF.Text = ex.Message;
            }

        }
        public void CepF(object Sender, EventArgs e)
        {
            try
            {
                lblErroF.Text = string.Empty;
                if (_fornecedor == null)
                {
                    _fornecedor = new Fornecedor();
                }
                _fornecedor.Endereco.Cep = txtFCep.Text;
                _fornecedor.Validar();
                btnCSalvar.Enabled = true;
            }
            catch (Exception ex)
            {
                btnCSalvar.Enabled = false;
                lblErroF.ForeColor = Color.Red;
                lblErroF.Text = ex.Message;
            }

        }
        public void CidadeF(object Sender, EventArgs e)
        {
            try
            {
                lblErroF.Text = string.Empty;
                if (_fornecedor == null)
                {
                    _fornecedor = new Fornecedor();
                }
                _fornecedor.Endereco.Cidade = txtFCidade.Text;
                _fornecedor.Validar();
                btnCSalvar.Enabled = true;
            }
            catch (Exception ex)
            {
                btnCSalvar.Enabled = false;
                lblErroF.ForeColor = Color.Red;
                lblErroF.Text = ex.Message;
            }

        }
        public void ComplementoF(object Sender, EventArgs e)
        {
            try
            {
                lblErroF.Text = string.Empty;
                if (_fornecedor == null)
                {
                    _fornecedor = new Fornecedor();
                }
                _fornecedor.Endereco.Complemento = txtFComplemento.Text;
                _fornecedor.Validar();
                btnCSalvar.Enabled = true;
            }
            catch (Exception ex)
            {
                btnCSalvar.Enabled = false;
                lblErroF.ForeColor = Color.Red;
                lblErroF.Text = ex.Message;
            }
        }
        public void EstadoF(object Sender, EventArgs e)
        {
            try
            {
                lblErroF.Text = string.Empty;
                if (_fornecedor == null)
                {
                    _fornecedor = new Fornecedor();
                }
                _fornecedor.Endereco.Estado = cmxFUf.Text;
                _fornecedor.Validar();
                btnCSalvar.Enabled = true;
            }
            catch (Exception ex)
            {
                btnCSalvar.Enabled = false;
                lblErroF.ForeColor = Color.Red;
                lblErroF.Text = ex.Message;
            }
        }



        #endregion

        #region ClienteJuridico

        public ClienteJuridico NovoClienteJuridico
        {
            get
            {
                _clienteJuridico = new ClienteJuridico();
                _clienteJuridico.Nome = txtNome.Text;
                _clienteJuridico.CNPJuridica = txtCpf.Text;
                _clienteJuridico.Endereco.Bairro = txtBairro.Text;
                _clienteJuridico.Endereco.Cep = txtCEP.Text;
                _clienteJuridico.Endereco.Cidade = txtCidade.Text;
                _clienteJuridico.Endereco.Complemento = txtComplemento.Text;
                _clienteJuridico.Endereco.Estado = cmxUf.Text;
                //TODO: Implementar Campos Telefone e Telefone Secundário
                return _clienteJuridico;
            }

        }

        public ClienteJuridico EditarClienteJuridico
        {
            get
            {
                _clienteJuridico.Nome = txtNome.Text;
                _clienteJuridico.CNPJuridica = txtCpf.Text;
                _clienteJuridico.Endereco.Bairro = txtBairro.Text;
                _clienteJuridico.Endereco.Cep = txtCEP.Text;
                _clienteJuridico.Endereco.Cidade = txtCidade.Text;
                _clienteJuridico.Endereco.Complemento = txtComplemento.Text;
                _clienteJuridico.Endereco.Estado = cmxUf.Text;
                //TODO: Implementar Campos Telefone e Telefone Secundário
                return _clienteJuridico;
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
                _clienteJuridico = value;
                txtNome.Text = _clienteJuridico.Nome;
                txtCpf.Text = _clienteJuridico.CNPJuridica;
                txtBairro.Text = _clienteJuridico.Endereco.Bairro;
                txtCEP.Text = _clienteJuridico.Endereco.Cep;
                txtCidade.Text = _clienteJuridico.Endereco.Cidade;
                txtComplemento.Text = _clienteJuridico.Endereco.Complemento;
                cmxUf.Text = _clienteJuridico.Endereco.Estado;

            }

        }
        
        //TODO: Criar lblERROCF na tela Inicial
        public void NomeCJ(object Sender, EventArgs e)
        {
            try
            {
                lblErroCF.Text = string.Empty;
                if (_clienteJuridico == null)
                {
                    _clienteJuridico = new ClienteJuridico();
                }
                _clienteJuridico.Nome = txtNome.Text;
                _clienteJuridico.Validar();
                btnCSalvar.Enabled = true;
            }
            catch (Exception ex)
            {
                btnCSalvar.Enabled = false;
                lblErroCF.ForeColor = Color.Red;
                lblErroCF.Text = ex.Message;
            }

        }
        public void CpfCJ(object Sender, EventArgs e)
        {
            try
            {
                lblErroCF.Text = string.Empty;
                if (_clienteJuridico == null)
                {
                    _clienteJuridico = new ClienteJuridico();
                }
                _clienteJuridico.CNPJuridica = txtCpf.Text;
                _clienteJuridico.Validar();
                btnCSalvar.Enabled = true;
            }
            catch (Exception ex)
            {
                btnCSalvar.Enabled = false;
                lblErroCF.ForeColor = Color.Red;
                lblErroCF.Text = ex.Message;
            }

        }
        public void BairroCJ(object Sender, EventArgs e)
        {
            try
            {
                lblErroCF.Text = string.Empty;
                if (_clienteJuridico == null)
                {
                    _clienteJuridico = new ClienteJuridico();
                }
                _clienteFisico.Endereco.Bairro = txtBairro.Text;
                _clienteJuridico.Validar();
                btnCSalvar.Enabled = true;
            }
            catch (Exception ex)
            {
                btnCSalvar.Enabled = false;
                lblErroCF.ForeColor = Color.Red;
                lblErroCF.Text = ex.Message;
            }

        }
        public void CepCJ(object Sender, EventArgs e)
        {
            try
            {
                lblErroCF.Text = string.Empty;
                if (_clienteJuridico == null)
                {
                    _clienteJuridico = new ClienteJuridico();
                }
                _clienteJuridico.Endereco.Cep = txtCEP.Text;
                _clienteJuridico.Validar();
                btnCSalvar.Enabled = true;
            }
            catch (Exception ex)
            {
                btnCSalvar.Enabled = false;
                lblErroCF.ForeColor = Color.Red;
                lblErroCF.Text = ex.Message;
            }

        }
        public void CidadeCJ(object Sender, EventArgs e)
        {
            try
            {
                lblErroCF.Text = string.Empty;
                if (_clienteJuridico == null)
                {
                    _clienteJuridico = new ClienteJuridico();
                }
                _clienteJuridico.Endereco.Cidade = txtCidade.Text;
                _clienteJuridico.Validar();
                btnCSalvar.Enabled = true;
            }
            catch (Exception ex)
            {
                btnCSalvar.Enabled = false;
                lblErroCF.ForeColor = Color.Red;
                lblErroCF.Text = ex.Message;
            }

        }
        public void ComplementoCJ(object Sender, EventArgs e)
        {
            try
            {
                lblErroCF.Text = string.Empty;
                if (_clienteJuridico == null)
                {
                    _clienteJuridico = new ClienteJuridico();
                }
                _clienteJuridico.Endereco.Complemento = txtComplemento.Text;
                _clienteJuridico.Validar();
                btnCSalvar.Enabled = true;
            }
            catch (Exception ex)
            {
                btnCSalvar.Enabled = false;
                lblErroCF.ForeColor = Color.Red;
                lblErroCF.Text = ex.Message;
            }
        }
        public void EstadoCJ(object Sender, EventArgs e)
        {
            try
            {
                lblErroCF.Text = string.Empty;
                if (_clienteJuridico == null)
                {
                    _clienteJuridico = new ClienteJuridico();
                }
                _clienteJuridico.Endereco.Estado = cmxUf.Text;
                _clienteJuridico.Validar();
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
       
        #region ClienteFisico
        public ClienteFisico NovoClienteFisico
        {
            get
            {
                _clienteFisico = new ClienteFisico();
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
                _clienteFisico.Validar();
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
                _clienteFisico.Validar();
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
                _clienteFisico.Validar();
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
                _clienteFisico.Validar();
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
                _clienteFisico.Validar();
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
                _clienteFisico.Validar();
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
                _clienteFisico.Validar();
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
