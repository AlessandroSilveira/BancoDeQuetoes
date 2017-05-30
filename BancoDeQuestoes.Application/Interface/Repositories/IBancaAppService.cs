using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Application.ViewModels;

namespace BancoDeQuestoes.Application.Interface.Repositories
{
	public interface IBancaAppService : IDisposable
	{
		BancaViewModel Add(BancaViewModel obj);
		BancaViewModel GetById(Guid id);
		IEnumerable<BancaViewModel> GetAll();
		BancaViewModel Update(BancaViewModel obj);
		void Remove(Guid id);
		
	}
}
