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

			Property(p => p.AreaId)
				.IsRequired();


			HasRequired(p => p.Mestre)
				.WithMany(p=>p.MestreAreas)
				.HasForeignKey(p => p.MestreId);
			
			ToTable("MestreArea");
		}
	}
}
