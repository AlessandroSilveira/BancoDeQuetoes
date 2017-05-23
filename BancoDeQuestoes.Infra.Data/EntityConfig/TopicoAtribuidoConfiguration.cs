using System.Data.Entity.ModelConfiguration;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Infra.Data.EntityConfig
{
    public class TopicoAtribuidoConfiguration : EntityTypeConfiguration<TopicoAtribuido>
    {
        public TopicoAtribuidoConfiguration()
        {
            HasKey(p => p.TopicoAtribuidoId);

            Property(p => p.CodigoProjeto)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.ProjetoId)
                .IsRequired();

            Property(p => p.AreaId)
                .IsRequired();

            Property(p => p.MestreId)
                .IsRequired();

            Property(p => p.DisciplinaId)
                .IsRequired();

            Property(p => p.NumeroQuestao)
                .IsRequired();

            Property(p => p.DataEntrega)
                .IsRequired();

            Property(p => p.Status)
                .HasMaxLength(150)
                .IsRequired();

            Property(p => p.Nivel)
                .HasMaxLength(150)
                .IsRequired();

            Property(p => p.Valor)
                .IsRequired();

            Property(p => p.QuestoesRealizadas)
                .IsRequired();

            Property(p => p.Aceito)
                .IsRequired();

            Property(p => p.Observacao)
                .HasMaxLength(150)
                .IsRequired();

            Property(p => p.DataAtribuicao)
                .IsRequired();

            Property(p => p.ConviteAceito)
                .IsRequired();

            ToTable("TopicoAtribuido");
        }
    }
}
