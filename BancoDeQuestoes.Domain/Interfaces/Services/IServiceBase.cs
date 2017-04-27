using System;
using System.Collections.Generic;

namespace BancoDeQuestoes.Domain.Interfaces.Services
{
	public interface IServiceBase<TEntity> where TEntity : class 
	{
		void Add(TEntity obj);
		TEntity GetById(Guid id);
		IEnumerable<TEntity> GetAll();
		void Update(TEntity obj);
		void Remove(Guid obj);
		void Dispose();
	}
}
