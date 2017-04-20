using System.Data.Entity.ModelConfiguration;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Infra.Data.EntityConfig
{
	public class C__MigrationHistoryConfiguration : EntityTypeConfiguration<C__MigrationHistory>
	{
		public C__MigrationHistoryConfiguration()
		{
			HasKey(p => p.MigrationId);

			Property(p => p.ContextKey);

			Property(p => p.Model);


			Property(p => p.ProductVersion);

		}
	}
}