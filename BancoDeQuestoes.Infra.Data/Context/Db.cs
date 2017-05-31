using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Infra.Data.EntityConfig;
namespace BancoDeQuestoes.Infra.Data.Context
{
    public  class Db : DbContext
    {
        public Db()
            : base("DefaultConnection")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
		public virtual DbSet<Area> Area { get; set; }
		public virtual DbSet<Projeto> Projeto { get; set; }
		public virtual DbSet<Revisor> Revisor { get; set; }
		public virtual DbSet<Disciplina> Disciplina { get; set; }
		public virtual DbSet<Banca> Banca { get; set; }
		public virtual DbSet<RevisorFormacao> FormacaoRevisor { get; set; }
		public virtual DbSet<Mestre> Mestre { get; set; }
		public virtual DbSet<MestreArea> MestreArea { get; set; }
		public virtual DbSet<MestreDependente> MestreDependente { get; set; }
		public virtual DbSet<MestreFormacao> MestreFormacao { get; set; }
		public virtual DbSet<Questao> Questao { get; set; }
		public virtual DbSet<TopicoAtribuido> TopicoAtribuido { get; set; }
		public virtual DbSet<Status> Status { get; set; }
     

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
			modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

			modelBuilder.Properties().Where(p=>p.Name == p.ReflectedType.Name+"Id").Configure(p=>p.IsKey().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity));
			modelBuilder.Properties<string>().Configure(p=>p.HasColumnType("varchar"));

			modelBuilder.Configurations.Add(new AreaConfiguration());
			modelBuilder.Configurations.Add(new ProjetoConfiguration());
			modelBuilder.Configurations.Add(new DisciplinaConfiguration());
			modelBuilder.Configurations.Add(new BancaConfiguration());
			modelBuilder.Configurations.Add(new RevisorConfigurations());
			modelBuilder.Configurations.Add(new FormacaoRevisorConfiguration());
			modelBuilder.Configurations.Add(new MestreConfiguration());
			modelBuilder.Configurations.Add(new MestreAreaConfiguration());
			modelBuilder.Configurations.Add(new MestreDependenteConfiguration());
			modelBuilder.Configurations.Add(new MestreFormacaoConfiguration());
			modelBuilder.Configurations.Add(new QuestoesConfiguration());
			modelBuilder.Configurations.Add(new TopicoAtribuidoConfiguration());
			modelBuilder.Configurations.Add(new StatusConfiguration());
			modelBuilder.Configurations.Add(new C__MigrationHistoryConfiguration());

			base.OnModelCreating(modelBuilder);
		}

     
    }
}
