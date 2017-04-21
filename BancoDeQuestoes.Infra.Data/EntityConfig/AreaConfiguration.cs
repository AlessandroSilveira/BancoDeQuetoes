using System.Data.Entity.ModelConfiguration;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Infra.Data.EntityConfig
{
	public class AreaConfiguration : EntityTypeConfiguration<Area>
	{
		public AreaConfiguration()
		{
			HasKey(p => p.AreaId);

			Property(p => p.Descricao)
				.IsRequired()
				.HasMaxLength(150);

			Property(p => p.ConhecimentoEspecifico)
				.IsRequired();

			Property(p => p.Ativo)
				.IsRequired();

			ToTable("Area");
		}
	}
}
