using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using AutoMapper;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Application.Interface
{
	public class RevisorAppService : IRevisorAppService
    {
	    private readonly IRevisorService _revisorService;

	    public RevisorAppService(IRevisorService revisorService)
	    {
		    _revisorService = revisorService;
	    }

	    public void Dispose()
	    {
			_revisorService.Dispose();
        }

	    public RevisorViewModel Add(RevisorViewModel obj)
	    {
	        var revisor = Mapper.Map<RevisorViewModel, Revisor>(obj);
			_revisorService.Add(revisor);
	        return obj;
	    }

	    public RevisorViewModel GetById(Guid id)
	    {
	        return Mapper.Map< Revisor, RevisorViewModel>(_revisorService.GetById(id));
	    }

	    public IEnumerable<RevisorViewModel> GetAll()
	    {
	        return Mapper.Map<IEnumerable<Revisor>, IEnumerable<RevisorViewModel>>(_revisorService.GetAll());
        }

	    public RevisorViewModel Update(RevisorViewModel obj)
	    {
			_revisorService.Update(Mapper.Map< RevisorViewModel,Revisor >(obj));
	        return obj;
	    }

	    public void Remove(Guid id)
	    {
			_revisorService.Remove(id);
	    }

	    public IEnumerable<RevisorViewModel> Search(Expression<Func<RevisorViewModel, bool>> predicate)
	    {
	        throw new NotImplementedException();
	    }
	}
}
