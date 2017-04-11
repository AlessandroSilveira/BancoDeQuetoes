using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BancoDeQuestoes.Domain.Interfaces.Repositories;
using BancoDeQuestoes.Infra.Data.Context;


namespace BancoDeQuestoes.Infra.Data.Repositories
{
	public class RepositoryBase<TEntity>:IDisposable,IRepositoryBase<TEntity> where TEntity : class 
	{

		protected Db db = new Db();

		public void Add(TEntity obj)
		{
		    db.Set<TEntity>().Add(obj);
		    db.SaveChanges();
		}

		public TEntity GetById(int id)
		{
			return db.Set<TEntity>().Find(id);
		}

		public IEnumerable<TEntity> GetAll()
		{
			return db.Set<TEntity>().ToList();
		}

		public void Update(TEntity obj)
		{
		    db.Entry(obj).State = EntityState.Modified;
		    db.SaveChanges();
		}

		public void Remove(TEntity obj)
		{
		    db.Set<TEntity>().Remove(obj);
		    db.SaveChanges();
		}

		void IRepositoryBase<TEntity>.Dispose()
		{
		    db.Dispose();
		}

		void IDisposable.Dispose()
		{
		    db.Dispose();
		}
	}
}
