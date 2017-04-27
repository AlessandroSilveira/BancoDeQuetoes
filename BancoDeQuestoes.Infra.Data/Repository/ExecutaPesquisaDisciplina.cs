using System.Collections.Generic;
using System.Linq;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;

namespace BancoDeQuestoes.Infra.Data.Repository
{
	public class ExecutaPesquisaDisciplina
	{
		internal List<Disciplina> Executa(IList<IItensPesquisaDisciplina> itensPesquisaDisciplinas, List<Disciplina> sql, Disciplina form)
		{
			sql = itensPesquisaDisciplinas.Aggregate(sql, (current, itens) => itens.Pesquisa(form, current));
			return sql.ToList();
		}
	}
}