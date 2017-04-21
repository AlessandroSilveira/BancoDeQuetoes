using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Application.ViewModels;

namespace BancoDeQuestoes.Application.Interface.Repositories
{
	public interface IProjetoAppService : IDisposable
	{

		ProjetoViewModel Add(ProjetoViewModel obj);

		ProjetoViewModel GetById(Guid id);

		IEnumerable<ProjetoViewModel> GetAll();

		ProjetoViewModel Update(ProjetoViewModel obj);

		void Remove(Guid id);

		IEnumerable<ProjetoViewModel> Search(Expression<Func<ProjetoViewModel, bool>> predicate);

		int SaveChanges();
	}
}
