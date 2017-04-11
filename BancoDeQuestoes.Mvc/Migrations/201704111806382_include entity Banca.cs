namespace BancoDeQuestoes.Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class includeentityBanca : DbMigration
    {
        public override void Up()
        {
	        CreateTable(
		        "dbo.Banca",
		        c => new
		        {
			        BancaId = c.Int(nullable: false, identity: true),
			        Nome = c.String(maxLength: 150),
			        Valor = c.Decimal(),
			        Ativo = c.Boolean(),
		        });
	        //.PrimaryKey(t => t.BancaId)
	        //.ForeignKey("dbo.Blogs", t => t.BlogId, cascadeDelete: true)
	        //.Index(t => t.BlogId)
	        //.Index(p => p.Title, unique: true);
        }
        
        public override void Down()
        {
        }
    }
}
