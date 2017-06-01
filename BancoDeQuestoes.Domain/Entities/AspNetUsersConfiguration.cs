using System.Data.Entity.ModelConfiguration;

namespace BancoDeQuestoes.Domain.Entities
{
    public class AspNetUsersConfiguration : EntityTypeConfiguration<AspNetUsers>
    {
        public AspNetUsersConfiguration()
        {
            HasKey(p => p.Id);

            Property(p => p.UserName)
                .IsRequired();

            Property(p => p.PasswordHash)
                .IsRequired();

            Property(p => p.SecurityStamp)
                .IsRequired();

            Property(p => p.Discriminator)
               .IsRequired();

            ToTable("AspNetUsers");
        }   
    }
}