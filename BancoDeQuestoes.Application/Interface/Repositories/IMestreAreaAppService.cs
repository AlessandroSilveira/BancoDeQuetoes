using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Application.ViewModels;

namespace BancoDeQuestoes.Application.Interface.Repositories
{
	public interface IMestreAreaAppService : IDisposable
	{
		MestreAreaViewModel Add(MestreAreaViewModel obj);
		MestreAreaViewModel GetById(Guid id);
		IEnumerable<MestreAreaViewModel> GetAll();
		MestreAreaViewModel Update(MestreAreaViewModel obj);
		void Remove(Guid id);
		IEnumerable<MestreAreaViewModel> Search(Expression<Func<MestreAreaViewModel, bool>> predicate);
	}
}