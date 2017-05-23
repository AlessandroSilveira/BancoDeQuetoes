namespace BancoDeQuestoes.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _05052017 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Mestre", new[] { "Banca_BancaId" });
            RenameColumn(table: "dbo.Mestre", name: "Banca_BancaId", newName: "BancaId");
            AlterColumn("dbo.Mestre", "BancaId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Mestre", "BancaId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Mestre", new[] { "BancaId" });
            AlterColumn("dbo.Mestre", "BancaId", c => c.Guid());
            RenameColumn(table: "dbo.Mestre", name: "BancaId", newName: "Banca_BancaId");
            CreateIndex("dbo.Mestre", "Banca_BancaId");
        }
    }
}
