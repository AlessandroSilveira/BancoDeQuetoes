namespace BancoDeQuestoes.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _14042017 : DbMigration
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
                "dbo.RevisorFormacao",
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
            
            CreateTable(
                "dbo.Projeto",
                c => new
                    {
                        ProjetoId = c.Int(nullable: false, identity: true),
                        CodigoProjeto = c.Int(nullable: false),
                        NomeProjeto = c.String(nullable: false, maxLength: 150),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProjetoId);
            
            CreateTable(
                "dbo.Questao",
                c => new
                    {
                        QuestaoId = c.Int(nullable: false, identity: true),
                        TopicoAtribuidoId = c.Int(nullable: false),
                        NumeroQuestao = c.Int(nullable: false),
                        Descricao = c.String(nullable: false, maxLength: 1000),
                        Arquivo = c.String(nullable: false, maxLength: 150),
                        Status = c.String(nullable: false, maxLength: 150),
                        NumeroDeRevisoes = c.Int(nullable: false),
                        Finalizar = c.Int(nullable: false),
                        Nivel = c.String(nullable: false, maxLength: 150),
                        Imagem = c.String(nullable: false, maxLength: 150),
                        ConviteAceito = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.QuestaoId)
                .ForeignKey("dbo.TopicoAtribuido", t => t.TopicoAtribuidoId)
                .Index(t => t.TopicoAtribuidoId);
            
            CreateTable(
                "dbo.TopicoAtribuido",
                c => new
                    {
                        TopicoAtribuidoId = c.Int(nullable: false, identity: true),
                        ProjetoId = c.Int(nullable: false),
                        AreaId = c.Int(nullable: false),
                        MestreId = c.Int(nullable: false),
                        DisciplinaId = c.Int(nullable: false),
                        CodigoProjeto = c.String(nullable: false, maxLength: 150),
                        NumeroQuestao = c.Int(nullable: false),
                        DataEntrega = c.DateTime(nullable: false),
                        Status = c.String(nullable: false, maxLength: 150),
                        Nivel = c.String(nullable: false, maxLength: 150),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QuestoesRealizadas = c.Int(nullable: false),
                        Aceito = c.Boolean(nullable: false),
                        Observacao = c.String(nullable: false, maxLength: 150),
                        DataAtribuicao = c.DateTime(nullable: false),
                        ConviteAceito = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TopicoAtribuidoId)
                .ForeignKey("dbo.Area", t => t.AreaId)
                .ForeignKey("dbo.Disciplina", t => t.DisciplinaId)
                .ForeignKey("dbo.Mestre", t => t.MestreId)
                .ForeignKey("dbo.Projeto", t => t.ProjetoId)
                .Index(t => t.ProjetoId)
                .Index(t => t.AreaId)
                .Index(t => t.MestreId)
                .Index(t => t.DisciplinaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Questao", "TopicoAtribuidoId", "dbo.TopicoAtribuido");
            DropForeignKey("dbo.TopicoAtribuido", "ProjetoId", "dbo.Projeto");
            DropForeignKey("dbo.TopicoAtribuido", "MestreId", "dbo.Mestre");
            DropForeignKey("dbo.TopicoAtribuido", "DisciplinaId", "dbo.Disciplina");
            DropForeignKey("dbo.TopicoAtribuido", "AreaId", "dbo.Area");
            DropForeignKey("dbo.MestreFormacao", "MestreId", "dbo.Mestre");
            DropForeignKey("dbo.MestreDependente", "MestreId", "dbo.Mestre");
            DropForeignKey("dbo.MestreArea", "MestreId", "dbo.Mestre");
            DropForeignKey("dbo.MestreArea", "AreaId", "dbo.Area");
            DropForeignKey("dbo.RevisorFormacao", "RevisorId", "dbo.Revisor");
            DropForeignKey("dbo.Disciplina", "AreaId", "dbo.Area");
            DropIndex("dbo.TopicoAtribuido", new[] { "DisciplinaId" });
            DropIndex("dbo.TopicoAtribuido", new[] { "MestreId" });
            DropIndex("dbo.TopicoAtribuido", new[] { "AreaId" });
            DropIndex("dbo.TopicoAtribuido", new[] { "ProjetoId" });
            DropIndex("dbo.Questao", new[] { "TopicoAtribuidoId" });
            DropIndex("dbo.MestreFormacao", new[] { "MestreId" });
            DropIndex("dbo.MestreDependente", new[] { "MestreId" });
            DropIndex("dbo.MestreArea", new[] { "AreaId" });
            DropIndex("dbo.MestreArea", new[] { "MestreId" });
            DropIndex("dbo.RevisorFormacao", new[] { "RevisorId" });
            DropIndex("dbo.Disciplina", new[] { "AreaId" });
            DropTable("dbo.TopicoAtribuido");
            DropTable("dbo.Questao");
            DropTable("dbo.Projeto");
            DropTable("dbo.MestreFormacao");
            DropTable("dbo.MestreDependente");
            DropTable("dbo.MestreArea");
            DropTable("dbo.Mestre");
            DropTable("dbo.Revisor");
            DropTable("dbo.RevisorFormacao");
            DropTable("dbo.Disciplina");
            DropTable("dbo.C__MigrationHistory");
            DropTable("dbo.Banca");
            DropTable("dbo.Area");
        }
    }
}
