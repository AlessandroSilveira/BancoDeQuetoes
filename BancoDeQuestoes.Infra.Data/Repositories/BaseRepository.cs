using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BancoDeQuestoes.Domain.Interfaces.Repositories;
using BancoDeQuestoes.Infra.Data.Context;

namespace BancoDeQuestoes.Infra.Data.Repositories
{
	public class BaseRepository<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : class 
	{
		protected Db Db = new Db();

		public void Add(TEntity obj)
		{
			Db.Set<TEntity>().Add(obj);
			Db.SaveChanges();
		}

		public TEntity GetById(Guid id)
		{
			return Db.Set<TEntity>().Find(id);
		}

		public IEnumerable<TEntity> GetAll()
		{
			return Db.Set<TEntity>().ToList();
		}

		public void Update(TEntity obj)
		{
			Db.Entry(obj).State = EntityState.Modified;
			Db.SaveChanges();
		}

		public void Remove(Guid id)
		{
			Db.Set<TEntity>().Remove(GetById(id));
			Db.SaveChanges();
		}

		void IBaseRepository<TEntity>.Dispose()
		{
			Db.Dispose();
		}

		void IDisposable.Dispose()
		{
			Db.Dispose();
		}
	}
}