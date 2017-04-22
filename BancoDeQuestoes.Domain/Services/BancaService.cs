using System;
using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
	public class BancaService :  IBancaService
	{
	    private readonly IBancaRepository _bancaRepository;

	    public BancaService(IBancaRepository bancaRepository)
	    {
	        _bancaRepository = bancaRepository;
	    }


	    public void Add(Banca obj)
	    {
	        _bancaRepository.Add(obj);

	    }

	    public Banca GetById(Guid id)
	    {
	       return  _bancaRepository.GetById(id);

	    }

	    public IEnumerable<Banca> GetAll()
	    {
	       return _bancaRepository.GetAll();

	    }

	    public void Update(Banca obj)
	    {
	        _bancaRepository.Update(obj);

	    }

	    public void Remove(Guid obj)
	    {
	        _bancaRepository.Remove(obj);

	    }

	    public void Dispose()
	    {
	        _bancaRepository.Dispose();
            GC.SuppressFinalize(this);

	    }
	}
}
