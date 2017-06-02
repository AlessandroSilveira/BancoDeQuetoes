using System.Data.Entity.ModelConfiguration;

namespace BancoDeQuestoes.Domain.Entities
{
    public class AspNetUserLoginsConfiguration : EntityTypeConfiguration<AspNetUserLogins>
    {
        public AspNetUserLoginsConfiguration()
        {
            HasKey(p => p.UserId);

            Property(p => p.UserId)
                .IsRequired()
                .HasMaxLength(128);

            Property(p => p.LoginProvider)
                .IsRequired().HasMaxLength(128);

            Property(p => p.ProviderKey)
                .IsRequired()
                .HasMaxLength(128);

            ToTable("AspNetUserLogins");
        }
    }
}
