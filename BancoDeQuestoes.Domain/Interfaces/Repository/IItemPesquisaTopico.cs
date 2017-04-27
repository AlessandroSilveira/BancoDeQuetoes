using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Repository
{
	public interface IItemPesquisaTopico
	{
		List<TopicoAtribuido> Pesquisa(TopicoAtribuido form, List<TopicoAtribuido> sql);
		IItemPesquisaTopico Proximo { get; set; }
	}
}
