using System.Data.Entity.ModelConfiguration;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Infra.Data.EntityConfig
{
    public class AspNetRolesConfiguration : EntityTypeConfiguration<AspNetRoles>
    {
        public AspNetRolesConfiguration()
        {
            HasKey(p => p.Id);

            Property(p => p.Id)
                .IsRequired()
                .HasMaxLength(128);

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(150);

            ToTable("AspNetRoles");
        }
    }
}
