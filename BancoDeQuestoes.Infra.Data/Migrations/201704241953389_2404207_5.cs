namespace BancoDeQuestoes.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2404207_5 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Disciplina", new[] { "AreaId" });
            RenameColumn(table: "dbo.Disciplina", name: "AreaId", newName: "Area_AreaId");
            AddColumn("dbo.Revisor", "Area_AreaId", c => c.Guid());
            AlterColumn("dbo.Disciplina", "Area_AreaId", c => c.Guid());
            CreateIndex("dbo.Disciplina", "Area_AreaId");
            CreateIndex("dbo.Revisor", "Area_AreaId");
            AddForeignKey("dbo.Revisor", "Area_AreaId", "dbo.Area", "AreaId");
            DropColumn("dbo.Revisor", "AreaId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Revisor", "AreaId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Revisor", "Area_AreaId", "dbo.Area");
            DropIndex("dbo.Revisor", new[] { "Area_AreaId" });
            DropIndex("dbo.Disciplina", new[] { "Area_AreaId" });
            AlterColumn("dbo.Disciplina", "Area_AreaId", c => c.Guid(nullable: false));
            DropColumn("dbo.Revisor", "Area_AreaId");
            RenameColumn(table: "dbo.Disciplina", name: "Area_AreaId", newName: "AreaId");
            CreateIndex("dbo.Disciplina", "AreaId");
        }
    }
}
