namespace BancoDeQuestoes.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _050620172 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ConviteMestre", "DataAceito", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ConviteMestre", "DataAceito", c => c.DateTime(nullable: false));
        }
    }
}
