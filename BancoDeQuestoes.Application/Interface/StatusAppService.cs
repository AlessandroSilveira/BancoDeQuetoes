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
	public class StatusAppService : IStatusAppService
	{
	    private readonly StatusRepository _statusRepository;

	    public StatusAppService(StatusRepository statusRepository)
	    {
	        _statusRepository = statusRepository;
	    }

	    public void Dispose()
	    {
	        _statusRepository.Dispose();
	    }

	    public StatusViewModel Add(StatusViewModel obj)
	    {
	        var status = Mapper.Map<StatusViewModel, Status>(obj);
	        _statusRepository.Add(status);
	        return obj;
	    }

	    public StatusViewModel GetById(Guid id)
	    {
	        return Mapper.Map<Status, StatusViewModel>(_statusRepository.GetById(id));
        }

	    public IEnumerable<StatusViewModel> GetAll()
	    {
	        return Mapper.Map<IEnumerable<Status>, IEnumerable<StatusViewModel>>(_statusRepository.GetAll());
        }

	    public StatusViewModel Update(StatusViewModel obj)
	    {
	         _statusRepository.Update(Mapper.Map<  StatusViewModel, Status>(obj));
	        return obj;

	    }

	    public void Remove(Guid id)
	    {
	       _statusRepository.Remove(id);
	    }

	    public IEnumerable<StatusViewModel> Search(Expression<Func<StatusViewModel, bool>> predicate)
	    {
	        throw new NotImplementedException();
	    }

	    public int SaveChanges()
	    {
	      return  _statusRepository.SaveChanges();
	    }
	}
}