using System.Collections;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Interfaces
{
    public interface IDisciplinaRepository : IBaseRepository<INSCR_BQ_TOPICO>
    {
	    IEnumerable Cargo();
	    IEnumerable Area();
		
    }
}