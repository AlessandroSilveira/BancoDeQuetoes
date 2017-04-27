using System.Collections.Generic;
using System.Linq;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;

namespace BancoDeQuestoes.Infra.Data.Repository.PesquisaTopico
{
	public class MestreId : IItemPesquisaTopico
	{
		public List<TopicoAtribuido> Pesquisa(TopicoAtribuido form, List<TopicoAtribuido> sql)
		{
			sql = sql.Where(a => a.Mestre.MestreId == form.Mestre.MestreId).ToList();
			return Proximo.Pesquisa(form, sql);
		}
		public IItemPesquisaTopico Proximo { get; set; }
	}
}