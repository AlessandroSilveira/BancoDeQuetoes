using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Repository
{
	public interface IItensPesquisaMestre
	{
		List<Mestre> Pesquisa(Mestre form, List<Mestre> sql);
		IItensPesquisaMestre Proximo { get; set; }
	}
}