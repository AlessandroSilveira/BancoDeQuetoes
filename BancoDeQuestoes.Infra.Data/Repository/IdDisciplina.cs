using System.Collections.Generic;
using System.Linq;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;

namespace BancoDeQuestoes.Infra.Data.Repository
{
    public class IdDisciplina : IItensPesquisaDisciplina
	{
		public IItensPesquisaDisciplina Proximo { get; set; }
		public List<Disciplina> Pesquisa(Disciplina form, List<Disciplina> sql)
		{
            if (form.DisciplinaId==null)
            {
                sql = sql.Where(a => a.DisciplinaId == form.DisciplinaId).ToList();
            }

            return Proximo.Pesquisa(form, sql);
		}
	}
}