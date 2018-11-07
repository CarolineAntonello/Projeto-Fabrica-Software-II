using SistemaGrafica.Aplication.Feature.Produtos;
using SistemaGrafica.Aplication.Feature.Servicos;
using SistemaGrafica.Domain.feature.Produtos;
using SistemaGrafica.Domain.feature.Servicos;
using SistemaGrafica.Infra.IOC;
using SistemaGrafica.Presentation.Feature.Inicio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaGrafica.Presentation.feature.Inicio
{
    public partial class TelaInicial : Form
    {
        private Servico _servico;
        ServicoService _service;
        private Produto _produto;
        ProdutoService _produtoService = new ProdutoService(RepositorioIOC.produto);

        GerenciadorFormulario _gerenciadorFormulario;
        GerenciadorProduto _gerenciadorProduto;

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
                _fornecedor.InscricaoEstadual = Convert.ToInt32(txtFEstadual.Text);
                _fornecedor.InscricaoMunicipal = Convert.ToInt32(txtFMunicipal.Text);
                _fornecedor.RazaoSocial = txtFRazaoSocial.Text;
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
                _fornecedor.InscricaoEstadual = Convert.ToInt32(txtFEstadual.Text);
                _fornecedor.InscricaoMunicipal = Convert.ToInt32(txtFMunicipal.Text);
                _fornecedor.RazaoSocial = txtFRazaoSocial.Text;
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
                txtFEstadual.Text = string.Empty;
                txtFMunicipal.Text = string.Empty;
                txtFRazaoSocial.Text = string.Empty;
                txtFCPF.Text = string.Empty;
                txtFBairro.Text = string.Empty;
                txtFCep.Text = string.Empty;
                txtFCidade.Text = string.Empty;
                txtFComplemento.Text = string.Empty;
                cmxFUf.Text = string.Empty;
                _fornecedor = value;
                txtFNome.Text = _fornecedor.Nome;
                txtFRazaoSocial.Text = _fornecedor.RazaoSocial;
                txtFEstadual.Text = Convert.ToString(_fornecedor.InscricaoEstadual);
                txtFMunicipal.Text = Convert.ToString(_fornecedor.InscricaoMunicipal);
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
        public void InscricaoEstadualF(object Sender, EventArgs e)
        {
            try
            {
                lblErroF.Text = string.Empty;
                if (_fornecedor == null)
                {
                    _fornecedor = new Fornecedor();
                }
                _fornecedor.InscricaoEstadual = Convert.ToInt32(txtFEstadual.Text);
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
        public void InscricaoMunicipalF(object Sender, EventArgs e)
        {
            try
            {
                lblErroF.Text = string.Empty;
                if (_fornecedor == null)
                {
                    _fornecedor = new Fornecedor();
                }
                _fornecedor.InscricaoMunicipal = Convert.ToInt32(txtFMunicipal.Text);
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
        public void RazaoSocialF(object Sender, EventArgs e)
        {
            try
            {
                lblErroF.Text = string.Empty;
                if (_fornecedor == null)
                {
                    _fornecedor = new Fornecedor();
                }
                _fornecedor.RazaoSocial = txtFRazaoSocial.Text;
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
                _clienteJuridico.inscricaoEstadual = Convert.ToInt32(txtEstadual.Text);
                _clienteJuridico.InscricaoMunicipal = Convert.ToInt32(txtMunicipal.Text);
                _clienteJuridico.RazaoSocial = txtRazaoSocial.Text;
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
                _clienteJuridico.inscricaoEstadual = Convert.ToInt32(txtEstadual.Text);
                _clienteJuridico.InscricaoMunicipal = Convert.ToInt32(txtMunicipal.Text);
                _clienteJuridico.RazaoSocial = txtRazaoSocial.Text;
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
                txtEstadual.Text = string.Empty;
                txtMunicipal.Text = string.Empty;
                txtRazaoSocial.Text = string.Empty;
                txtCpf.Text = string.Empty;
                txtBairro.Text = string.Empty;
                txtCEP.Text = string.Empty;
                txtCidade.Text = string.Empty;
                txtComplemento.Text = string.Empty;
                cmxUf.Text = string.Empty;
                _clienteJuridico = value;
                txtNome.Text = _clienteJuridico.Nome;
                txtEstadual.Text = Convert.ToString(_clienteJuridico.inscricaoEstadual);
                txtMunicipal.Text = Convert.ToString(_clienteJuridico.InscricaoMunicipal);
                txtFRazaoSocial.Text = _clienteJuridico.RazaoSocial;
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
        public void InscricaoEstadualCJ(object Sender, EventArgs e)
        {
            try
            {
                lblErroCF.Text = string.Empty;
                if (_clienteJuridico == null)
                {
                    _clienteJuridico = new ClienteJuridico();
                }
                _clienteJuridico.inscricaoEstadual = Convert.ToInt32(txtEstadual.Text);
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
        public void InscricaoMunicipalCJ(object Sender, EventArgs e)
        {
            try
            {
                lblErroCF.Text = string.Empty;
                if (_clienteJuridico == null)
                {
                    _clienteJuridico = new ClienteJuridico();
                }
                _clienteJuridico.InscricaoMunicipal = Convert.ToInt32(txtMunicipal.Text);
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
        public void RazaoSocialCJ(object Sender, EventArgs e)
        {
            try
            {
                lblErroCF.Text = string.Empty;
                if (_clienteJuridico == null)
                {
                    _clienteJuridico = new ClienteJuridico();
                }
                _clienteJuridico.RazaoSocial = txtRazaoSocial.Text;
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

        public TelaInicial(ProdutoService produtoService)
        {
            _produtoService = produtoService;
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

        #region Produto

        private void CarregarCadastroProduto(GerenciadorFormulario gerenciador)
        {
            _gerenciadorFormulario = gerenciador;
           // toolStripPrincipal.Enabled = true;
           // lblTipoCadastro.Font = new Font(lblTipoCadastro.Font, FontStyle.Bold);
          //  lblTipoCadastro.Text = _gerenciador.ObtemTipoCadastro();
            UserControl listagem = _gerenciadorFormulario.CarregarListagem();
            listagem.Dock = DockStyle.Fill;
            panelProduto.Controls.Clear();
            panelProduto.Controls.Add(listagem);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                lblErroProduto.Text = string.Empty;
                _gerenciadorFormulario.Adicionar();

            }
            catch (Exception ex)
            {
                lblErroProduto.Text = ex.Message;
            }
        }

        public Produto NovoProduto
        {
            get
            {
                _produto = new Produto();
                _produto.ValorUnitario = Convert.ToInt32(txtPValor.Text);
                _produto.Nome = txtPNome.Text;
                _produto.Descricao = txtPDescricao.Text;
                return _produto;
            }
        }

        public Produto EditarProduto
        {
            get
            {
                _produto.ValorUnitario = Convert.ToInt32(txtPValor.Text);
                _produto.Nome = txtPNome.Text;
                _produto.Descricao = txtPDescricao.Text;
                return _produto;
            }
            set
            {
                txtPValor.Text = string.Empty;
                txtPNome.Text = string.Empty;
                txtPDescricao.Text = string.Empty;
                _produto = value;
                txtPValor.Text = Convert.ToString(_produto.ValorUnitario);
                txtPNome.Text = _produto.Nome;
                txtPDescricao.Text = _produto.Descricao;

            }
        }

        private void NomeProduto(object sender, EventArgs e)
        {
            try
            {
                lblErroProduto.Text = string.Empty;
                if (_produto == null)
                {
                    _produto = new Produto();
                }
                _produto.Nome = txtPNome.Text;
                _produto.Validar();
                btnSalvar.Enabled = true;
            }
            catch (Exception ex)
            {
                btnSalvar.Enabled = false;
                lblErroProduto.ForeColor = Color.Red;
                lblErroProduto.Text = ex.Message;
            }
        }

        private void ValorProduto(object sender, EventArgs e)
        {
            try
            {
                lblErroProduto.Text = string.Empty;
                if (_produto == null)
                {
                    _produto = new Produto();
                }
                _produto.ValorUnitario = Convert.ToInt32(txtPValor.Text);
                _produto.Validar();
                btnSalvar.Enabled = true;
            }
            catch (Exception ex)
            {
                btnSalvar.Enabled = false;
                lblErroProduto.ForeColor = Color.Red;
                lblErroProduto.Text = ex.Message;
            }
        }

        private void DescricaoProduto(object sender, EventArgs e)
        {
            try
            {
                lblErroProduto.Text = string.Empty;
                if (_produto == null)
                {
                    _produto = new Produto();
                }
                _produto.Descricao = txtPDescricao.Text;
                _produto.Validar();
                btnSalvar.Enabled = true;
            }
            catch (Exception ex)
            {
                btnSalvar.Enabled = false;
                lblErroProduto.ForeColor = Color.Red;
                lblErroProduto.Text = ex.Message;
            }
        }

        #endregion

        private void tabPageProduto_Click(object sender, EventArgs e)
        {
            if (_gerenciadorProduto == null)
                _gerenciadorProduto = new GerenciadorProduto(_produtoService);
            //statusButton(true);
            CarregarCadastroProduto(_gerenciadorProduto);
        }

    }
}
