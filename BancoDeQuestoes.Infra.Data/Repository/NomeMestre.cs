using System.Collections.Generic;
using System.Linq;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;

namespace BancoDeQuestoes.Infra.Data.Repository
{
	internal class NomeMestre : IItensPesquisaMestre
	{
		public List<Mestre> Pesquisa(Mestre form, List<Mestre> sql)
		{
			if (!string.IsNullOrEmpty(form.Nome))
			{
				sql = sql.Where(a => a.Nome == form.Nome).ToList();
			}
			return Proximo.Pesquisa(form, sql);
		}
		public IItensPesquisaMestre Proximo { get; set; }
	}
}