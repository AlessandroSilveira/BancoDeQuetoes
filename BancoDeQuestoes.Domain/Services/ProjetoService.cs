using System;
using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
	public class ProjetoService : IProjetoService
	{
	    private IProjetoRepository _projetoRepository;

	    public ProjetoService(IProjetoRepository projetoRepository)
	    {
	        _projetoRepository = projetoRepository;
	    }

	    public void Add(Projeto obj)
	    {
	        _projetoRepository.Add(obj);

	    }

	    public Projeto GetById(Guid id)
	    {
	      return  _projetoRepository.GetById(id);

	    }

	    public IEnumerable<Projeto> GetAll()
	    {
	       return _projetoRepository.GetAll();

	    }

	    public void Update(Projeto obj)
	    {
	        _projetoRepository.Update(obj);

	    }

	    public void Remove(Guid obj)
	    {
	        _projetoRepository.Remove(obj);

        }

	    public void Dispose()
	    {
	        _projetoRepository.Dispose();
            GC.SuppressFinalize(this);

	    }
	}
}
