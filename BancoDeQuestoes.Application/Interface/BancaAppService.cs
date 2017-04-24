using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using AutoMapper;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Services;
using BancoDeQuestoes.Infra.Data.Repository;

namespace BancoDeQuestoes.Application.Interface
{

    public class BancaAppService : IBancaAppService
    {

        private readonly IBancaService _bancaService;

	    public BancaAppService(IBancaService bancaService)
	    {
		    _bancaService = bancaService;
	    }


	    public BancaViewModel Add(BancaViewModel obj)
        {
            var banca = Mapper.Map<BancaViewModel, Banca>(obj);
			_bancaService.Add(banca);
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
			_bancaService.Remove(id);
        }

      
        public IEnumerable<BancaViewModel> Search(Expression<Func<BancaViewModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public BancaViewModel Update(BancaViewModel obj)
        {
			_bancaService.Update(Mapper.Map<BancaViewModel, Banca>(obj));
            return obj;
        }

         
        public void Dispose()
        {
			_bancaService.Dispose();
        }      
    }
}
