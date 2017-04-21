using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Application.ViewModels;

namespace BancoDeQuestoes.Application.Interface
{
	public interface IAreaAppService : IDisposable
	{

		AreaViewModel Add(AreaViewModel obj);

		AreaViewModel GetById(Guid id);

		IEnumerable<AreaViewModel> GetAll();

		AreaViewModel Update(AreaViewModel obj);

		void Remove(Guid id);

		IEnumerable<AreaViewModel> Search(Expression<Func<AreaViewModel, bool>> predicate);

		int SaveChanges();

	
	}
}
