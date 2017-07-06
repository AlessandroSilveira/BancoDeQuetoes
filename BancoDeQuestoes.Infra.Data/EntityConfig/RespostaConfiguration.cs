using System.Data.Entity.ModelConfiguration;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Infra.Data.EntityConfig
{
	public class RespostaConfiguration : EntityTypeConfiguration<Resposta>
	{
		public RespostaConfiguration()
		{
			HasKey(p => p.RespostaId);

			Property(p => p.TopicoAtribuidoId)
				.IsRequired();

			Property(p => p.QuestaoId)
				.IsRequired();

			Property(p => p.Descricao)
				.IsRequired()
				.HasMaxLength(1000);

			Property(p => p.Correcao)
				.IsRequired()
				.HasMaxLength(1000);

			Property(p => p.Justificativa)
				.IsRequired()
				.HasMaxLength(1000);

			Property(p => p.Status)
				.IsRequired()
				.HasMaxLength(50);

			Property(p => p.ObservacaoRevisor)
				.IsRequired()
				.HasMaxLength(1000);

			Property(p => p.ObservacaoRevisor2)
				.IsRequired()
				.HasMaxLength(1000);

			Property(p => p.Imagem)
				.IsRequired()
				.HasMaxLength(1000);

			Property(p => p.ImagemJustificativa)
				.IsRequired()
				.HasMaxLength(1000);

			ToTable("Resposta");
		}
	}
}
