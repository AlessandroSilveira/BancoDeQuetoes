using System.Data.Entity.ModelConfiguration;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Infra.Data.EntityConfig
{
	public class StatusConfiguration : EntityTypeConfiguration<Status>
	{
		public StatusConfiguration()
		{
			HasKey(p => p.StatusId);

			Property(p => p.Nome)
				.IsRequired()
				.HasMaxLength(150);

		    Property(p => p.NumeroStatus);

            Property(p => p.Ativo)
				.IsRequired();

			ToTable("Status");
		}
	}
}
