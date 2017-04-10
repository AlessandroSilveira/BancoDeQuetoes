using System.Collections;
using BancoDeQuestoes.Interfaces;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Domain.Interfaces.Repositories
{
    public interface IDisciplinaRepository : IBaseRepository<INSCR_BQ_TOPICO>
    {
	    IEnumerable Cargo();
	    IEnumerable Area();
		IEnumerable ResultadoPesquisaDisciplina(INSCR_BQ_TOPICO form);
	}
}