using System.Collections.Generic;
using System.Linq;
using BancoDeQuestoes.Interfaces;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Services.PesquisaDisciplina
{
	public class ExecutaPesquisaDisciplina
	{
		internal List<INSCR_BQ_TOPICO> Executa(IList<IItensPesquisaDisciplina> itensPesquisaDisciplinas, List<INSCR_BQ_TOPICO> sql, INSCR_BQ_TOPICO form)
		{
			foreach (var itens in itensPesquisaDisciplinas)
			{
				sql = itens.Pesquisa(form,sql);
			}

			return sql.ToList();
		}
	}
}