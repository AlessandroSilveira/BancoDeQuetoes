using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using AutoMapper;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Infra.Data.Repositories;

namespace BancoDeQuestoes.Application.Interface
{
	public class FormacaoRevisorAppService :  IFormacaoRevisorAppService
	{
	    private readonly FormacaoRevisoresRepository _formacaoRevisoresRepository;

	    public FormacaoRevisorAppService(FormacaoRevisoresRepository formacaoRevisoresRepository)
	    {
	        _formacaoRevisoresRepository = formacaoRevisoresRepository;
	    }


	    public void Dispose()
	    {
	        _formacaoRevisoresRepository.Dispose();
	    }

	    public RevisorFormacaoViewModel Add(RevisorFormacaoViewModel obj)
	    {
	        var formacao = Mapper.Map<RevisorFormacaoViewModel, RevisorFormacao>(obj);
	        _formacaoRevisoresRepository.Add(formacao);
	        return obj;
        }

	    public RevisorFormacaoViewModel GetById(Guid id)
	    {
	        return Mapper.Map<RevisorFormacao, RevisorFormacaoViewModel>(_formacaoRevisoresRepository.GetById(id));
        }

	    public IEnumerable<RevisorFormacaoViewModel> GetAll()
	    {
	        return Mapper.Map<IEnumerable<RevisorFormacao>, IEnumerable<RevisorFormacaoViewModel>>(_formacaoRevisoresRepository.GetAll());
        }

	    public RevisorFormacaoViewModel Update(RevisorFormacaoViewModel obj)
	    {
	        _formacaoRevisoresRepository.Update(Mapper.Map<RevisorFormacaoViewModel, RevisorFormacao>(obj));
	        return obj;
        }

	    public void Remove(Guid id)
	    {
	        _formacaoRevisoresRepository.Remove(id);
        }

	    public IEnumerable<RevisorFormacaoViewModel> Search(Expression<Func<RevisorFormacaoViewModel, bool>> predicate)
	    {
	        throw new NotImplementedException();
	    }

	    public int SaveChanges()
	    {
	        return _formacaoRevisoresRepository.SaveChanges();
	    }
	}
}
