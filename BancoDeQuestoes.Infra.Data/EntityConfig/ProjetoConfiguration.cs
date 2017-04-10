using System.Data.Entity.ModelConfiguration;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Infra.Data.EntityConfig
{
    public class ProjetoConfiguration : EntityTypeConfiguration<Projeto>
    {
        public ProjetoConfiguration()
        {
            HasKey(p => p.ProjetoId);

            Property(p => p.CodigoProjeto)
                .IsRequired();

            Property(p => p.NomeProjeto)
                .HasMaxLength(150)
                .IsRequired();

			Property(p => p.Ativo)
			 .IsRequired();
		}
    }
}
