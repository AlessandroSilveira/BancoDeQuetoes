using System.Collections.Generic;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Interfaces
{
	public interface IItensPesquisaDisciplina
	{
		List<INSCR_BQ_TOPICO> Pesquisa(INSCR_BQ_TOPICO form, List<INSCR_BQ_TOPICO> sql);
	}
}
