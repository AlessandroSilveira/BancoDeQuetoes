using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Infra.Data.EntityConfig
{
	public class RevisorConfigurations: EntityTypeConfiguration<Revisor>
	{
		public RevisorConfigurations()
		{
			HasKey(p => p.RevisorId);

			Property(p => p.Nome)
				.IsRequired()
				.HasMaxLength(250);

			Property(p => p.Cep)
				.HasMaxLength(8)
				.IsRequired();

			Property(p => p.Endereco)
				.HasMaxLength(100)
				.IsRequired();

			Property(p => p.Complemento)
				.HasMaxLength(100);

			Property(p => p.Numero)
				.HasMaxLength(5)
				.IsRequired();

			Property(p => p.Bairro)
				.HasMaxLength(100)
				.IsRequired();

			Property(p => p.Cidade)
				.HasMaxLength(100)
				.IsRequired();

			Property(p => p.Uf)
				.HasMaxLength(2)
				.IsRequired();

			Property(p => p.Cpf)
				.IsRequired()
				.HasMaxLength(11)
				.IsFixedLength()
				.HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute() { IsUnique = true }));

			Property(p => p.Email)
				.HasMaxLength(150)
				.IsRequired();

			Property(p => p.EmailSecundario)
				.HasMaxLength(150)
				.IsRequired();

			Property(p => p.Telefone)
				.HasMaxLength(8)
				.IsRequired();

			Property(p => p.Celular)
				.HasMaxLength(9)
				.IsRequired();

			Property(p => p.Senha)
				.HasMaxLength(10)
				.IsRequired();

			Property(p => p.AreaId)
				.IsRequired();

			Property(p => p.Ativo)
				.IsRequired();

			ToTable("Revisor");
		}
	}
}
