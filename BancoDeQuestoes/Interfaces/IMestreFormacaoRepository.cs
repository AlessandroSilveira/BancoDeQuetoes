using System.Collections.Generic;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Interfaces
{
	public interface IMestreFormacaoRepository: IBaseRepository<INSCR_BQ_MESTRE_FORMACAO>
	{
		List<INSCR_BQ_MESTRE_FORMACAO> Include();
	}
}
