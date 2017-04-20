using System;
using System.Collections.Generic;

namespace BancoDeQuestoes.Domain.Interfaces.Repositories
{
	public interface IBaseRepository<TEntity> where TEntity : class
	{
		TEntity Add(TEntity obj);

		TEntity GetById(Guid id);

		IEnumerable<TEntity> GetAll();

		TEntity Update(TEntity obj);

		void Remove(Guid id);

		void Dispose();
	}
}
