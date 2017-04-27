using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;

namespace BancoDeQuestoes.Infra.Data.Repository.PesquisaTopico
{
	public class FimPesquisaTopico : IItemPesquisaTopico
	{
		public List<TopicoAtribuido> Pesquisa(TopicoAtribuido form, List<TopicoAtribuido> sql)
		{
			return sql;
		}
		public IItemPesquisaTopico Proximo { get; set; }
	}
}