namespace BancoDeQuestoes.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _280420171 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Area",
                c => new
                    {
                        AreaId = c.Guid(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 150, unicode: false),
                        ConhecimentoEspecifico = c.Boolean(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AreaId);
            
            CreateTable(
                "dbo.TopicoAtribuido",
                c => new
                    {
                        TopicoAtribuidoId = c.Guid(nullable: false, identity: true),
                        CodigoProjeto = c.String(nullable: false, maxLength: 150, unicode: false),
                        NumeroQuestao = c.Int(nullable: false),
                        DataEntrega = c.DateTime(nullable: false),
                        Status = c.String(nullable: false, maxLength: 150, unicode: false),
                        Nivel = c.String(nullable: false, maxLength: 150, unicode: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QuestoesRealizadas = c.Int(nullable: false),
                        Aceito = c.Boolean(nullable: false),
                        Observacao = c.String(nullable: false, maxLength: 150, unicode: false),
                        DataAtribuicao = c.DateTime(nullable: false),
                        ConviteAceito = c.Boolean(nullable: false),
                        Area_AreaId = c.Guid(),
                        Disciplina_DisciplinaId = c.Guid(),
                        Mestre_MestreId = c.Guid(),
                        Projeto_ProjetoId = c.Guid(),
                    })
                .PrimaryKey(t => t.TopicoAtribuidoId)
                .ForeignKey("dbo.Area", t => t.Area_AreaId)
                .ForeignKey("dbo.Disciplina", t => t.Disciplina_DisciplinaId)
                .ForeignKey("dbo.Mestre", t => t.Mestre_MestreId)
                .ForeignKey("dbo.Projeto", t => t.Projeto_ProjetoId)
                .Index(t => t.Area_AreaId)
                .Index(t => t.Disciplina_DisciplinaId)
                .Index(t => t.Mestre_MestreId)
                .Index(t => t.Projeto_ProjetoId);
            
            CreateTable(
                "dbo.Disciplina",
                c => new
                    {
                        DisciplinaId = c.Guid(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 150, unicode: false),
                        Nome = c.String(nullable: false, maxLength: 150, unicode: false),
                        Bibliografia = c.String(nullable: false, maxLength: 150, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                        Nivel = c.String(nullable: false, maxLength: 150, unicode: false),
                        Area_AreaId = c.Guid(),
                    })
                .PrimaryKey(t => t.DisciplinaId)
                .ForeignKey("dbo.Area", t => t.Area_AreaId)
                .Index(t => t.Area_AreaId);
            
            CreateTable(
                "dbo.Mestre",
                c => new
                    {
                        MestreId = c.Guid(nullable: false, identity: true),
                        Cpf = c.String(nullable: false, maxLength: 11, unicode: false),
                        Nome = c.String(nullable: false, maxLength: 150, unicode: false),
                        Cep = c.String(maxLength: 8000, unicode: false),
                        Endereco = c.String(nullable: false, maxLength: 150, unicode: false),
                        Complemento = c.String(maxLength: 150, unicode: false),
                        Numero = c.String(nullable: false, maxLength: 6, unicode: false),
                        Bairro = c.String(nullable: false, maxLength: 150, unicode: false),
                        Cidade = c.String(maxLength: 8000, unicode: false),
                        Estado = c.String(nullable: false, maxLength: 2, unicode: false),
                        Email = c.String(nullable: false, maxLength: 150, unicode: false),
                        EmailSecundario = c.String(nullable: false, maxLength: 150, unicode: false),
                        Telefone = c.String(nullable: false, maxLength: 15, unicode: false),
                        Celular = c.String(nullable: false, maxLength: 15, unicode: false),
                        Filhos = c.String(maxLength: 2, unicode: false),
                        Pis = c.String(nullable: false, maxLength: 20, unicode: false),
                        Minicurriculo = c.String(maxLength: 8000, unicode: false),
                        Banco = c.String(nullable: false, maxLength: 150, unicode: false),
                        Agencia = c.String(nullable: false, maxLength: 150, unicode: false),
                        TipoConta = c.String(nullable: false, maxLength: 150, unicode: false),
                        Conta = c.String(nullable: false, maxLength: 150, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                        Banca_BancaId = c.Guid(),
                    })
                .PrimaryKey(t => t.MestreId)
                .ForeignKey("dbo.Banca", t => t.Banca_BancaId)
                .Index(t => t.Cpf, unique: true)
                .Index(t => t.Banca_BancaId);
            
            CreateTable(
                "dbo.Banca",
                c => new
                    {
                        BancaId = c.Guid(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 150, unicode: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.BancaId);
            
            CreateTable(
                "dbo.MestreArea",
                c => new
                    {
                        MestreAreaId = c.Guid(nullable: false, identity: true),
                        MestreId = c.Guid(nullable: false),
                        AreaId = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 150, unicode: false),
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
                        MestreDependenteId = c.Guid(nullable: false, identity: true),
                        MestreId = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 150, unicode: false),
                        Documento = c.String(nullable: false, maxLength: 50, unicode: false),
                        DataNascimento = c.DateTime(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        Mestre_MestreId = c.Guid(),
                    })
                .PrimaryKey(t => t.MestreDependenteId)
                .ForeignKey("dbo.Mestre", t => t.MestreId)
                .ForeignKey("dbo.Mestre", t => t.Mestre_MestreId)
                .Index(t => t.MestreId)
                .Index(t => t.Mestre_MestreId);
            
            CreateTable(
                "dbo.MestreFormacao",
                c => new
                    {
                        MestreFormacaoId = c.Guid(nullable: false, identity: true),
                        MestreId = c.Guid(nullable: false),
                        TipoFormacao = c.String(nullable: false, maxLength: 150, unicode: false),
                        Curso = c.String(nullable: false, maxLength: 150, unicode: false),
                        Instituicao = c.String(nullable: false, maxLength: 150, unicode: false),
                        CopiaDiploma = c.Boolean(nullable: false),
                        DiplomaAutenticado = c.Boolean(nullable: false),
                        NumeroCopiaAutenticada = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        Mestre_MestreId = c.Guid(),
                    })
                .PrimaryKey(t => t.MestreFormacaoId)
                .ForeignKey("dbo.Mestre", t => t.MestreId)
                .ForeignKey("dbo.Mestre", t => t.Mestre_MestreId)
                .Index(t => t.MestreId)
                .Index(t => t.Mestre_MestreId);
            
            CreateTable(
                "dbo.Projeto",
                c => new
                    {
                        ProjetoId = c.Guid(nullable: false, identity: true),
                        CodigoProjeto = c.Int(nullable: false),
                        NomeProjeto = c.String(nullable: false, maxLength: 150, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProjetoId);
            
            CreateTable(
                "dbo.C__MigrationHistory",
                c => new
                    {
                        MigrationId = c.String(nullable: false, maxLength: 128, unicode: false),
                        ContextKey = c.String(maxLength: 8000, unicode: false),
                        Model = c.Binary(),
                        ProductVersion = c.String(maxLength: 8000, unicode: false),
                    })
                .PrimaryKey(t => t.MigrationId);
            
            CreateTable(
                "dbo.FormacaoRevisor",
                c => new
                    {
                        RevisorFormacaoId = c.Guid(nullable: false, identity: true),
                        RevisorId = c.Guid(nullable: false),
                        Formacao = c.String(nullable: false, maxLength: 150, unicode: false),
                        Instituicao = c.String(nullable: false, maxLength: 150, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.RevisorFormacaoId)
                .ForeignKey("dbo.Revisor", t => t.RevisorId)
                .Index(t => t.RevisorId);
            
            CreateTable(
                "dbo.Revisor",
                c => new
                    {
                        RevisorId = c.Guid(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 250, unicode: false),
                        Cep = c.String(nullable: false, maxLength: 8, unicode: false),
                        Endereco = c.String(nullable: false, maxLength: 100, unicode: false),
                        Complemento = c.String(maxLength: 100, unicode: false),
                        Numero = c.String(nullable: false, maxLength: 5, unicode: false),
                        Bairro = c.String(nullable: false, maxLength: 100, unicode: false),
                        Cidade = c.String(nullable: false, maxLength: 100, unicode: false),
                        Uf = c.String(nullable: false, maxLength: 2, unicode: false),
                        Cpf = c.String(nullable: false, maxLength: 11, unicode: false),
                        Email = c.String(nullable: false, maxLength: 150, unicode: false),
                        EmailSecundario = c.String(nullable: false, maxLength: 150, unicode: false),
                        Telefone = c.String(nullable: false, maxLength: 8, unicode: false),
                        Celular = c.String(nullable: false, maxLength: 9, unicode: false),
                        Senha = c.String(nullable: false, maxLength: 10, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                        Area_AreaId = c.Guid(),
                    })
                .PrimaryKey(t => t.RevisorId)
                .ForeignKey("dbo.Area", t => t.Area_AreaId)
                .Index(t => t.Cpf, unique: true)
                .Index(t => t.Area_AreaId);
            
            CreateTable(
                "dbo.Questao",
                c => new
                    {
                        QuestaoId = c.Guid(nullable: false, identity: true),
                        TopicoAtribuidoId = c.Guid(nullable: false),
                        NumeroQuestao = c.Int(nullable: false),
                        Descricao = c.String(nullable: false, maxLength: 1000, unicode: false),
                        Arquivo = c.String(nullable: false, maxLength: 150, unicode: false),
                        Status = c.String(nullable: false, maxLength: 150, unicode: false),
                        NumeroDeRevisoes = c.Int(nullable: false),
                        Finalizar = c.Int(nullable: false),
                        Nivel = c.String(nullable: false, maxLength: 150, unicode: false),
                        Imagem = c.String(nullable: false, maxLength: 150, unicode: false),
                        ConviteAceito = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.QuestaoId)
                .ForeignKey("dbo.TopicoAtribuido", t => t.TopicoAtribuidoId)
                .Index(t => t.TopicoAtribuidoId);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        StatusId = c.Guid(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 150, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.StatusId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Questao", "TopicoAtribuidoId", "dbo.TopicoAtribuido");
            DropForeignKey("dbo.FormacaoRevisor", "RevisorId", "dbo.Revisor");
            DropForeignKey("dbo.Revisor", "Area_AreaId", "dbo.Area");
            DropForeignKey("dbo.TopicoAtribuido", "Projeto_ProjetoId", "dbo.Projeto");
            DropForeignKey("dbo.TopicoAtribuido", "Mestre_MestreId", "dbo.Mestre");
            DropForeignKey("dbo.MestreFormacao", "Mestre_MestreId", "dbo.Mestre");
            DropForeignKey("dbo.MestreFormacao", "MestreId", "dbo.Mestre");
            DropForeignKey("dbo.MestreDependente", "Mestre_MestreId", "dbo.Mestre");
            DropForeignKey("dbo.MestreDependente", "MestreId", "dbo.Mestre");
            DropForeignKey("dbo.MestreArea", "MestreId", "dbo.Mestre");
            DropForeignKey("dbo.MestreArea", "AreaId", "dbo.Area");
            DropForeignKey("dbo.Mestre", "Banca_BancaId", "dbo.Banca");
            DropForeignKey("dbo.TopicoAtribuido", "Disciplina_DisciplinaId", "dbo.Disciplina");
            DropForeignKey("dbo.Disciplina", "Area_AreaId", "dbo.Area");
            DropForeignKey("dbo.TopicoAtribuido", "Area_AreaId", "dbo.Area");
            DropIndex("dbo.Questao", new[] { "TopicoAtribuidoId" });
            DropIndex("dbo.Revisor", new[] { "Area_AreaId" });
            DropIndex("dbo.Revisor", new[] { "Cpf" });
            DropIndex("dbo.FormacaoRevisor", new[] { "RevisorId" });
            DropIndex("dbo.MestreFormacao", new[] { "Mestre_MestreId" });
            DropIndex("dbo.MestreFormacao", new[] { "MestreId" });
            DropIndex("dbo.MestreDependente", new[] { "Mestre_MestreId" });
            DropIndex("dbo.MestreDependente", new[] { "MestreId" });
            DropIndex("dbo.MestreArea", new[] { "AreaId" });
            DropIndex("dbo.MestreArea", new[] { "MestreId" });
            DropIndex("dbo.Mestre", new[] { "Banca_BancaId" });
            DropIndex("dbo.Mestre", new[] { "Cpf" });
            DropIndex("dbo.Disciplina", new[] { "Area_AreaId" });
            DropIndex("dbo.TopicoAtribuido", new[] { "Projeto_ProjetoId" });
            DropIndex("dbo.TopicoAtribuido", new[] { "Mestre_MestreId" });
            DropIndex("dbo.TopicoAtribuido", new[] { "Disciplina_DisciplinaId" });
            DropIndex("dbo.TopicoAtribuido", new[] { "Area_AreaId" });
            DropTable("dbo.Status");
            DropTable("dbo.Questao");
            DropTable("dbo.Revisor");
            DropTable("dbo.FormacaoRevisor");
            DropTable("dbo.C__MigrationHistory");
            DropTable("dbo.Projeto");
            DropTable("dbo.MestreFormacao");
            DropTable("dbo.MestreDependente");
            DropTable("dbo.MestreArea");
            DropTable("dbo.Banca");
            DropTable("dbo.Mestre");
            DropTable("dbo.Disciplina");
            DropTable("dbo.TopicoAtribuido");
            DropTable("dbo.Area");
        }
    }
}
