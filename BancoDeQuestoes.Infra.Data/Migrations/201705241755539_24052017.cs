namespace BancoDeQuestoes.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _24052017 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TopicoAtribuido", "Questao_QuestaoId", c => c.Guid());
            CreateIndex("dbo.TopicoAtribuido", "Questao_QuestaoId");
            AddForeignKey("dbo.TopicoAtribuido", "Questao_QuestaoId", "dbo.Questao", "QuestaoId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TopicoAtribuido", "Questao_QuestaoId", "dbo.Questao");
            DropIndex("dbo.TopicoAtribuido", new[] { "Questao_QuestaoId" });
            DropColumn("dbo.TopicoAtribuido", "Questao_QuestaoId");
        }
    }
}
