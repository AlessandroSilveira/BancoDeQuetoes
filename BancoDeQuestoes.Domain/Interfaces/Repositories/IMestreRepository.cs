using System.Collections.Generic;
using BancoDeQuestoes.Interfaces;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Domain.Interfaces.Repositories
{
    public interface IMestreRepository : IBaseRepository<INSCR_BQ_MESTRE>
    {
       // object Include(Func<object, object> func);
        List<INSCR_BQ_MESTRE> Include();
		IEnumerable<INSCR_BQ_MESTRE> ResultadoPesquisaMestre(INSCR_BQ_MESTRE form);
	}
}