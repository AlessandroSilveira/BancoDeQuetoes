namespace BancoDeQuestoes.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _260620172 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Questao", "TopicoAtribuidoId");
            AddForeignKey("dbo.Questao", "TopicoAtribuidoId", "dbo.TopicoAtribuido", "TopicoAtribuidoId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Questao", "TopicoAtribuidoId", "dbo.TopicoAtribuido");
            DropIndex("dbo.Questao", new[] { "TopicoAtribuidoId" });
        }
    }
}
