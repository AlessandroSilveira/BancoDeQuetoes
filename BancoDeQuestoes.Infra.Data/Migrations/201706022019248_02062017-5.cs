namespace BancoDeQuestoes.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _020620175 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ConviteMestre",
                c => new
                    {
                        ConviteMestreId = c.Guid(nullable: false, identity: true),
                        MestreId = c.Guid(nullable: false),
                        TopicoAtribuidoId = c.Guid(nullable: false),
                        NumeroQuestao = c.Int(nullable: false),
                        Aceito = c.Boolean(nullable: false),
                        TipoPagamento = c.String(nullable: false, maxLength: 50, unicode: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DataAceito = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ConviteMestreId)
                .ForeignKey("dbo.Mestre", t => t.MestreId)
                .ForeignKey("dbo.TopicoAtribuido", t => t.TopicoAtribuidoId)
                .Index(t => t.MestreId)
                .Index(t => t.TopicoAtribuidoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ConviteMestre", "TopicoAtribuidoId", "dbo.TopicoAtribuido");
            DropForeignKey("dbo.ConviteMestre", "MestreId", "dbo.Mestre");
            DropIndex("dbo.ConviteMestre", new[] { "TopicoAtribuidoId" });
            DropIndex("dbo.ConviteMestre", new[] { "MestreId" });
            DropTable("dbo.ConviteMestre");
        }
    }
}
