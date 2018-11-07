namespace SistemaGrafica.Infra.ORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbGrafica_V1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TBClienteFisico",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        Cpf_Numero = c.String(),
                        Cpf = c.String(nullable: false, maxLength: 11, fixedLength: true, unicode: false),
                        Endereco_Numero = c.Int(nullable: false),
                        Endereco_Rua = c.String(),
                        Endereco_Bairro = c.String(),
                        Endereco_Cidade = c.String(),
                        Endereco_Estado = c.String(),
                        Endereco_Cep = c.String(),
                        Endereco_Complemento = c.String(),
                        Endereco_Id = c.Int(nullable: false),
                        TelefonePrincipal = c.Int(nullable: false),
                        TelefoneSecundario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TBClienteJuridico",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        RazaoSocial = c.String(nullable: false, maxLength: 100, unicode: false),
                        cnpj_Numero = c.String(),
                        Cnpj = c.String(maxLength: 11, fixedLength: true, unicode: false),
                        InscricaoEstadual = c.Int(nullable: false),
                        InscricaoMunicipal = c.Int(nullable: false),
                        Endereco_Numero = c.Int(nullable: false),
                        Endereco_Rua = c.String(),
                        Endereco_Bairro = c.String(),
                        Endereco_Cidade = c.String(),
                        Endereco_Estado = c.String(),
                        Endereco_Cep = c.String(),
                        Endereco_Complemento = c.String(),
                        Endereco_Id = c.Int(nullable: false),
                        TelefonePrincipal = c.Int(nullable: false),
                        TelefoneSecundario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TBFornecedor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        RazaoSocial = c.String(nullable: false, maxLength: 100, unicode: false),
                        Cnpj_Numero = c.String(),
                        Cnpj = c.String(nullable: false, maxLength: 11, fixedLength: true, unicode: false),
                        InscricaoEstadual = c.Int(nullable: false),
                        InscricaoMunicipal = c.Int(nullable: false),
                        Endereco_Numero = c.Int(nullable: false),
                        Endereco_Rua = c.String(),
                        Endereco_Bairro = c.String(),
                        Endereco_Cidade = c.String(),
                        Endereco_Estado = c.String(),
                        Endereco_Cep = c.String(),
                        Endereco_Complemento = c.String(),
                        Endereco_Id = c.Int(nullable: false),
                        TelefonePrincipal = c.Int(nullable: false),
                        TelefoneSecundario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orcamento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TBProduto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        Descricao = c.String(nullable: false, maxLength: 200, unicode: false),
                        ValorUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FornecedorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TBFornecedor", t => t.FornecedorId, cascadeDelete: true)
                .Index(t => t.FornecedorId);
            
            CreateTable(
                "dbo.TBServico",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        tipoServico = c.String(nullable: false, maxLength: 50, unicode: false),
                        valorUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TBProduto", "FornecedorId", "dbo.TBFornecedor");
            DropIndex("dbo.TBProduto", new[] { "FornecedorId" });
            DropTable("dbo.TBServico");
            DropTable("dbo.TBProduto");
            DropTable("dbo.Orcamento");
            DropTable("dbo.TBFornecedor");
            DropTable("dbo.TBClienteJuridico");
            DropTable("dbo.TBClienteFisico");
        }
    }
}
