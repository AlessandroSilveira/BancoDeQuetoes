using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Repositories
{
	public interface IItensPesquisaMestre
	{
		List<Mestre> Pesquisa(Mestre form, List<Mestre> sql);
		IItensPesquisaMestre Proximo { get; set; }
	}
}