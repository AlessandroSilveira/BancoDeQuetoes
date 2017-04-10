namespace BancoDeQuestoes.Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateprojetos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "Projeto",
                    c => new
                    {
                        ProjetoId = c.Int(nullable: false, identity: true),
                        CodigoProjeto = c.Int(),
                        NomeProjeto = c.String(maxLength:150),
                        Ativo = c.Boolean()
                    })
                .PrimaryKey(t => t.ProjetoId);
        }
        
        public override void Down()
        {
            DropTable("Projetoes");
        }
    }
}
