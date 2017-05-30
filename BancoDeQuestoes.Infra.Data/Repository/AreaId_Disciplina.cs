using System.Collections.Generic;
using System.Linq;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;

namespace BancoDeQuestoes.Infra.Data.Repository
{
	public class AreaIdDisciplina : IItensPesquisaDisciplina
	{
		public List<Disciplina> Pesquisa(Disciplina form, List<Disciplina> sql)
		{
			if (string.IsNullOrEmpty(form.AreaId.ToString())) return Proximo.Pesquisa(form, sql);
			sql = sql.Where(a => a.AreaId == form.AreaId).ToList();
			return Proximo.Pesquisa(form, sql);
		}

		public IItensPesquisaDisciplina Proximo { get; set; }
	}
}