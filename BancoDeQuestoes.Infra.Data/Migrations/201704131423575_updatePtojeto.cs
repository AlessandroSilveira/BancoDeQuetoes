namespace BancoDeQuestoes.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatePtojeto : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Produto", "ClienteId", "dbo.Cliente");
            DropIndex("dbo.Produto", new[] { "ClienteId" });
            AlterColumn("dbo.Projeto", "Ativo", c => c.Boolean(nullable: false));
            DropTable("dbo.Produto");
            DropTable("dbo.Cliente");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Sobrenome = c.String(),
                        Email = c.String(),
                        DataCadastro = c.DateTime(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        ProdutoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 250),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Disponivel = c.Boolean(nullable: false),
                        ClienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProdutoId);
            
            AlterColumn("dbo.Projeto", "Ativo", c => c.String(nullable: false));
            CreateIndex("dbo.Produto", "ClienteId");
            AddForeignKey("dbo.Produto", "ClienteId", "dbo.Cliente", "ClienteId");
        }
    }
}
