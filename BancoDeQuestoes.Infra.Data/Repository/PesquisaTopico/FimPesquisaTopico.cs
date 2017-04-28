using System.Collections.Generic;
using System.Linq;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;

namespace BancoDeQuestoes.Infra.Data.Repository.PesquisaTopico
{
	public class FimPesquisaTopico : IItemPesquisaTopico
	{
		public List<Disciplina> Pesquisa(Disciplina form, IEnumerable<Disciplina> sql)
		{
			return sql.ToList();
		}
		public IItemPesquisaTopico Proximo { get; set; }
	}
}