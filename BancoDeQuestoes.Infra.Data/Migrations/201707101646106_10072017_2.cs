namespace BancoDeQuestoes.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _10072017_2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TopicoAtribuido", "NumeroRespostas", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TopicoAtribuido", "NumeroRespostas");
        }
    }
}
