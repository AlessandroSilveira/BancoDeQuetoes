using System.Collections.Generic;
using System.Linq;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repositories;

namespace BancoDeQuestoes.Infra.Data.Repositories
{
    public class DescBibliografia : IItensPesquisaDisciplina
	{
		public List<Disciplina> Pesquisa(Disciplina form, List<Disciplina> sql)
		{
			 if (!string.IsNullOrEmpty(form.Bibliografia))
			{
				sql = sql.Where(a => a.Bibliografia == form.Bibliografia).ToList();
			}

			return Proximo.Pesquisa(form, sql);
		}
		public IItensPesquisaDisciplina Proximo { get; set; }
	}
}