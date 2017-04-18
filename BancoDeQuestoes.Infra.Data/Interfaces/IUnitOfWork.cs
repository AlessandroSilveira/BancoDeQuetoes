using System;

namespace BancoDeQuestoes.Infra.Data.Interfaces
{
	public interface IUnitOfWork
	{
		void BeginTransaction();
		void Commit();
	}
}