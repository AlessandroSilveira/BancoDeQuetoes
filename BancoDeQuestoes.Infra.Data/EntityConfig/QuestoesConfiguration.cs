using System.Data.Entity.ModelConfiguration;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Infra.Data.EntityConfig
{
	public class QuestoesConfiguration :EntityTypeConfiguration<Questao>
	{
		public QuestoesConfiguration()
		{
			HasKey(p => p.QuestaoId);

			Property(p => p.Descricao)
				.IsRequired()
				.HasMaxLength(1000);

			Property(p => p.NumeroQuestao)
				.IsRequired();

			Property(p => p.Arquivo)
				.IsRequired()
				.HasMaxLength(150);

			Property(p => p.Status)
				.IsRequired()
				.HasMaxLength(150);

			Property(p => p.NumeroDeRevisoes)
				.IsRequired();

			Property(p => p.Finalizar)
				.IsRequired();

			Property(p => p.Nivel)
				.IsRequired()
				.HasMaxLength(150);

			Property(p => p.Imagem)
				.IsRequired()
				.HasMaxLength(150);

			Property(p => p.ConviteAceito)
				.IsRequired();

			HasRequired(p => p.TopicoAtribuido)
				.WithMany()
				.HasForeignKey(p => p.TopicoAtribuidoId);

		}
	}
}
