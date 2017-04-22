using System;
using System.Collections.Generic;
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

	    public void Add(Status obj)
	    {
	        _statusRepository.Add(obj);

	    }

	    public Status GetById(Guid id)
	    {
	      return  _statusRepository.GetById(id);

	    }

	    public IEnumerable<Status> GetAll()
	    {
	        return _statusRepository.GetAll();

	    }

	    public void Update(Status obj)
	    {
	        _statusRepository.Update(obj);

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