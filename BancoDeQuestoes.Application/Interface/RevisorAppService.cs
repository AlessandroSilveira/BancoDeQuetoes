using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using AutoMapper;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;
using BancoDeQuestoes.Domain.Entities;

using BancoDeQuestoes.Infra.Data.Repository;

namespace BancoDeQuestoes.Application.Interface
{
    public class RevisorAppService : IRevisorAppService
    {
        private readonly RevisorRepository _revisorRepository;

        public RevisorAppService(RevisorRepository revisorRepository)
        {
            _revisorRepository = revisorRepository;
        }

        public void Dispose()
	    {
	        _revisorRepository.Dispose();
        }

	    public RevisorViewModel Add(RevisorViewModel obj)
	    {
	        var revisor = Mapper.Map<RevisorViewModel, Revisor>(obj);
	        _revisorRepository.Add(revisor);
	        return obj;
	    }

	    public RevisorViewModel GetById(Guid id)
	    {
	        return Mapper.Map< Revisor, RevisorViewModel>(_revisorRepository.GetById(id));
	    }

	    public IEnumerable<RevisorViewModel> GetAll()
	    {
	        return Mapper.Map<IEnumerable<Revisor>, IEnumerable<RevisorViewModel>>(_revisorRepository.GetAll());
        }

	    public RevisorViewModel Update(RevisorViewModel obj)
	    {
	        _revisorRepository.Update(Mapper.Map< RevisorViewModel,Revisor >(obj));
	        return obj;
	    }

	    public void Remove(Guid id)
	    {
	       _revisorRepository.Remove(id);
	    }

	    public IEnumerable<RevisorViewModel> Search(Expression<Func<RevisorViewModel, bool>> predicate)
	    {
	        throw new NotImplementedException();
	    }

	    public int SaveChanges()
	    {
	        return _revisorRepository.SaveChanges();
	    }
	}
}
