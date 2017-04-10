namespace BancoDeQuestoes.Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateArea : DbMigration
    {
        public override void Up()
        {
			CreateTable(
				   "Area",
				   c => new
				   {
					   AreaId = c.Int(nullable: false, identity: true),
					   Descricao = c.String(maxLength: 150),
					   ConhecimentoEspecifico = c.Boolean(),
					   Ativo = c.Boolean()
				   })
			   .PrimaryKey(t => t.AreaId);
		}
        
        public override void Down()
        {
			
        }
    }
}
