using System.Data.Entity.ModelConfiguration;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Infra.Data.EntityConfig
{
	public class MestreFormacaoConfiguration : EntityTypeConfiguration<MestreFormacao>
	{
		public MestreFormacaoConfiguration()
		{
			HasKey(p => p.MestreFormacaoId);

			Property(p => p.TipoFormacao)
				.IsRequired()
				.HasMaxLength(150);

			Property(p => p.Curso)
				.IsRequired()
				.HasMaxLength(150);

			Property(p => p.Instituicao)
				.IsRequired()
			.HasMaxLength(150);

			Property(p => p.CopiaDiploma)
				.IsRequired();

			Property(p => p.NumeroCopiaAutenticada)
				.IsRequired();

			Property(p => p.Ativo)
				.IsRequired();

			HasRequired(p => p.Mestre)
				.WithMany()
				.HasForeignKey(p => p.MestreId);
		}
	}
}
