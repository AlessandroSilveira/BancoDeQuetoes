﻿using System;
using System.Collections.Generic;
using BancoDeQuestoes.Domain.Interfaces;
using BancoDeQuestoes.Domain.Interfaces.Repositories;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
	public class ServiceBase<TEntity> : IDisposable,IServiceBase<TEntity> where TEntity : class
	{
		private readonly IRepositoryBase<TEntity> _repositoryBase;

		public ServiceBase(IRepositoryBase<TEntity> repositoryBase)
		{
			_repositoryBase = repositoryBase;
		}

		public void Add(TEntity obj)
		{
			_repositoryBase.Add(obj);
		}

		public TEntity GetById(int id)
		{
			return _repositoryBase.GetById(id);
		}

		public IEnumerable<TEntity> GetAll()
		{
			return _repositoryBase.GetAll();
		}

		public void Update(TEntity obj)
		{
			_repositoryBase.Update(obj);
		}

		public void Remove(TEntity obj)
		{
			_repositoryBase.Remove(obj);
		}

		void IServiceBase<TEntity>.Dispose()
		{
			_repositoryBase.Dispose();
		}

		void IDisposable.Dispose()
		{
			_repositoryBase.Dispose();
		}
	}
}