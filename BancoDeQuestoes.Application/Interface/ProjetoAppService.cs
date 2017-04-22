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
	public class ProjetoAppService :  IProjetoAppService
	{
	    private readonly ProjetoRepository _projetoRepository;

	    public ProjetoAppService(ProjetoRepository projetoRepository)
	    {
	        _projetoRepository = projetoRepository;
	    }

	    public void Dispose()
	    {
	       _projetoRepository.Dispose();
	    }

	    public ProjetoViewModel Add(ProjetoViewModel obj)
	    {
	        var projeto = Mapper.Map<ProjetoViewModel, Projeto>(obj);
	        _projetoRepository.Add(projeto);
	        return obj;
	    }

	    public ProjetoViewModel GetById(Guid id)
	    {
	        return Mapper.Map< Projeto, ProjetoViewModel>(_projetoRepository.GetById(id));
	    }

	    public IEnumerable<ProjetoViewModel> GetAll()
	    {
	        return Mapper.Map<IEnumerable<Projeto>, IEnumerable<ProjetoViewModel>>(_projetoRepository.GetAll());
        }

	    public ProjetoViewModel Update(ProjetoViewModel obj)
	    {
	        _projetoRepository.Update(Mapper.Map< ProjetoViewModel, Projeto>(obj));
	        return obj;
	    }

	    public void Remove(Guid id)
	    {
	        _projetoRepository.Remove(id);
	    }

	    public IEnumerable<ProjetoViewModel> Search(Expression<Func<ProjetoViewModel, bool>> predicate)
	    {
	        throw new NotImplementedException();
	    }

	    public int SaveChanges()
	    {
	        return _projetoRepository.SaveChanges();
	    }
	}
}
