namespace BancoDeQuestoes.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _22052017 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.TopicoAtribuido", new[] { "Area_AreaId" });
            DropIndex("dbo.TopicoAtribuido", new[] { "Disciplina_DisciplinaId" });
            DropIndex("dbo.TopicoAtribuido", new[] { "Mestre_MestreId" });
            DropIndex("dbo.TopicoAtribuido", new[] { "Projeto_ProjetoId" });
            RenameColumn(table: "dbo.TopicoAtribuido", name: "Area_AreaId", newName: "AreaId");
            RenameColumn(table: "dbo.TopicoAtribuido", name: "Disciplina_DisciplinaId", newName: "DisciplinaId");
            RenameColumn(table: "dbo.TopicoAtribuido", name: "Mestre_MestreId", newName: "MestreId");
            RenameColumn(table: "dbo.TopicoAtribuido", name: "Projeto_ProjetoId", newName: "ProjetoId");
            AlterColumn("dbo.TopicoAtribuido", "AreaId", c => c.Guid(nullable: false));
            AlterColumn("dbo.TopicoAtribuido", "DisciplinaId", c => c.Guid(nullable: false));
            AlterColumn("dbo.TopicoAtribuido", "MestreId", c => c.Guid(nullable: false));
            AlterColumn("dbo.TopicoAtribuido", "ProjetoId", c => c.Guid(nullable: false));
            CreateIndex("dbo.TopicoAtribuido", "ProjetoId");
            CreateIndex("dbo.TopicoAtribuido", "AreaId");
            CreateIndex("dbo.TopicoAtribuido", "MestreId");
            CreateIndex("dbo.TopicoAtribuido", "DisciplinaId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.TopicoAtribuido", new[] { "DisciplinaId" });
            DropIndex("dbo.TopicoAtribuido", new[] { "MestreId" });
            DropIndex("dbo.TopicoAtribuido", new[] { "AreaId" });
            DropIndex("dbo.TopicoAtribuido", new[] { "ProjetoId" });
            AlterColumn("dbo.TopicoAtribuido", "ProjetoId", c => c.Guid());
            AlterColumn("dbo.TopicoAtribuido", "MestreId", c => c.Guid());
            AlterColumn("dbo.TopicoAtribuido", "DisciplinaId", c => c.Guid());
            AlterColumn("dbo.TopicoAtribuido", "AreaId", c => c.Guid());
            RenameColumn(table: "dbo.TopicoAtribuido", name: "ProjetoId", newName: "Projeto_ProjetoId");
            RenameColumn(table: "dbo.TopicoAtribuido", name: "MestreId", newName: "Mestre_MestreId");
            RenameColumn(table: "dbo.TopicoAtribuido", name: "DisciplinaId", newName: "Disciplina_DisciplinaId");
            RenameColumn(table: "dbo.TopicoAtribuido", name: "AreaId", newName: "Area_AreaId");
            CreateIndex("dbo.TopicoAtribuido", "Projeto_ProjetoId");
            CreateIndex("dbo.TopicoAtribuido", "Mestre_MestreId");
            CreateIndex("dbo.TopicoAtribuido", "Disciplina_DisciplinaId");
            CreateIndex("dbo.TopicoAtribuido", "Area_AreaId");
        }
    }
}
