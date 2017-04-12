namespace BancoDeQuestoes.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmestresesuasdependencias : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.FormacaoRevisor", newName: "RevisorFormacao");
            CreateTable(
                "dbo.Mestre",
                c => new
                    {
                        MestreId = c.Int(nullable: false, identity: true),
                        Cpf = c.String(nullable: false, maxLength: 11),
                        Nome = c.String(nullable: false, maxLength: 150),
                        Cep = c.String(),
                        Endereco = c.String(nullable: false, maxLength: 150),
                        Complemento = c.String(maxLength: 150),
                        Numero = c.String(nullable: false, maxLength: 6),
                        Bairro = c.String(nullable: false, maxLength: 150),
                        Cidade = c.String(),
                        Estado = c.String(nullable: false, maxLength: 150),
                        Email = c.String(nullable: false, maxLength: 150),
                        EmailSecundario = c.String(nullable: false, maxLength: 150),
                        Telefone = c.String(nullable: false, maxLength: 15),
                        Celular = c.String(nullable: false, maxLength: 15),
                        Banca = c.String(nullable: false),
                        Filhos = c.String(maxLength: 2),
                        Pis = c.String(nullable: false, maxLength: 20),
                        Minicurriculo = c.String(),
                        Banco = c.String(nullable: false, maxLength: 150),
                        Agencia = c.String(nullable: false, maxLength: 150),
                        TipoConta = c.String(nullable: false, maxLength: 150),
                        Conta = c.String(nullable: false, maxLength: 150),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MestreId);
            
            CreateTable(
                "dbo.MestreArea",
                c => new
                    {
                        MestreAreaId = c.Int(nullable: false, identity: true),
                        MestreId = c.Int(nullable: false),
                        AreaId = c.Int(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 150),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MestreAreaId)
                .ForeignKey("dbo.Area", t => t.AreaId)
                .ForeignKey("dbo.Mestre", t => t.MestreId)
                .Index(t => t.MestreId)
                .Index(t => t.AreaId);
            
            CreateTable(
                "dbo.MestreDependente",
                c => new
                    {
                        MestreDependenteId = c.Int(nullable: false, identity: true),
                        MestreId = c.Int(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 150),
                        Documento = c.String(nullable: false, maxLength: 50),
                        DataNascimento = c.DateTime(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MestreDependenteId)
                .ForeignKey("dbo.Mestre", t => t.MestreId)
                .Index(t => t.MestreId);
            
            CreateTable(
                "dbo.MestreFormacao",
                c => new
                    {
                        MestreFormacaoId = c.Int(nullable: false, identity: true),
                        MestreId = c.Int(nullable: false),
                        TipoFormacao = c.String(nullable: false, maxLength: 150),
                        Curso = c.String(nullable: false, maxLength: 150),
                        Instituicao = c.String(nullable: false, maxLength: 150),
                        CopiaDiploma = c.Boolean(nullable: false),
                        DiplomaAutenticado = c.Boolean(nullable: false),
                        NumeroCopiaAutenticada = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MestreFormacaoId)
                .ForeignKey("dbo.Mestre", t => t.MestreId)
                .Index(t => t.MestreId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MestreFormacao", "MestreId", "dbo.Mestre");
            DropForeignKey("dbo.MestreDependente", "MestreId", "dbo.Mestre");
            DropForeignKey("dbo.MestreArea", "MestreId", "dbo.Mestre");
            DropForeignKey("dbo.MestreArea", "AreaId", "dbo.Area");
            DropIndex("dbo.MestreFormacao", new[] { "MestreId" });
            DropIndex("dbo.MestreDependente", new[] { "MestreId" });
            DropIndex("dbo.MestreArea", new[] { "AreaId" });
            DropIndex("dbo.MestreArea", new[] { "MestreId" });
            DropTable("dbo.MestreFormacao");
            DropTable("dbo.MestreDependente");
            DropTable("dbo.MestreArea");
            DropTable("dbo.Mestre");
            RenameTable(name: "dbo.RevisorFormacao", newName: "FormacaoRevisor");
        }
    }
}
