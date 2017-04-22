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
	public class MestreFormacaoAppService :  IMestreFormacaoAppService
	{
	    private readonly MestreFormacaoRepository _mestreFormacaoRepository;

	    public MestreFormacaoAppService(MestreFormacaoRepository mestreFormacaoRepository)
	    {
	        _mestreFormacaoRepository = mestreFormacaoRepository;
	    }

	    public void Dispose()
	    {
	        _mestreFormacaoRepository.Dispose();

        }

	    public MestreFormacaoViewModel Add(MestreFormacaoViewModel obj)
	    {
	        var mestreFormacao = Mapper.Map<MestreFormacaoViewModel, MestreFormacao>(obj);
	        _mestreFormacaoRepository.Add(mestreFormacao);
	        return obj;
	    }

	    public MestreFormacaoViewModel GetById(Guid id)
	    {
	        return Mapper.Map<MestreFormacao,MestreFormacaoViewModel> (_mestreFormacaoRepository.GetById(id));
	    }

	    public IEnumerable<MestreFormacaoViewModel> GetAll()
	    {
	        return Mapper.Map<IEnumerable<MestreFormacao>,IEnumerable< MestreFormacaoViewModel>>(_mestreFormacaoRepository.GetAll());
        }

	    public MestreFormacaoViewModel Update(MestreFormacaoViewModel obj)
	    {
	        _mestreFormacaoRepository.Update(Mapper.Map<MestreFormacaoViewModel, MestreFormacao>(obj));
	        return obj;
	    }

	    public void Remove(Guid id)
	    {
	       _mestreFormacaoRepository.Remove(id);
	    }

	    public IEnumerable<MestreFormacaoViewModel> Search(Expression<Func<MestreFormacaoViewModel, bool>> predicate)
	    {
	        throw new NotImplementedException();
	    }

	    public int SaveChanges()
	    {
	      return  _mestreFormacaoRepository.SaveChanges();
	    }
	}
}