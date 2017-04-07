using System.Collections.Generic;
using System.Linq;
using BancoDeQuestoes.Interfaces;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Repositories
{
	internal class StatusMestre : IItensPesquisaMestre
	{
		public List<INSCR_BQ_MESTRE> Pesquisa(INSCR_BQ_MESTRE form, List<INSCR_BQ_MESTRE> sql)
		{
			if (!string.IsNullOrEmpty(form.DESC_ATIVO))
			{
				sql = sql.Where(a => a.DESC_ATIVO == form.DESC_ATIVO).ToList();
			}

			return Proximo.Pesquisa(form, sql);
		}

		public IItensPesquisaMestre Proximo { get; set; }
	}
}