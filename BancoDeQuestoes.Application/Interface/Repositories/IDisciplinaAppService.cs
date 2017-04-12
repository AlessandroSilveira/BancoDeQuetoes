using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Application.Interface.Repositories
{
	public interface IDisciplinaAppService : IAppServiceBase<Disciplina>
	{
		IEnumerable<Disciplina> ResultadoPesquisaDisciplina(Disciplina form);
	}
}
