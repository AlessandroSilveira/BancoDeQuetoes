namespace BancoDeQuestoes.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuestaoETopicoAtribuido : DbMigration
    {
        public override void Up()
        {
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
            DropIndex("dbo.TopicoAtribuido", new[] { "DisciplinaId" });
            DropIndex("dbo.TopicoAtribuido", new[] { "MestreId" });
            DropIndex("dbo.TopicoAtribuido", new[] { "AreaId" });
            DropIndex("dbo.TopicoAtribuido", new[] { "ProjetoId" });
            DropIndex("dbo.Questao", new[] { "TopicoAtribuidoId" });
            DropTable("dbo.TopicoAtribuido");
            DropTable("dbo.Questao");
        }
    }
}
