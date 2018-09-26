﻿namespace SistemaGrafica.Presentation.feature.Inicio
{
    partial class TelaInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControInicio = new System.Windows.Forms.TabControl();
            this.tabPageCliente = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnRazaoSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.cmxUf = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textComplemento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textCEP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textCidade = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEstadual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMunicipal = new System.Windows.Forms.TextBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.tabPageFornecedore = new System.Windows.Forms.TabPage();
            this.tabPageServico = new System.Windows.Forms.TabPage();
            this.tabPageOrcamento = new System.Windows.Forms.TabPage();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.toolStripPreferencia = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSair = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControInicio.SuspendLayout();
            this.tabPageCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControInicio
            // 
            this.tabControInicio.Controls.Add(this.tabPageCliente);
            this.tabControInicio.Controls.Add(this.tabPageFornecedore);
            this.tabControInicio.Controls.Add(this.tabPageServico);
            this.tabControInicio.Controls.Add(this.tabPageOrcamento);
            this.tabControInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControInicio.Location = new System.Drawing.Point(0, 28);
            this.tabControInicio.Name = "tabControInicio";
            this.tabControInicio.SelectedIndex = 0;
            this.tabControInicio.Size = new System.Drawing.Size(1350, 701);
            this.tabControInicio.TabIndex = 0;
            // 
            // tabPageCliente
            // 
            this.tabPageCliente.Controls.Add(this.dataGridView1);
            this.tabPageCliente.Controls.Add(this.groupBox1);
            this.tabPageCliente.Controls.Add(this.label3);
            this.tabPageCliente.Controls.Add(this.cbxTipo);
            this.tabPageCliente.Controls.Add(this.label2);
            this.tabPageCliente.Controls.Add(this.txtEstadual);
            this.tabPageCliente.Controls.Add(this.label1);
            this.tabPageCliente.Controls.Add(this.txtMunicipal);
            this.tabPageCliente.Controls.Add(this.lblCnpj);
            this.tabPageCliente.Controls.Add(this.txtCpf);
            this.tabPageCliente.Controls.Add(this.lblRazaoSocial);
            this.tabPageCliente.Controls.Add(this.txtRazaoSocial);
            this.tabPageCliente.Controls.Add(this.lblNome);
            this.tabPageCliente.Controls.Add(this.txtNome);
            this.tabPageCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageCliente.Location = new System.Drawing.Point(4, 29);
            this.tabPageCliente.Name = "tabPageCliente";
            this.tabPageCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCliente.Size = new System.Drawing.Size(1342, 668);
            this.tabPageCliente.TabIndex = 0;
            this.tabPageCliente.Text = "Clientes";
            this.tabPageCliente.UseVisualStyleBackColor = true;
            this.tabPageCliente.Click += new System.EventHandler(this.tabPageCliente_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNome,
            this.columnCpf,
            this.columnTelefone,
            this.columnRazaoSocial});
            this.dataGridView1.Location = new System.Drawing.Point(8, 299);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1311, 294);
            this.dataGridView1.TabIndex = 15;
            // 
            // columnNome
            // 
            this.columnNome.HeaderText = "Nome";
            this.columnNome.Name = "columnNome";
            this.columnNome.ReadOnly = true;
            // 
            // columnCpf
            // 
            this.columnCpf.HeaderText = "CPF/CNPJ";
            this.columnCpf.Name = "columnCpf";
            this.columnCpf.ReadOnly = true;
            // 
            // columnTelefone
            // 
            this.columnTelefone.HeaderText = "Telefone";
            this.columnTelefone.Name = "columnTelefone";
            this.columnTelefone.ReadOnly = true;
            // 
            // columnRazaoSocial
            // 
            this.columnRazaoSocial.HeaderText = "Razao Social";
            this.columnRazaoSocial.Name = "columnRazaoSocial";
            this.columnRazaoSocial.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.cmxUf);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textComplemento);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textCEP);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textCidade);
            this.groupBox1.Controls.Add(this.lblBairro);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtRua);
            this.groupBox1.Location = new System.Drawing.Point(12, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1288, 133);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(351, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Numero";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(351, 96);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(288, 26);
            this.txtNumero.TabIndex = 23;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            // 
            // cmxUf
            // 
            this.cmxUf.FormattingEnabled = true;
            this.cmxUf.Location = new System.Drawing.Point(924, 43);
            this.cmxUf.Name = "cmxUf";
            this.cmxUf.Size = new System.Drawing.Size(300, 28);
            this.cmxUf.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(924, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "UF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(644, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Complemento";
            // 
            // textComplemento
            // 
            this.textComplemento.Location = new System.Drawing.Point(644, 96);
            this.textComplemento.Name = "textComplemento";
            this.textComplemento.Size = new System.Drawing.Size(638, 26);
            this.textComplemento.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "CEP";
            // 
            // textCEP
            // 
            this.textCEP.Location = new System.Drawing.Point(6, 44);
            this.textCEP.Name = "textCEP";
            this.textCEP.Size = new System.Drawing.Size(300, 26);
            this.textCEP.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cidade";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textCidade
            // 
            this.textCidade.Location = new System.Drawing.Point(312, 45);
            this.textCidade.Name = "textCidade";
            this.textCidade.Size = new System.Drawing.Size(300, 26);
            this.textCidade.TabIndex = 14;
            this.textCidade.TextChanged += new System.EventHandler(this.textCidade_TextChanged);
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(614, 22);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(51, 20);
            this.lblBairro.TabIndex = 13;
            this.lblBairro.Text = "Bairro";
            this.lblBairro.Click += new System.EventHandler(this.lblBairro_Click);
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(618, 45);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(300, 26);
            this.txtBairro.TabIndex = 12;
            this.txtBairro.TextChanged += new System.EventHandler(this.txtBairro_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Rua";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(6, 96);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(339, 26);
            this.txtRua.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tipo de Pessoa";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(443, 32);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(420, 28);
            this.cbxTipo.TabIndex = 10;
            this.cbxTipo.SelectedIndexChanged += new System.EventHandler(this.cbxTipo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(876, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Incrição Estadual";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtEstadual
            // 
            this.txtEstadual.Location = new System.Drawing.Point(880, 84);
            this.txtEstadual.Name = "txtEstadual";
            this.txtEstadual.Size = new System.Drawing.Size(420, 26);
            this.txtEstadual.TabIndex = 8;
            this.txtEstadual.TextChanged += new System.EventHandler(this.txtEstadual_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Incrição Municipal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMunicipal
            // 
            this.txtMunicipal.Location = new System.Drawing.Point(443, 87);
            this.txtMunicipal.Name = "txtMunicipal";
            this.txtMunicipal.Size = new System.Drawing.Size(420, 26);
            this.txtMunicipal.TabIndex = 6;
            this.txtMunicipal.TextChanged += new System.EventHandler(this.txtMunicipal_TextChanged);
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Location = new System.Drawing.Point(880, 9);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(84, 20);
            this.lblCnpj.TabIndex = 5;
            this.lblCnpj.Text = "CNPJ/CPF";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(880, 32);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(420, 26);
            this.txtCpf.TabIndex = 4;
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Location = new System.Drawing.Point(8, 64);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(103, 20);
            this.lblRazaoSocial.TabIndex = 3;
            this.lblRazaoSocial.Text = "Razão Social";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(8, 87);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(420, 26);
            this.txtRazaoSocial.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(8, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(8, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(420, 26);
            this.txtNome.TabIndex = 0;
            // 
            // tabPageFornecedore
            // 
            this.tabPageFornecedore.Location = new System.Drawing.Point(4, 29);
            this.tabPageFornecedore.Name = "tabPageFornecedore";
            this.tabPageFornecedore.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFornecedore.Size = new System.Drawing.Size(1342, 668);
            this.tabPageFornecedore.TabIndex = 1;
            this.tabPageFornecedore.Text = "Fornecedores";
            this.tabPageFornecedore.UseVisualStyleBackColor = true;
            // 
            // tabPageServico
            // 
            this.tabPageServico.Location = new System.Drawing.Point(4, 29);
            this.tabPageServico.Name = "tabPageServico";
            this.tabPageServico.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageServico.Size = new System.Drawing.Size(1342, 668);
            this.tabPageServico.TabIndex = 2;
            this.tabPageServico.Text = "Serviços";
            this.tabPageServico.UseVisualStyleBackColor = true;
            // 
            // tabPageOrcamento
            // 
            this.tabPageOrcamento.Location = new System.Drawing.Point(4, 29);
            this.tabPageOrcamento.Name = "tabPageOrcamento";
            this.tabPageOrcamento.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrcamento.Size = new System.Drawing.Size(1342, 668);
            this.tabPageOrcamento.TabIndex = 3;
            this.tabPageOrcamento.Text = "Orçamentos";
            this.tabPageOrcamento.UseVisualStyleBackColor = true;
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPreferencia,
            this.toolStripSobre,
            this.toolStripSair});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1350, 28);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // toolStripPreferencia
            // 
            this.toolStripPreferencia.Name = "toolStripPreferencia";
            this.toolStripPreferencia.Size = new System.Drawing.Size(101, 24);
            this.toolStripPreferencia.Text = "Preferencias";
            // 
            // toolStripSobre
            // 
            this.toolStripSobre.Name = "toolStripSobre";
            this.toolStripSobre.Size = new System.Drawing.Size(60, 24);
            this.toolStripSobre.Text = "Sobre";
            // 
            // toolStripSair
            // 
            this.toolStripSair.Name = "toolStripSair";
            this.toolStripSair.Size = new System.Drawing.Size(46, 24);
            this.toolStripSair.Text = "Sair";
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.tabControInicio);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Principal";
            this.tabControInicio.ResumeLayout(false);
            this.tabPageCliente.ResumeLayout(false);
            this.tabPageCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControInicio;
        private System.Windows.Forms.TabPage tabPageCliente;
        private System.Windows.Forms.TabPage tabPageFornecedore;
        private System.Windows.Forms.TabPage tabPageServico;
        private System.Windows.Forms.TabPage tabPageOrcamento;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem toolStripPreferencia;
        private System.Windows.Forms.ToolStripMenuItem toolStripSobre;
        private System.Windows.Forms.ToolStripMenuItem toolStripSair;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMunicipal;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEstadual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ComboBox cmxUf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textComplemento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textCEP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnRazaoSocial;
    }
}