using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repositories;

namespace BancoDeQuestoes.Domain.Interfaces.Services
{
	public interface IDisciplinaService : IServiceBase<Disciplina>
	{
		IEnumerable<Disciplina> ResultadoPesquisaDisciplina(Disciplina form);
	}
}
