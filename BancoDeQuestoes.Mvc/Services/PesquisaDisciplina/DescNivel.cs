using System.Collections.Generic;
using System.Linq;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repositories;

namespace BancoDeQuestoes.Mvc.Services.PesquisaDisciplina
{
    public class DescNivel : IItensPesquisaDisciplina
	{
		public List<Disciplina> Pesquisa(Disciplina form, List<Disciplina> sql)
		{
			if (!string.IsNullOrEmpty(form.Nivel))
			{
				sql = sql.Where(a => a.Nivel == form.Nivel).ToList();
			}
			return Proximo.Pesquisa(form, sql);
		}
		public IItensPesquisaDisciplina Proximo { get; set; }
	}
}