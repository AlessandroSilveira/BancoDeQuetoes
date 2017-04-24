using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Infra.Data.Context;

namespace BancoDeQuestoes.Infra.Data.Repository
{
	public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
	{
	    protected Db Db;

	    protected DbSet<TEntity> DbSet;

	    public Repository()
	    {
	        Db = new Db();
	        DbSet = Db.Set<TEntity>();
	    }


	    public TEntity Add(TEntity obj)
	    {
	        var objreturn = DbSet.Add(obj);
	        SaveChanges();
	        return objreturn;
	    }

	    public virtual TEntity GetById(Guid id)
	    {
	        return DbSet.Find(id);
	    }

	    public    virtual  IEnumerable<TEntity> GetAll()
	    {
	        return DbSet.ToList();
	    }

	    public virtual  TEntity Update(TEntity obj)
	    {
	        var entry = Db.Entry(obj);
	        DbSet.Attach(obj);
            entry.State = EntityState.Modified;
	        SaveChanges();
	        return obj;
	    }

	    public virtual void Remove(Guid id)
	    {
	        DbSet.Remove(GetById(id));
		    Db.SaveChanges();

	    }

	    public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
	    {
	        return DbSet.Where(predicate);
	    }

	    public int SaveChanges()
	    {
	        return  Db.SaveChanges();
	    }

	    public void Dispose()
	    {
	        Db.Dispose();
            GC.SuppressFinalize(this); 
	    }
	}
}