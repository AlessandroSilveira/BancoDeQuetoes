using System.Collections.Generic;
using System.Linq;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repositories;

namespace BancoDeQuestoes.Infra.Data.Repositories
{
	internal class StatusMestre : IItensPesquisaMestre
	{
		public List<Mestre> Pesquisa(Mestre form, List<Mestre> sql)
		{
			if (form.Ativo)
			{
				sql = sql.Where(a => a.Ativo == form.Ativo).ToList();
			}
			return Proximo.Pesquisa(form, sql);
		}
		public IItensPesquisaMestre Proximo { get; set; }
	}
}