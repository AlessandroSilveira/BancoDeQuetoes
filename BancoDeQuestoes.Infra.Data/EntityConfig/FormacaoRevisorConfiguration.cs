﻿using System.Data.Entity.ModelConfiguration;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Infra.Data.EntityConfig
{
	public class FormacaoRevisorConfiguration : EntityTypeConfiguration<RevisorFormacao>
	{
		public FormacaoRevisorConfiguration()
		{
			HasKey(p => p.RevisorFormacaoId);

			Property(p => p.Formacao)
				.IsRequired()
				.HasMaxLength(150);

			Property(p => p.Instituicao)
				.IsRequired()
			.HasMaxLength(150);

			Property(p => p.Ativo)
				.IsRequired();

			HasRequired(p => p.Revisor)
				.WithMany(p=>p.RevisorFormacao)
				.HasForeignKey(p => p.RevisorId);

			ToTable("FormacaoRevisor");
		}
	}
}
