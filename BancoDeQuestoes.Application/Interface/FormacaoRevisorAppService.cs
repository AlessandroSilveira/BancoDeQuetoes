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
	public class FormacaoRevisorAppService :  IFormacaoRevisorAppService
	{
		private readonly IFormacaoRevisorService _formacaoRevisor;

		public FormacaoRevisorAppService(IFormacaoRevisorService formacaoRevisor)
		{
			_formacaoRevisor = formacaoRevisor;
		}

		public void Dispose()
	    {
			_formacaoRevisor.Dispose();
	    }

	    public RevisorFormacaoViewModel Add(RevisorFormacaoViewModel obj)
	    {
	        var formacao = Mapper.Map<RevisorFormacaoViewModel, RevisorFormacao>(obj);
			_formacaoRevisor.Add(formacao);
	        return obj;
        }

	    public RevisorFormacaoViewModel GetById(Guid id)
	    {
	        return Mapper.Map<RevisorFormacao, RevisorFormacaoViewModel>(_formacaoRevisor.GetById(id));
        }

	    public IEnumerable<RevisorFormacaoViewModel> GetAll()
	    {
	        return Mapper.Map<IEnumerable<RevisorFormacao>, IEnumerable<RevisorFormacaoViewModel>>(_formacaoRevisor.GetAll());
        }

	    public RevisorFormacaoViewModel Update(RevisorFormacaoViewModel obj)
	    {
			_formacaoRevisor.Update(Mapper.Map<RevisorFormacaoViewModel, RevisorFormacao>(obj));
	        return obj;
        }

	    public void Remove(Guid id)
	    {
			_formacaoRevisor.Remove(id);
        }

	    public IEnumerable<RevisorFormacaoViewModel> Search(Expression<Func<RevisorFormacaoViewModel, bool>> predicate)
	    {
	        throw new NotImplementedException();
	    }

	  
	}
}
