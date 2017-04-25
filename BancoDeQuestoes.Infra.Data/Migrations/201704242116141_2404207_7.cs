namespace BancoDeQuestoes.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2404207_7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mestre", "Banca_BancaId", c => c.Guid());
            CreateIndex("dbo.Mestre", "Banca_BancaId");
            AddForeignKey("dbo.Mestre", "Banca_BancaId", "dbo.Banca", "BancaId");
            DropColumn("dbo.Mestre", "Banca");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Mestre", "Banca", c => c.String(nullable: false, maxLength: 8000, unicode: false));
            DropForeignKey("dbo.Mestre", "Banca_BancaId", "dbo.Banca");
            DropIndex("dbo.Mestre", new[] { "Banca_BancaId" });
            DropColumn("dbo.Mestre", "Banca_BancaId");
        }
    }
}
