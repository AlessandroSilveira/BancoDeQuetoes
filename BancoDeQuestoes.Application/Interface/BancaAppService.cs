using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using AutoMapper;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Application.Interface
{

	public class BancaAppService :ApplicationService, IBancaAppService
    {
        private readonly IBancaService _bancaService;

	    public BancaAppService(IBancaService bancaService, IUnitOfWork uow) : base(uow)
	    {
		    _bancaService = bancaService;
	    }

	    public BancaViewModel Add(BancaViewModel obj)
        {
            var banca = Mapper.Map<BancaViewModel, Banca>(obj);
            BeginTransaction();
			_bancaService.Add(banca);
            Commit();
            return obj;
        }

        public IEnumerable<BancaViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<Banca>, IEnumerable<BancaViewModel>>(_bancaService.GetAll());
        }

        public BancaViewModel GetById(Guid id)
        {
            return Mapper.Map<Banca, BancaViewModel>(_bancaService.GetById(id));
        }

        public void Remove(Guid id)
        {
            BeginTransaction();
			_bancaService.Remove(id);
            Commit();
        }
      
        public IEnumerable<BancaViewModel> Search(Expression<Func<BancaViewModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public BancaViewModel Update(BancaViewModel obj)
        {
            BeginTransaction();
			_bancaService.Update(Mapper.Map<BancaViewModel, Banca>(obj));
            Commit();
            return obj;
        }
         
        public void Dispose()
        {
			_bancaService.Dispose();
        }      
    }
}
