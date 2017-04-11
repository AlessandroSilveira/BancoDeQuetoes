using System.Collections;
using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Repositories
{
    public interface IDisciplinaRepository : IBaseRepository<Disciplina>
    {
	   
	    IEnumerable Area();
		IEnumerable<Disciplina> ResultadoPesquisaDisciplina(Disciplina form);
	   
    }
}