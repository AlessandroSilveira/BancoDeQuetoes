using System.Data.Entity.ModelConfiguration;

namespace BancoDeQuestoes.Domain.Entities
{
   public class AspNetUserRolesConfiguration : EntityTypeConfiguration<AspNetUserRoles>
    {
        public AspNetUserRolesConfiguration()
        {
            HasKey(p => p.UserId);

            Property(p => p.UserId)
                .IsRequired()
                .HasMaxLength(128);

            HasKey(p => p.RoleId);

            Property(p => p.RoleId)
                .IsRequired()
                .HasMaxLength(128);

            ToTable("AspNetUserRoles");
        }
    }
}
