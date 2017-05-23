namespace BancoDeQuestoes.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _220520171 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Status", "NumeroStatus", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Status", "NumeroStatus");
        }
    }
}
