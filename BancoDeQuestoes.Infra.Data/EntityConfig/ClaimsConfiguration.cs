using System.Data.Entity.ModelConfiguration;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Infra.Data.EntityConfig
{
    public class ClaimsConfiguration : EntityTypeConfiguration<Claims>
    {
      
            public ClaimsConfiguration()
            {
                HasKey(p => p.Id);

                Property(p => p.Name)
                    .IsRequired()
                    .HasMaxLength(150);
            

                ToTable("Claims");
            }
        }
    }

