using System.Collections.Generic;
using System.Linq;
using BancoDeQuestoes.Interfaces;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Services
{
	public class DescTopico : IItensPesquisaDisciplina
	{
		public List<INSCR_BQ_TOPICO> Pesquisa(INSCR_BQ_TOPICO form, List<INSCR_BQ_TOPICO> sql)
		{
			if (!string.IsNullOrEmpty(form.DESC_TITULO))
			{
				sql = sql.Where(a => a.DESC_TITULO == form.DESC_TITULO).ToList();
			}

			return sql.ToList();
		}
	}
}