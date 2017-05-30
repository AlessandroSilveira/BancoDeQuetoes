using System;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Repository
{
	public interface IStatusRepository : IRepository<Status>
	{
	    void Dispose();
	}
}