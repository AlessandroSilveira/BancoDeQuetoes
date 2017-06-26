namespace BancoDeQuestoes.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _26062017 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Questao", "TopicoAtribuidoId", "dbo.TopicoAtribuido");
            DropIndex("dbo.Questao", new[] { "TopicoAtribuidoId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Questao", "TopicoAtribuidoId");
            AddForeignKey("dbo.Questao", "TopicoAtribuidoId", "dbo.TopicoAtribuido", "TopicoAtribuidoId");
        }
    }
}
