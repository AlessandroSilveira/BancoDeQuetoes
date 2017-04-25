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
	public class ProjetoAppService :  IProjetoAppService
	{
		private readonly IProjetoService _projetoService;

		public ProjetoAppService(IProjetoService projetoService)
		{
			_projetoService = projetoService;
		}

		public void Dispose()
	    {
			_projetoService.Dispose();
	    }

	    public ProjetoViewModel Add(ProjetoViewModel obj)
	    {
	        var projeto = Mapper.Map<ProjetoViewModel, Projeto>(obj);
			_projetoService.Add(projeto);
	        return obj;
	    }

	    public ProjetoViewModel GetById(Guid id)
	    {
	        return Mapper.Map< Projeto, ProjetoViewModel>(_projetoService.GetById(id));
	    }

	    public IEnumerable<ProjetoViewModel> GetAll()
	    {
	        return Mapper.Map<IEnumerable<Projeto>, IEnumerable<ProjetoViewModel>>(_projetoService.GetAll());
        }

	    public ProjetoViewModel Update(ProjetoViewModel obj)
	    {
			_projetoService.Update(Mapper.Map< ProjetoViewModel, Projeto>(obj));
	        return obj;
	    }

	    public void Remove(Guid id)
	    {
			_projetoService.Remove(id);
	    }

	    public IEnumerable<ProjetoViewModel> Search(Expression<Func<ProjetoViewModel, bool>> predicate)
	    {
	        throw new NotImplementedException();
	    }

	   
	}
}
