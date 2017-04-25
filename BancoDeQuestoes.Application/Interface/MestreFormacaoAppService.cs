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
	public class MestreFormacaoAppService :  IMestreFormacaoAppService
	{
		private readonly IMestreFormacaoService _mestreFormacaoService;

		public MestreFormacaoAppService(IMestreFormacaoService mestreFormacaoService)
		{
			_mestreFormacaoService = mestreFormacaoService;
		}

		public void Dispose()
	    {
			_mestreFormacaoService.Dispose();
        }

	    public MestreFormacaoViewModel Add(MestreFormacaoViewModel obj)
	    {
	        var mestreFormacao = Mapper.Map<MestreFormacaoViewModel, MestreFormacao>(obj);
			_mestreFormacaoService.Add(mestreFormacao);
	        return obj;
	    }

	    public MestreFormacaoViewModel GetById(Guid id)
	    {
	        return Mapper.Map<MestreFormacao,MestreFormacaoViewModel> (_mestreFormacaoService.GetById(id));
	    }

	    public IEnumerable<MestreFormacaoViewModel> GetAll()
	    {
	        return Mapper.Map<IEnumerable<MestreFormacao>,IEnumerable< MestreFormacaoViewModel>>(_mestreFormacaoService.GetAll());
        }

	    public MestreFormacaoViewModel Update(MestreFormacaoViewModel obj)
	    {
			_mestreFormacaoService.Update(Mapper.Map<MestreFormacaoViewModel, MestreFormacao>(obj));
	        return obj;
	    }

	    public void Remove(Guid id)
	    {
			_mestreFormacaoService.Remove(id);
	    }

	    public IEnumerable<MestreFormacaoViewModel> Search(Expression<Func<MestreFormacaoViewModel, bool>> predicate)
	    {
	        throw new NotImplementedException();
	    }
	}
}