using System.Data.Entity.ModelConfiguration;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Infra.Data.EntityConfig
{
	public class BancaConfiguration : EntityTypeConfiguration<Banca>
	{
		public BancaConfiguration()
		{
			HasKey(p => p.BancaId);

			Property(p => p.Nome)
				.IsRequired()
				.HasMaxLength(150);

			Property(p => p.Valor)
				.IsRequired();

			Property(p => p.Ativo)
				.IsRequired();

			ToTable("Banca");
		}
	}
}
