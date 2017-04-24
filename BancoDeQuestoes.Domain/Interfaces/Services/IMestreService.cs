using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Services
{
	public interface IMestreService : IDisposable
	{
		Mestre Add(Mestre obj);

		Mestre GetById(Guid id);

		IEnumerable<Mestre> GetAll();

		Mestre Update(Mestre obj);

		void Remove(Guid id);

		
	}
}
