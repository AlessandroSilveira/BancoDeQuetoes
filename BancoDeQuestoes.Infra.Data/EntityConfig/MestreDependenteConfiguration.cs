using System.Data.Entity.ModelConfiguration;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Infra.Data.EntityConfig
{
	public class MestreDependenteConfiguration : EntityTypeConfiguration<MestreDependente>
	{
		public MestreDependenteConfiguration()
		{
			HasKey(p => p.MestreDependenteId);

			Property(p => p.Nome)
				.IsRequired()
				.HasMaxLength(150);

			Property(p => p.Documento)
				.IsRequired()
			.HasMaxLength(50);

			Property(p => p.DataNascimento)
				.IsRequired();

			Property(p => p.Ativo)
				.IsRequired();

			HasRequired(p => p.Mestre)
				.WithMany()
				.HasForeignKey(p => p.MestreId);

			ToTable("MestreDependente");

		}
	}
}
