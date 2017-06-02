using System.Data.Entity.ModelConfiguration;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Infra.Data.EntityConfig
{
    public class AspNetUserClaimsConfiguration : EntityTypeConfiguration<AspNetUserClaims>
    {
        public AspNetUserClaimsConfiguration()
        {
            HasKey(p => p.Id);

            Property(p => p.Id)
                .IsRequired();

            Property(p => p.ClaimType)
                .IsRequired();

            Property(p => p.ClaimValue)
                .IsRequired();

            Property(p => p.User_Id)
                .HasMaxLength(128)
               .IsRequired();

            ToTable("AspNetUserClaims");
        }
    }
}