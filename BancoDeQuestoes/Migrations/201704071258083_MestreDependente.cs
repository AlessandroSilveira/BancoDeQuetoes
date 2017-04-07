namespace BancoDeQuestoes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MestreDependente : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MestreDependentes",
                c => new
                    {
                        IdMestreDependente = c.Int(nullable: false, identity: true),
                        IDMestre = c.Int(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Documento = c.String(nullable: false, maxLength: 100),
                        DataDeNascimento = c.DateTime(nullable: false),
                        INSCR_BQ_MESTRE_ID_MESTRE = c.Int(),
                    })
                .PrimaryKey(t => t.IdMestreDependente)
                .ForeignKey("dbo.INSCR_BQ_MESTRE", t => t.INSCR_BQ_MESTRE_ID_MESTRE)
                .Index(t => t.INSCR_BQ_MESTRE_ID_MESTRE);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MestreDependentes", "INSCR_BQ_MESTRE_ID_MESTRE", "dbo.INSCR_BQ_MESTRE");
            DropIndex("dbo.MestreDependentes", new[] { "INSCR_BQ_MESTRE_ID_MESTRE" });
            DropTable("dbo.MestreDependentes");
        }
    }
}
