using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Services
{
	public interface IStatusService : IDisposable
	{
		Status Add(Status obj);
		Status GetById(Guid id);
		IEnumerable<Status> GetAll();
		Status Update(Status obj);
		void Remove(Guid id);
	    Status ObterDescricaoStatus(string itemSemConfirmaçãoDeAceitePeloElaborador);
	    IEnumerable<Status> Search(Expression<Func<Status, bool>> func);
	}
}