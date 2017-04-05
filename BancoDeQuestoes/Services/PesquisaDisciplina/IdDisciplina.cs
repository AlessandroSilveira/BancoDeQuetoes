using System.Collections.Generic;
using System.Linq;
using BancoDeQuestoes.Interfaces;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Services
{
	internal class IdDisciplina : IItensPesquisaDisciplina
	{
		public List<INSCR_BQ_TOPICO> Pesquisa(INSCR_BQ_TOPICO form, List<INSCR_BQ_TOPICO> sql)
		{
			if (form.ID_DISCIPLINA>0)
			{
				sql = sql.Where(a => a.ID_DISCIPLINA == form.ID_DISCIPLINA).ToList();
			}

			return sql.ToList();
		}
	}
}