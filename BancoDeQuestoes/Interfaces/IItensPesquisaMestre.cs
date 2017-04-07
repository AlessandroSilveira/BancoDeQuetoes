using System.Collections.Generic;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Interfaces
{
	public interface IItensPesquisaMestre
	{
		List<INSCR_BQ_MESTRE> Pesquisa(INSCR_BQ_MESTRE form, List<INSCR_BQ_MESTRE> sql);
		IItensPesquisaMestre Proximo { get; set; }
	}
}