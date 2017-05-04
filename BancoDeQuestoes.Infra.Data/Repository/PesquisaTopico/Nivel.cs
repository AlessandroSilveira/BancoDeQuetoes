using System.Collections.Generic;
using System.Linq;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;

namespace BancoDeQuestoes.Infra.Data.Repository.PesquisaTopico
{
	public class Nivel : IItemPesquisaTopico
	{
		public List<Disciplina> Pesquisa(Disciplina form, List<Disciplina> sql)
		{
		    if (string.IsNullOrEmpty(form.Nivel)) return Proximo.Pesquisa(form, sql);
            sql = sql.Where(a => a.Nivel.Contains(form.Nivel)).ToList();
			return Proximo.Pesquisa(form, sql);
		}
		public IItemPesquisaTopico Proximo { get; set; }
	}
}