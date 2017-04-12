using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repositories;

namespace BancoDeQuestoes.Mvc.Services.PesquisaDisciplina
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