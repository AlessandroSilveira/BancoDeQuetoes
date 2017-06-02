using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Application.ViewModels;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Application.Interface.Repositories
{
	public interface IMestreAppService : IDisposable
	{
		MestreViewModel Add(MestreViewModel obj);
		MestreViewModel GetById(Guid id);
		IEnumerable<MestreViewModel> GetAll();
		MestreViewModel Update(MestreViewModel obj);
		void Remove(Guid id);
        IEnumerable<MestreViewModel> Search(Expression<Func<Mestre, bool>> func);
    }
}
