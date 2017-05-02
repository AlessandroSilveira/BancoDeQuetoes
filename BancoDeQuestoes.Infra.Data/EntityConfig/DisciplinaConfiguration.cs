using System.Data.Entity.ModelConfiguration;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Infra.Data.EntityConfig
{
	public class DisciplinaConfiguration : EntityTypeConfiguration<Disciplina>
	{
		public DisciplinaConfiguration()
		{
			HasKey(p => p.DisciplinaId);

			Property(p => p.Nome)
				.IsRequired();

			Property(p => p.AreaId)
				.IsRequired();

			Property(p => p.Descricao)
				.HasMaxLength(150)
				.IsRequired();

			Property(p => p.Nome)
				.HasMaxLength(150)
				.IsRequired();

			Property(p => p.Bibliografia)
				.HasMaxLength(150)
				.IsRequired();


			Property(p => p.Nivel)
				.HasMaxLength(150)
				.IsRequired();

			Property(p => p.Ativo)
			 .IsRequired();

			ToTable("Disciplina");
		}
	}
}
