using System.Collections;
using System.Linq;
using BancoDeQuestoes.Interfaces;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Repositories
{
	public class DisciplinaRepository : BaseRepository<INSCR_BQ_TOPICO>, IDisciplinaRepository
    {
	    public IEnumerable Cargo()
	    {
		    return Db.INSCR_BQ_CARGO_CBO.ToList();
	    }

	    public IEnumerable Area()
	    {
		    return Db.INSCR_BQ_DISCIPLINA.ToList();
	    }

	   
    }
}