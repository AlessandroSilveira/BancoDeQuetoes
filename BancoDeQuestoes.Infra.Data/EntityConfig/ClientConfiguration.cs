using System.Data.Entity.ModelConfiguration;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Infra.Data.EntityConfig
{
    public class ClientConfiguration: EntityTypeConfiguration<Client>
    {
        public ClientConfiguration()
        {
            HasKey(p => p.Id);

            Property(p => p.ClientKey)
                .IsRequired()
                .HasMaxLength(150);


            ToTable("Client");
        }
    }
}
