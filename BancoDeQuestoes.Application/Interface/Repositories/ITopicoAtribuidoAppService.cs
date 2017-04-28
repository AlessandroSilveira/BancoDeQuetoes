using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Application.ViewModels;

namespace BancoDeQuestoes.Application.Interface.Repositories
{
	public interface ITopicoAtribuidoAppService : IDisposable
	{
		TopicoAtribuidoViewModel Add(TopicoAtribuidoViewModel obj);
		TopicoAtribuidoViewModel GetById(Guid id);
		IEnumerable<TopicoAtribuidoViewModel> GetAll();
		TopicoAtribuidoViewModel Update(TopicoAtribuidoViewModel obj);
		void Remove(Guid id);
		IEnumerable<TopicoAtribuidoViewModel> Search(Expression<Func<TopicoAtribuidoViewModel, bool>> predicate);
		IEnumerable<DisciplinaViewModel> ResultadoPesquisaDisciplina(DisciplinaViewModel topicoAtribuidoViewModel, IEnumerable<DisciplinaViewModel> todos);
	}
}