using System.Collections.Generic;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Domain.Interfaces.Repositories
{
	public interface IMestreFormacaoRepository: IBaseRepository<INSCR_BQ_MESTRE_FORMACAO>
	{
		List<INSCR_BQ_MESTRE_FORMACAO> Include();
	}
}
