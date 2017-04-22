using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;

namespace BancoDeQuestoes.Infra.Data.Repository
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