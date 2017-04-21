using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using BancoDeQuestoes.Domain.Interfaces.Repositories;
using BancoDeQuestoes.Infra.Data.Context;


namespace BancoDeQuestoes.Infra.Data.Repositories
{
	public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
	{

		protected Db Db;
		protected DbSet<TEntity> DbSet;

		public RepositoryBase()
		{
			Db = new Db();
			DbSet = Db.Set<TEntity>();
		}

		void IDisposable.Dispose()
		{
			Db.Dispose();
			GC.SuppressFinalize(this);
		}


		public virtual TEntity Add(TEntity obj)
		{
			var objreturn = DbSet.Add(obj);
			SaveChanges();
			return objreturn;
		}


		public virtual TEntity GetById(Guid id)
		{
			var objretun = DbSet.Find(id);
			return objretun;
		}

		public IEnumerable<TEntity> GetAll()
		{
			return DbSet.ToList();
		}

		public virtual TEntity Update(TEntity obj)
		{
			var entry = Db.Entry(obj);
			DbSet.Attach(obj);
			entry.State = EntityState.Modified;
			SaveChanges();
			return obj;
		}

		public void Remove(Guid id)
		{
			DbSet.Remove(GetById(id));
		}

		public IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicate)
		{
			return DbSet.Where(predicate);
		}

		public int SaveChanges()
		{
			return Db.SaveChanges();
		}

		void IRepositoryBase<TEntity>.Dispose()
		{
			Db.Dispose();
			GC.SuppressFinalize(this);
		}
	}
}
