using System.Collections.Generic;
using System.Linq;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;

namespace BancoDeQuestoes.Infra.Data.Repository.PesquisaDisciplina
{
	public class IdDisciplina : IItensPesquisaDisciplina
	{
		public IItensPesquisaDisciplina Proximo { get; set; }
		public List<Disciplina> Pesquisa(Disciplina form, List<Disciplina> sql)
		{
			if (form.DisciplinaId.ToString() == "00000000-0000-0000-0000-000000000000") return Proximo.Pesquisa(form, sql);
			sql = sql.Where(a => a.DisciplinaId == form.DisciplinaId).ToList();

			return Proximo.Pesquisa(form, sql);
		}
	}
}