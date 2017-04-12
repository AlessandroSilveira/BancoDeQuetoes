using System.Data.Entity.ModelConfiguration;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Infra.Data.EntityConfig
{
	public class MestreAreaConfiguration : EntityTypeConfiguration<MestreArea>
	{
		public MestreAreaConfiguration()
		{
			HasKey(p => p.MestreAreaId);

			Property(p => p.Nome)
				.IsRequired()
				.HasMaxLength(150);

			Property(p => p.Ativo)
				.IsRequired();

			HasRequired(p => p.Mestre)
				.WithMany()
				.HasForeignKey(p => p.MestreId);

			HasRequired(p => p.Area)
				.WithMany()
				.HasForeignKey(p => p.AreaId);
		}
	}
}
