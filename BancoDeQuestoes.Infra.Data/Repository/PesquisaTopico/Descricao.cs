using System.Collections.Generic;
using System.Linq;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;

namespace BancoDeQuestoes.Infra.Data.Repository.PesquisaTopico
{
	public class Descricao : IItemPesquisaTopico
	{
		public List<Disciplina> Pesquisa(Disciplina form, IEnumerable<Disciplina> sql)
		{
			sql = sql.Where(c => c.Descricao == form.Descricao).ToList();
			return Proximo.Pesquisa(form, sql);
		}

		public IItemPesquisaTopico Proximo { get; set; }
	}
}