using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
	public class StatusService :IStatusService
	{
	    private readonly IStatusRepository _statusRepository;

	    public StatusService(IStatusRepository statusRepository)
	    {
	        _statusRepository = statusRepository;
	    }

	    public Status Add(Status obj)
	    {
	      return  _statusRepository.Add(obj);

	    }

	    public Status GetById(Guid id)
	    {
	      return  _statusRepository.GetById(id);

	    }

	    public IEnumerable<Status> GetAll()
	    {
	        return _statusRepository.GetAll();

	    }

	    public Status Update(Status obj)
	    {
	     return   _statusRepository.Update(obj);

	    }

	    public void Remove(Guid obj)
	    {
	        _statusRepository.Remove(obj);

        }

	    public void Dispose()
	    {
	        _statusRepository.Dispose();
            GC.SuppressFinalize(this);

	    }

		
	}
}