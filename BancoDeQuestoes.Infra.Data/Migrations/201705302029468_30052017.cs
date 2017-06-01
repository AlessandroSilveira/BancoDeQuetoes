namespace BancoDeQuestoes.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _30052017 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Claims");
            DropTable("dbo.Client");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientKey = c.String(maxLength: 8000, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Claims",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(maxLength: 8000, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
