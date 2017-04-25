﻿using System.Collections.Generic;
using System.Linq;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;

namespace BancoDeQuestoes.Infra.Data.Repository
{
	public class DescTopico : IItensPesquisaDisciplina
	{
		public IItensPesquisaDisciplina Proximo { get; set; }
		public List<Disciplina> Pesquisa(Disciplina form, List<Disciplina> sql)
		{
			if (!string.IsNullOrEmpty(form.Descricao))
			{
				sql = sql.Where(a => a.Descricao == form.Descricao).ToList();
			}
			return Proximo.Pesquisa(form, sql);
		}
	}
}