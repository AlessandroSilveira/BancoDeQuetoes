using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repositories;

namespace BancoDeQuestoes.Infra.Data.Repositories
{
	internal class FimPesquisaMestre : IItensPesquisaMestre
	{
		public List<Mestre> Pesquisa(Mestre form, List<Mestre> sql)
		{
			return sql;
		}

		public IItensPesquisaMestre Proximo { get; set; }
	}
}