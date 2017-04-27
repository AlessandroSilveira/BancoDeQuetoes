using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Application.ViewModels;

namespace BancoDeQuestoes.Application.Interface.Repositories
{
	public interface IDisciplinaAppService : IDisposable
	{
		DisciplinaViewModel Add(DisciplinaViewModel obj);
		DisciplinaViewModel GetById(Guid id);
		IEnumerable<DisciplinaViewModel> GetAll();
		DisciplinaViewModel Update(DisciplinaViewModel obj);
		void Remove(Guid id);
		IEnumerable<DisciplinaViewModel> ResultadoPesquisaDisciplina(DisciplinaViewModel form);
	}
}
