using System;
using System.Collections.Generic;
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
	    IEnumerable<Status> ObterDescricaoStatus(string itemSemConfirmaçãoDeAceitePeloElaborador);
	}
}