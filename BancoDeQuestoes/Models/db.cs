namespace BancoDeQuestoes.Models
{
    using System.Data.Entity;

    public partial class db : DbContext
    {
        public db()
            : base("name=db")
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
        public virtual DbSet<INSCR_BQ_DISCIPLINA> INSCR_BQ_DISCIPLINA { get; set; }
        public virtual DbSet<INSCR_BQ_MESTRE> INSCR_BQ_MESTRE { get; set; }
        public virtual DbSet<INSCR_BQ_PROJETO> INSCR_BQ_PROJETO { get; set; }
        public virtual DbSet<INSCR_BQ_QUESTAO> INSCR_BQ_QUESTAO { get; set; }
        public virtual DbSet<INSCR_BQ_QUESTAO_APROVADA> INSCR_BQ_QUESTAO_APROVADA { get; set; }
        public virtual DbSet<INSCR_BQ_QUESTAO_PROJETO> INSCR_BQ_QUESTAO_PROJETO { get; set; }
        public virtual DbSet<INSCR_BQ_QUESTAO_RECICLADA_COMP> INSCR_BQ_QUESTAO_RECICLADA_COMP { get; set; }
        public virtual DbSet<INSCR_BQ_QUESTAO_RECICLAR_REVISOR> INSCR_BQ_QUESTAO_RECICLAR_REVISOR { get; set; }
        public virtual DbSet<INSCR_BQ_QUESTAO_REVISADA> INSCR_BQ_QUESTAO_REVISADA { get; set; }
        public virtual DbSet<INSCR_BQ_QUESTAO_REVISOR> INSCR_BQ_QUESTAO_REVISOR { get; set; }
        public virtual DbSet<INSCR_BQ_RESPOSTA> INSCR_BQ_RESPOSTA { get; set; }
        public virtual DbSet<INSCR_BQ_RESPOSTA_REVISADA> INSCR_BQ_RESPOSTA_REVISADA { get; set; }
        public virtual DbSet<INSCR_BQ_REVISOR> INSCR_BQ_REVISOR { get; set; }
        public virtual DbSet<INSCR_BQ_STATUS> INSCR_BQ_STATUS { get; set; }
        public virtual DbSet<INSCR_BQ_TIPO_GRAU_FORMACAO> INSCR_BQ_TIPO_GRAU_FORMACAO { get; set; }
        public virtual DbSet<INSCR_BQ_TOP_DISC_CARGO> INSCR_BQ_TOP_DISC_CARGO { get; set; }
        public virtual DbSet<INSCR_BQ_TOPICO> INSCR_BQ_TOPICO { get; set; }
        public virtual DbSet<INSCR_BQ_TOPICO_ATRIBUIDO> INSCR_BQ_TOPICO_ATRIBUIDO { get; set; }
        public virtual DbSet<INSCR_BQ_MESTRE_FORMACAO> INSCR_BQ_MESTRE_FORMACAO { get; set; }





        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<INSCR_ADMIN>()
                .HasMany(e => e.INSCR_ADMIN_PERFIL)
                .WithRequired(e => e.INSCR_ADMIN)
                .WillCascadeOnDelete(false);
			

            modelBuilder.Entity<INSCR_BQ_CARGO_CBO>()
                .HasMany(e => e.INSCR_BQ_TOPICO_ATRIBUIDO)
                .WithOptional(e => e.INSCR_BQ_CARGO_CBO)
                .HasForeignKey(e => e.ID_CARGO);

            modelBuilder.Entity<INSCR_BQ_CARGO_CBO>()
                .HasMany(e => e.INSCR_BQ_TOPICO)
                .WithOptional(e => e.INSCR_BQ_CARGO_CBO)
                .HasForeignKey(e => e.ID_CARGO);

            modelBuilder.Entity<INSCR_BQ_CARGO_CBO>()
                .HasMany(e => e.INSCR_BQ_TOP_DISC_CARGO)
                .WithRequired(e => e.INSCR_BQ_CARGO_CBO)
                .HasForeignKey(e => e.ID_CARGO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_DISCIPLINA>()
                .HasMany(e => e.INSCR_BQ_TOPICO_ATRIBUIDO)
                .WithRequired(e => e.INSCR_BQ_DISCIPLINA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_DISCIPLINA>()
                .HasMany(e => e.INSCR_BQ_TOPICO)
                .WithRequired(e => e.INSCR_BQ_DISCIPLINA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_DISCIPLINA>()
                .HasMany(e => e.INSCR_BQ_TOP_DISC_CARGO)
                .WithRequired(e => e.INSCR_BQ_DISCIPLINA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_MESTRE>()
                .HasMany(e => e.INSCR_BQ_CONVITE_MESTRE)
                .WithRequired(e => e.INSCR_BQ_MESTRE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_MESTRE>()
                .HasMany(e => e.INSCR_BQ_MESTRE_FORMACAO)
                .WithRequired(e => e.INSCR_BQ_MESTRE)
                .WillCascadeOnDelete(false);


            modelBuilder.Entity<INSCR_BQ_MESTRE_FORMACAO>();
                

            modelBuilder.Entity<INSCR_BQ_MESTRE>()
                .HasMany(e => e.INSCR_BQ_CONVITE_REVISAO_MESTRE)
                .WithRequired(e => e.INSCR_BQ_MESTRE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_MESTRE>()
                .HasMany(e => e.INSCR_BQ_TOPICO_ATRIBUIDO)
                .WithRequired(e => e.INSCR_BQ_MESTRE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_PROJETO>()
                .HasMany(e => e.INSCR_BQ_QUESTAO_PROJETO)
                .WithRequired(e => e.INSCR_BQ_PROJETO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_PROJETO>()
                .HasMany(e => e.INSCR_BQ_TOP_DISC_CARGO)
                .WithRequired(e => e.INSCR_BQ_PROJETO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_PROJETO>()
                .HasMany(e => e.INSCR_BQ_TOPICO_ATRIBUIDO)
                .WithRequired(e => e.INSCR_BQ_PROJETO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_QUESTAO>()
                .Property(e => e.EXPORTAR_SEBRAE)
                .IsFixedLength();

            modelBuilder.Entity<INSCR_BQ_QUESTAO>()
                .HasMany(e => e.INSCR_BQ_QUESTAO_RECICLAR_REVISOR)
                .WithRequired(e => e.INSCR_BQ_QUESTAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_QUESTAO>()
                .HasMany(e => e.INSCR_BQ_QUESTAO_REVISADA)
                .WithRequired(e => e.INSCR_BQ_QUESTAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_QUESTAO>()
                .HasMany(e => e.INSCR_BQ_QUESTAO_REVISOR)
                .WithRequired(e => e.INSCR_BQ_QUESTAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_QUESTAO>()
                .HasMany(e => e.INSCR_BQ_RESPOSTA)
                .WithRequired(e => e.INSCR_BQ_QUESTAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_QUESTAO>()
                .HasMany(e => e.INSCR_BQ_RESPOSTA_REVISADA)
                .WithRequired(e => e.INSCR_BQ_QUESTAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_QUESTAO_REVISADA>()
                .HasMany(e => e.INSCR_BQ_QUESTAO_PROJETO)
                .WithRequired(e => e.INSCR_BQ_QUESTAO_REVISADA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_QUESTAO_REVISOR>()
                .Property(e => e.DESC_REVISAO_1)
                .IsUnicode(false);

            modelBuilder.Entity<INSCR_BQ_QUESTAO_REVISOR>()
                .Property(e => e.DESC_REVISAO_2)
                .IsUnicode(false);

            modelBuilder.Entity<INSCR_BQ_RESPOSTA>()
                .HasMany(e => e.INSCR_BQ_RESPOSTA_REVISADA)
                .WithRequired(e => e.INSCR_BQ_RESPOSTA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_REVISOR>()
                .HasMany(e => e.INSCR_BQ_CONVITE_REVISOR)
                .WithRequired(e => e.INSCR_BQ_REVISOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_REVISOR>()
                .HasMany(e => e.INSCR_BQ_QUESTAO_RECICLAR_REVISOR)
                .WithRequired(e => e.INSCR_BQ_REVISOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_REVISOR>()
                .HasMany(e => e.INSCR_BQ_QUESTAO_REVISADA)
                .WithRequired(e => e.INSCR_BQ_REVISOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_REVISOR>()
                .HasMany(e => e.INSCR_BQ_QUESTAO_REVISOR)
                .WithRequired(e => e.INSCR_BQ_REVISOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_REVISOR>()
                .HasMany(e => e.INSCR_BQ_RESPOSTA_REVISADA)
                .WithRequired(e => e.INSCR_BQ_REVISOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_TOPICO>()
                .HasMany(e => e.INSCR_BQ_TOP_DISC_CARGO)
                .WithRequired(e => e.INSCR_BQ_TOPICO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_TOPICO>()
                .HasMany(e => e.INSCR_BQ_TOPICO_ATRIBUIDO)
                .WithRequired(e => e.INSCR_BQ_TOPICO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_TOPICO_ATRIBUIDO>()
                .HasMany(e => e.INSCR_BQ_CONVITE_MESTRE)
                .WithRequired(e => e.INSCR_BQ_TOPICO_ATRIBUIDO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_TOPICO_ATRIBUIDO>()
                .HasMany(e => e.INSCR_BQ_QUESTAO)
                .WithRequired(e => e.INSCR_BQ_TOPICO_ATRIBUIDO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_TOPICO_ATRIBUIDO>()
                .HasMany(e => e.INSCR_BQ_QUESTAO_REVISADA)
                .WithRequired(e => e.INSCR_BQ_TOPICO_ATRIBUIDO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_TOPICO_ATRIBUIDO>()
                .HasMany(e => e.INSCR_BQ_RESPOSTA)
                .WithRequired(e => e.INSCR_BQ_TOPICO_ATRIBUIDO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_TOPICO_ATRIBUIDO>()
                .HasMany(e => e.INSCR_BQ_RESPOSTA_REVISADA)
                .WithRequired(e => e.INSCR_BQ_TOPICO_ATRIBUIDO)
                .WillCascadeOnDelete(false);
			
        }
    }
}
