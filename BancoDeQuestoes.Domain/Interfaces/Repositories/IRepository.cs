﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Repositories
{
	public interface IRepository<TEntity> where TEntity : class
	{
		TEntity Add(TEntity obj);

	    TEntity GetById(Guid id);

		IEnumerable<TEntity> GetAll();

		TEntity Update(TEntity obj);

		void Remove(Guid id);

	    IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>>predicate);

	    int SaveChanges();
	}
}
