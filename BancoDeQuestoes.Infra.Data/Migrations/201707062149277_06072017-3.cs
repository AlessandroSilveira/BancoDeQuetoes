namespace BancoDeQuestoes.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _060720173 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Resposta",
                c => new
                    {
                        RespostaId = c.Guid(nullable: false, identity: true),
                        TopicoAtribuidoId = c.Guid(nullable: false),
                        QuestaoId = c.Guid(nullable: false),
                        Descricao = c.String(nullable: false, maxLength: 1000, unicode: false),
                        Correcao = c.String(nullable: false, maxLength: 1000, unicode: false),
                        Justificativa = c.String(nullable: false, maxLength: 1000, unicode: false),
                        Status = c.String(nullable: false, maxLength: 50, unicode: false),
                        ObservacaoRevisor = c.String(nullable: false, maxLength: 1000, unicode: false),
                        ObservacaoRevisor2 = c.String(nullable: false, maxLength: 1000, unicode: false),
                        Imagem = c.String(nullable: false, maxLength: 1000, unicode: false),
                        ImagemJustificativa = c.String(nullable: false, maxLength: 1000, unicode: false),
                    })
                .PrimaryKey(t => t.RespostaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Resposta");
        }
    }
}
