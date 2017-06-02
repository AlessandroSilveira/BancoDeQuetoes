namespace BancoDeQuestoes.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _020620174 : DbMigration
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
                "dbo.Disciplina",
                c => new
                    {
                        DisciplinaId = c.Guid(nullable: false, identity: true),
                        AreaId = c.Guid(nullable: false),
                        Descricao = c.String(nullable: false, maxLength: 150, unicode: false),
                        Nome = c.String(nullable: false, maxLength: 150, unicode: false),
                        Bibliografia = c.String(nullable: false, maxLength: 150, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                        Nivel = c.String(nullable: false, maxLength: 150, unicode: false),
                    })
                .PrimaryKey(t => t.DisciplinaId)
                .ForeignKey("dbo.Area", t => t.AreaId)
                .Index(t => t.AreaId);
            
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
                        ProjetoId = c.Guid(nullable: false),
                        AreaId = c.Guid(nullable: false),
                        MestreId = c.Guid(nullable: false),
                        DisciplinaId = c.Guid(nullable: false),
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
                        BancaId = c.Guid(nullable: false),
                        Filhos = c.String(maxLength: 2, unicode: false),
                        Pis = c.String(nullable: false, maxLength: 20, unicode: false),
                        Minicurriculo = c.String(maxLength: 8000, unicode: false),
                        Banco = c.String(nullable: false, maxLength: 150, unicode: false),
                        Agencia = c.String(nullable: false, maxLength: 150, unicode: false),
                        TipoConta = c.String(nullable: false, maxLength: 150, unicode: false),
                        Conta = c.String(nullable: false, maxLength: 150, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MestreId)
                .ForeignKey("dbo.Banca", t => t.BancaId)
                .Index(t => t.Cpf, unique: true)
                .Index(t => t.BancaId);
            
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
                        NumeroStatus = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.StatusId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        UsuarioId = c.Guid(nullable: false, identity: true),
                        Email = c.String(nullable: false, maxLength: 256, unicode: false),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(maxLength: 8000, unicode: false),
                        SecurityStamp = c.String(maxLength: 8000, unicode: false),
                        PhoneNumber = c.String(maxLength: 8000, unicode: false),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256, unicode: false),
                        Id = c.String(maxLength: 8000, unicode: false),
                    })
                .PrimaryKey(t => t.UsuarioId);
            
            CreateTable(
                "dbo.IdentityUserClaim",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(maxLength: 8000, unicode: false),
                        ClaimType = c.String(maxLength: 8000, unicode: false),
                        ClaimValue = c.String(maxLength: 8000, unicode: false),
                        Usuario_UsuarioId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Usuario_UsuarioId)
                .Index(t => t.Usuario_UsuarioId);
            
            CreateTable(
                "dbo.IdentityUserLogin",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128, unicode: false),
                        LoginProvider = c.String(maxLength: 8000, unicode: false),
                        ProviderKey = c.String(maxLength: 8000, unicode: false),
                        Usuario_UsuarioId = c.Guid(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.AspNetUsers", t => t.Usuario_UsuarioId)
                .Index(t => t.Usuario_UsuarioId);
            
            CreateTable(
                "dbo.IdentityUserRole",
                c => new
                    {
                        RoleId = c.String(nullable: false, maxLength: 128, unicode: false),
                        UserId = c.String(nullable: false, maxLength: 128, unicode: false),
                        Usuario_UsuarioId = c.Guid(),
                        IdentityRole_Id = c.String(maxLength: 128, unicode: false),
                    })
                .PrimaryKey(t => new { t.RoleId, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.Usuario_UsuarioId)
                .ForeignKey("dbo.IdentityRole", t => t.IdentityRole_Id)
                .Index(t => t.Usuario_UsuarioId)
                .Index(t => t.IdentityRole_Id);
            
            CreateTable(
                "dbo.IdentityRole",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, unicode: false),
                        Name = c.String(maxLength: 8000, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IdentityUserRole", "IdentityRole_Id", "dbo.IdentityRole");
            DropForeignKey("dbo.IdentityUserRole", "Usuario_UsuarioId", "dbo.AspNetUsers");
            DropForeignKey("dbo.IdentityUserLogin", "Usuario_UsuarioId", "dbo.AspNetUsers");
            DropForeignKey("dbo.IdentityUserClaim", "Usuario_UsuarioId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Questao", "TopicoAtribuidoId", "dbo.TopicoAtribuido");
            DropForeignKey("dbo.FormacaoRevisor", "RevisorId", "dbo.Revisor");
            DropForeignKey("dbo.Revisor", "Area_AreaId", "dbo.Area");
            DropForeignKey("dbo.TopicoAtribuido", "ProjetoId", "dbo.Projeto");
            DropForeignKey("dbo.TopicoAtribuido", "MestreId", "dbo.Mestre");
            DropForeignKey("dbo.MestreFormacao", "Mestre_MestreId", "dbo.Mestre");
            DropForeignKey("dbo.MestreFormacao", "MestreId", "dbo.Mestre");
            DropForeignKey("dbo.MestreDependente", "Mestre_MestreId", "dbo.Mestre");
            DropForeignKey("dbo.MestreDependente", "MestreId", "dbo.Mestre");
            DropForeignKey("dbo.MestreArea", "MestreId", "dbo.Mestre");
            DropForeignKey("dbo.MestreArea", "AreaId", "dbo.Area");
            DropForeignKey("dbo.Mestre", "BancaId", "dbo.Banca");
            DropForeignKey("dbo.TopicoAtribuido", "DisciplinaId", "dbo.Disciplina");
            DropForeignKey("dbo.TopicoAtribuido", "AreaId", "dbo.Area");
            DropForeignKey("dbo.Disciplina", "AreaId", "dbo.Area");
            DropIndex("dbo.IdentityUserRole", new[] { "IdentityRole_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "Usuario_UsuarioId" });
            DropIndex("dbo.IdentityUserLogin", new[] { "Usuario_UsuarioId" });
            DropIndex("dbo.IdentityUserClaim", new[] { "Usuario_UsuarioId" });
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
            DropIndex("dbo.Mestre", new[] { "BancaId" });
            DropIndex("dbo.Mestre", new[] { "Cpf" });
            DropIndex("dbo.TopicoAtribuido", new[] { "DisciplinaId" });
            DropIndex("dbo.TopicoAtribuido", new[] { "MestreId" });
            DropIndex("dbo.TopicoAtribuido", new[] { "AreaId" });
            DropIndex("dbo.TopicoAtribuido", new[] { "ProjetoId" });
            DropIndex("dbo.Disciplina", new[] { "AreaId" });
            DropTable("dbo.IdentityRole");
            DropTable("dbo.IdentityUserRole");
            DropTable("dbo.IdentityUserLogin");
            DropTable("dbo.IdentityUserClaim");
            DropTable("dbo.AspNetUsers");
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
            DropTable("dbo.TopicoAtribuido");
            DropTable("dbo.Disciplina");
            DropTable("dbo.Area");
        }
    }
}
