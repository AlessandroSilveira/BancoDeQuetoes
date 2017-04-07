using System.Collections.Generic;
using BancoDeQuestoes.Interfaces;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Repositories
{
	internal class FimPesquisaMestre : IItensPesquisaMestre
	{
		public List<INSCR_BQ_MESTRE> Pesquisa(INSCR_BQ_MESTRE form, List<INSCR_BQ_MESTRE> sql)
		{
			return sql;
		}

		public IItensPesquisaMestre Proximo { get; set; }
	}
}