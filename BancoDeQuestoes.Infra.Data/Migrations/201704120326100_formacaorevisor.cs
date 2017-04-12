namespace BancoDeQuestoes.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class formacaorevisor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Area",
                c => new
                    {
                        AreaId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 150),
                        ConhecimentoEspecifico = c.Boolean(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AreaId);
            
            CreateTable(
                "dbo.Banca",
                c => new
                    {
                        BancaId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 150),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.BancaId);
            
            CreateTable(
                "dbo.C__MigrationHistory",
                c => new
                    {
                        MigrationId = c.String(nullable: false, maxLength: 128),
                        ContextKey = c.String(),
                        Model = c.Binary(),
                        ProductVersion = c.String(),
                    })
                .PrimaryKey(t => t.MigrationId);
            
            CreateTable(
                "dbo.Disciplina",
                c => new
                    {
                        DisciplinaId = c.Int(nullable: false, identity: true),
                        AreaId = c.Int(nullable: false),
                        Descricao = c.String(nullable: false, maxLength: 150),
                        Nome = c.String(nullable: false, maxLength: 150),
                        Bibliografia = c.String(nullable: false, maxLength: 150),
                        Ativo = c.Boolean(nullable: false),
                        Nivel = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.DisciplinaId)
                .ForeignKey("dbo.Area", t => t.AreaId)
                .Index(t => t.AreaId);
            
            CreateTable(
                "dbo.FormacaoRevisor",
                c => new
                    {
                        FormacaoRevisorId = c.Int(nullable: false, identity: true),
                        RevisorId = c.Int(nullable: false),
                        Formacao = c.String(nullable: false, maxLength: 150),
                        Instituicao = c.String(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.FormacaoRevisorId)
                .ForeignKey("dbo.Revisor", t => t.RevisorId)
                .Index(t => t.RevisorId);
            
            CreateTable(
                "dbo.Revisor",
                c => new
                    {
                        RevisorId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 250),
                        Cep = c.String(nullable: false, maxLength: 8),
                        Endereco = c.String(nullable: false, maxLength: 100),
                        Complemento = c.String(maxLength: 100),
                        Numero = c.String(nullable: false, maxLength: 5),
                        Bairro = c.String(nullable: false, maxLength: 100),
                        Cidade = c.String(nullable: false, maxLength: 100),
                        Uf = c.String(nullable: false, maxLength: 2),
                        Cpf = c.String(nullable: false, maxLength: 11),
                        Email = c.String(nullable: false, maxLength: 150),
                        EmailSecundario = c.String(nullable: false, maxLength: 150),
                        Telefone = c.String(nullable: false, maxLength: 8),
                        Celular = c.String(nullable: false, maxLength: 9),
                        Senha = c.String(nullable: false, maxLength: 10),
                        AreaId = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.RevisorId);
            
            CreateTable(
                "dbo.Projeto",
                c => new
                    {
                        ProjetoId = c.Int(nullable: false, identity: true),
                        CodigoProjeto = c.Int(nullable: false),
                        NomeProjeto = c.String(nullable: false, maxLength: 150),
                        Ativo = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ProjetoId);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        ProdutoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 250),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Disponivel = c.Boolean(nullable: false),
                        ClienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProdutoId)
                .ForeignKey("dbo.Cliente", t => t.ClienteId)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Sobrenome = c.String(),
                        Email = c.String(),
                        DataCadastro = c.DateTime(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId);


           // CreateIndex("dbo.FormacaoRevisor", "FormacaoRevisorId");
            //AddForeignKey("dbo.FormacaoRevisor", "FormacaoRevisorId", "dbo.FormacaoRevisor", "FormacaoRevisorId");

            //CreateIndex("dbo.FormacaoRevisor", "FormacaoRevisorId");
           // AddForeignKey("dbo.FormacaoRevisor", "RevisorId", "dbo.Revisor", "RevisorId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produto", "ClienteId", "dbo.Cliente");
            DropForeignKey("dbo.FormacaoRevisor", "RevisorId", "dbo.Revisor");
            DropForeignKey("dbo.Disciplina", "AreaId", "dbo.Area");
            DropIndex("dbo.Produto", new[] { "ClienteId" });
            DropIndex("dbo.FormacaoRevisor", new[] { "RevisorId" });
            DropIndex("dbo.Disciplina", new[] { "AreaId" });
            DropTable("dbo.Cliente");
            DropTable("dbo.Produto");
            DropTable("dbo.Projeto");
            DropTable("dbo.Revisor");
            DropTable("dbo.FormacaoRevisor");
            DropTable("dbo.Disciplina");
            DropTable("dbo.C__MigrationHistory");
            DropTable("dbo.Banca");
            DropTable("dbo.Area");
        }
    }
}
