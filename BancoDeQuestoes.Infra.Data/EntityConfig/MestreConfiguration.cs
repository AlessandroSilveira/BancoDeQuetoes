using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Infra.Data.EntityConfig
{
	public class MestreConfiguration : EntityTypeConfiguration<Mestre>
	{
		public MestreConfiguration()
		{
			HasKey(p => p.MestreId);

			Property(p => p.BancaId)
				.IsRequired();

			Property(p => p.Nome)
				.IsRequired()
				.HasMaxLength(150);

			Property(p => p.Cpf)
				.IsRequired()
				.HasMaxLength(11)
				.IsFixedLength()
				.HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute() { IsUnique = true }));

			Property(p => p.Endereco)
				.IsRequired()
				.HasMaxLength(150);

			Property(p => p.Complemento)
				.HasMaxLength(150);

			Property(p => p.Numero)
				.IsRequired()
				.HasMaxLength(6);

			Property(p => p.Bairro)
				.IsRequired()
				.HasMaxLength(150);

			Property(p => p.Estado)
				.IsRequired()
				.HasMaxLength(2)
				.IsFixedLength();

			Property(p => p.Email)
				.IsRequired()
				.HasMaxLength(150);

			Property(p => p.EmailSecundario)
				.IsRequired()
				.HasMaxLength(150);

			Property(p => p.Telefone)
				.IsRequired()
				.HasMaxLength(15);

			Property(p => p.Celular)
				.IsRequired()
				.HasMaxLength(15);

			

			Property(p => p.Filhos)
				.HasMaxLength(2);

			Property(p => p.Pis)
				.IsRequired()
				.HasMaxLength(20);

			Property(p => p.Minicurriculo);

			Property(p => p.Banco)
				.IsRequired()
				.HasMaxLength(150);

			Property(p => p.Agencia)
				.IsRequired()
				.HasMaxLength(150);

			Property(p => p.TipoConta)
				.IsRequired()
				.HasMaxLength(150);

			Property(p => p.Conta)
				.IsRequired()
				.HasMaxLength(150);

			Property(p => p.Ativo)
				.IsRequired();

			ToTable("Mestre");
		}
	}
}
