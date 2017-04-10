using System.Collections.Generic;
using System.Linq;
using BancoDeQuestoes.Interfaces;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Infra.Data.Repositories
{
	internal class NomeMestre : IItensPesquisaMestre
	{
		public List<INSCR_BQ_MESTRE> Pesquisa(INSCR_BQ_MESTRE form, List<INSCR_BQ_MESTRE> sql)
		{
			if (!string.IsNullOrEmpty(form.DESC_NOME))
			{
				sql = sql.Where(a => a.DESC_NOME == form.DESC_NOME).ToList();
			}

			return Proximo.Pesquisa(form, sql);
		}

		public IItensPesquisaMestre Proximo { get; set; }
	}
}