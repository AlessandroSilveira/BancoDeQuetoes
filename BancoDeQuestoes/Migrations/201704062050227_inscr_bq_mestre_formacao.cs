namespace BancoDeQuestoes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class INSCR_BQ_MESTRE_FORMACAO : DbMigration
    {
        public override void Up()
        {
			AddColumn("dbo.INSCR_BQ_MESTRE_FORMACAO", "ID_MESTRE_FORMACAO", c => c.Int());
			AddColumn("dbo.INSCR_BQ_MESTRE_FORMACAO", "ID_MESTRE", c => c.Int());
			AddColumn("dbo.INSCR_BQ_MESTRE_FORMACAO", "DESC_TIPO_FORMACAO", c => c.String());
			AddColumn("dbo.INSCR_BQ_MESTRE_FORMACAO", "DESC_CURSO", c => c.String());
			AddColumn("dbo.INSCR_BQ_MESTRE_FORMACAO", "DESC_INSTITUICAO", c => c.String());
			AddColumn("dbo.INSCR_BQ_MESTRE_FORMACAO", "DESC_COPIA_DIPLOMA", c => c.Boolean());
			AddColumn("dbo.INSCR_BQ_MESTRE_FORMACAO", "DESC_DIPLOMA_AUTENTICADO", c => c.Boolean());
			AddColumn("dbo.INSCR_BQ_MESTRE_FORMACAO", "DESC_NUMERO_COPIAS", c => c.Int());
            CreateIndex("dbo.INSCR_BQ_MESTRE_FORMACAO", "ID_MESTRE_FORMACAO");
            
        }
        
        public override void Down()
        {
        }
    }
}
