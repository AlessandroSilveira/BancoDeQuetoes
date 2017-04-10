using System.Collections.Generic;
using System.Linq;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Interfaces;

namespace BancoDeQuestoes.Mvc.Services.PesquisaDisciplina
{
    public class IdDisciplina : IItensPesquisaDisciplina
	{
		public IItensPesquisaDisciplina Proximo { get; set; }
		public List<Disciplina> Pesquisa(Disciplina form, List<Disciplina> sql)
		{
			if (form.DisciplinaId>0)
			{
				sql = sql.Where(a => a.DisciplinaId == form.DisciplinaId).ToList();
			}

			return Proximo.Pesquisa(form, sql);
		}

		
	}
}