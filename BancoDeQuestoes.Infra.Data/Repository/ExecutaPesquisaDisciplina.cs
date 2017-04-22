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
			foreach (var itens in itensPesquisaDisciplinas)
			{
				sql = itens.Pesquisa(form,sql);
			}

			return sql.ToList();
		}
	}
}