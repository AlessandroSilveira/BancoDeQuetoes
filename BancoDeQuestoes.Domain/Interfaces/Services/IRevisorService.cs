using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Services
{
	public interface IRevisorService : IDisposable
	{
		Revisor Add(Revisor obj);

		Revisor GetById(Guid id);

		IEnumerable<Revisor> GetAll();

		Revisor Update(Revisor obj);

		void Remove(Guid id);

		
	}
}
