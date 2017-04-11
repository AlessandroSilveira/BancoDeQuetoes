using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Infra.Data.EntityConfig;
using BancoDeQuestoes.Models;


namespace BancoDeQuestoes.Infra.Data.Context
{
    public  class Db : DbContext
    {
        public Db()
            : base("db")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<INSCR_ADMIN> INSCR_ADMIN { get; set; }
        public virtual DbSet<INSCR_ADMIN_PERFIL> INSCR_ADMIN_PERFIL { get; set; }
        public virtual DbSet<INSCR_BQ_BANCA> INSCR_BQ_BANCA { get; set; }
        public virtual DbSet<INSCR_BQ_CARGO_CBO> INSCR_BQ_CARGO_CBO { get; set; }
        public virtual DbSet<INSCR_BQ_CONVITE_MESTRE> INSCR_BQ_CONVITE_MESTRE { get; set; }
        public virtual DbSet<INSCR_BQ_CONVITE_REVISAO_MESTRE> INSCR_BQ_CONVITE_REVISAO_MESTRE { get; set; }
        public virtual DbSet<INSCR_BQ_CONVITE_REVISOR> INSCR_BQ_CONVITE_REVISOR { get; set; }
        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<INSCR_BQ_MESTRE> INSCR_BQ_MESTRE { get; set; }
        public virtual DbSet<Projeto> Projeto { get; set; }
        public virtual DbSet<INSCR_BQ_QUESTAO> INSCR_BQ_QUESTAO { get; set; }
        public virtual DbSet<INSCR_BQ_QUESTAO_APROVADA> INSCR_BQ_QUESTAO_APROVADA { get; set; }
        public virtual DbSet<INSCR_BQ_QUESTAO_PROJETO> INSCR_BQ_QUESTAO_PROJETO { get; set; }
        public virtual DbSet<INSCR_BQ_QUESTAO_RECICLADA_COMP> INSCR_BQ_QUESTAO_RECICLADA_COMP { get; set; }
        public virtual DbSet<INSCR_BQ_QUESTAO_RECICLAR_REVISOR> INSCR_BQ_QUESTAO_RECICLAR_REVISOR { get; set; }
        public virtual DbSet<INSCR_BQ_QUESTAO_REVISADA> INSCR_BQ_QUESTAO_REVISADA { get; set; }
        public virtual DbSet<INSCR_BQ_QUESTAO_REVISOR> INSCR_BQ_QUESTAO_REVISOR { get; set; }
        public virtual DbSet<INSCR_BQ_RESPOSTA> INSCR_BQ_RESPOSTA { get; set; }
        public virtual DbSet<INSCR_BQ_RESPOSTA_REVISADA> INSCR_BQ_RESPOSTA_REVISADA { get; set; }
        public virtual DbSet<Revisor> Revisor { get; set; }
        public virtual DbSet<INSCR_BQ_STATUS> INSCR_BQ_STATUS { get; set; }
        public virtual DbSet<INSCR_BQ_TIPO_GRAU_FORMACAO> INSCR_BQ_TIPO_GRAU_FORMACAO { get; set; }
        public virtual DbSet<INSCR_BQ_TOP_DISC_CARGO> INSCR_BQ_TOP_DISC_CARGO { get; set; }
        public virtual DbSet<Disciplina> INSCR_BQ_TOPICO { get; set; }
        public virtual DbSet<INSCR_BQ_TOPICO_ATRIBUIDO> INSCR_BQ_TOPICO_ATRIBUIDO { get; set; }
        public virtual DbSet<INSCR_BQ_MESTRE_FORMACAO> INSCR_BQ_MESTRE_FORMACAO { get; set; }
		public virtual DbSet<MestreDependente> MestreDependente { get; set; }
		
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
			modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
			modelBuilder.Configurations.Add(new AreaConfiguration());
			modelBuilder.Configurations.Add(new ProdutoConfiguration());
			modelBuilder.Configurations.Add(new ProjetoConfiguration());
		}

		//public System.Data.Entity.DbSet<BancoDeQuestoes.Mvc.ViewModels.RevisorViewModel> RevisorViewModels { get; set; }

		//public System.Data.Entity.DbSet<BancoDeQuestoes.Mvc.ViewModels.DisciplinaViewModel> DisciplinaViewModels { get; set; }
	}
}
