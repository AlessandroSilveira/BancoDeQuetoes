using System.Collections.Generic;
using BancoDeQuestoes.Interfaces;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Services.PesquisaDisciplina
{
	public class FimPesquisa : IItensPesquisaDisciplina
	{
		public List<INSCR_BQ_TOPICO> Pesquisa(INSCR_BQ_TOPICO form, List<INSCR_BQ_TOPICO> sql)
		{
			return sql;
		}

		public IItensPesquisaDisciplina Proximo { get; set; }
	}
}