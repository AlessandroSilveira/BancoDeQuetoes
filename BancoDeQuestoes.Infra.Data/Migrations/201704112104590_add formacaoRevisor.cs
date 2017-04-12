namespace BancoDeQuestoes.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addformacaoRevisor : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FormacaoRevisor", "RevisorId", "dbo.Revisor");
            DropIndex("dbo.FormacaoRevisor", new[] { "RevisorId" });
            DropTable("dbo.FormacaoRevisor");
        }
    }
}
