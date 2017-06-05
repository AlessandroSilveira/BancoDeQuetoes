using System.Data.Entity.ModelConfiguration;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Infra.Data.EntityConfig
{
    public class ConviteMestreConfiguration : EntityTypeConfiguration<ConviteMestre>
    {
        public ConviteMestreConfiguration()
        {
            HasKey(p => p.ConviteMestreId);

            Property(p => p.MestreId)
                .IsRequired();

            Property(p => p.TopicoAtribuidoId)
                .IsRequired();

            Property(p => p.Aceito)
                .IsRequired();

            Property(p => p.DataAceito);

            Property(p => p.NumeroQuestao)
                .IsRequired();

            Property(p => p.TipoPagamento)
                .HasMaxLength(50)
                .IsRequired();

            Property(p => p.Valor)
                .IsRequired();

            ToTable("ConviteMestre");
        }
    }
}