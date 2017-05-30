using System.Collections.Generic;
using System.Linq;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;

namespace BancoDeQuestoes.Infra.Data.Repository.PesquisaTopico
{
	public class AreaId : IItemPesquisaTopico
	{
		public List<Disciplina> Pesquisa(Disciplina form, List<Disciplina> sql)
		{
			if (form.AreaId.ToString() == "00000000-0000-0000-0000-000000000000" || string.IsNullOrEmpty(form.AreaId.ToString())) return Proximo.Pesquisa(form, sql);
			sql = sql.Where(a => a.AreaId.ToString().Contains(form.AreaId.ToString())).ToList();
			return Proximo.Pesquisa(form, sql);
		}

		public IItemPesquisaTopico Proximo { get; set; }
	}
}