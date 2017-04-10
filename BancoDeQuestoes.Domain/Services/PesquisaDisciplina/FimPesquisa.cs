using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Interfaces;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Services.PesquisaDisciplina
{
	public class FimPesquisa : IItensPesquisaDisciplina
	{
		public List<Disciplina> Pesquisa(Disciplina form, List<Disciplina> sql)
		{
			return sql;
		}

		public IItensPesquisaDisciplina Proximo { get; set; }
	}
}