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

        public TelaInicial(ServicoService service)
        {
            _service = service;
            InitializeComponent();
            btnSalvar.Enabled = false;
        }

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
