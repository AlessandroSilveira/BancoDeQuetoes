using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Repository
{
	public interface IDisciplinaRepository :  IRepository<Disciplina>
	{
	    void Dispose();

		IEnumerable<Disciplina> ExecutadorDePesquisa(Disciplina form);
	}
}
