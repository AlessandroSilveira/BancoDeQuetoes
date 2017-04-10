using System.Collections.Generic;
using System.Linq;
using BancoDeQuestoes.Interfaces;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Services.PesquisaDisciplina
{
    public class DescBibliografia : IItensPesquisaDisciplina
	{
		public List<INSCR_BQ_TOPICO> Pesquisa(INSCR_BQ_TOPICO form, List<INSCR_BQ_TOPICO> sql)
		{
			 if (!string.IsNullOrEmpty(form.DESC_BIBLIOGRAFIA))
			{
				sql = sql.Where(a => a.DESC_BIBLIOGRAFIA == form.DESC_BIBLIOGRAFIA).ToList();
			}

			return Proximo.Pesquisa(form, sql);
		}

		public IItensPesquisaDisciplina Proximo { get; set; }
	}
}