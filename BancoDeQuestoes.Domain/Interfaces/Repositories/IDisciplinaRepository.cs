using System.Collections;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Interfaces;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Domain.Interfaces.Repositories
{
    public interface IDisciplinaRepository : IBaseRepository<Disciplina>
    {
	    IEnumerable Cargo();
	    IEnumerable Area();
		IEnumerable ResultadoPesquisaDisciplina(Disciplina form);
	}
}