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
	public class MestreAreaAppService :  IMestreAreaAppService
    {
	    private readonly IMestreAreaService _mestreAreaService;

	    public MestreAreaAppService(IMestreAreaService mestreAreaService)
	    {
		    _mestreAreaService = mestreAreaService;
	    }


	    public void Dispose()
	    {
			_mestreAreaService.Dispose();
	    }

	    public MestreAreaViewModel Add(MestreAreaViewModel obj)
	    {
	        var mestreArea = Mapper.Map<MestreAreaViewModel, MestreArea>(obj);
			_mestreAreaService.Add(mestreArea);
	        return obj;
	    }

	    public MestreAreaViewModel GetById(Guid id)
	    {
	        return Mapper.Map<MestreArea, MestreAreaViewModel>(_mestreAreaService.GetById(id));

	    }

	    public IEnumerable<MestreAreaViewModel> GetAll()
	    {
	        return Mapper.Map<IEnumerable<MestreArea>, IEnumerable<MestreAreaViewModel>>(_mestreAreaService.GetAll());
        }

	    public MestreAreaViewModel Update(MestreAreaViewModel obj)
	    {
			_mestreAreaService.Update(Mapper.Map<MestreAreaViewModel, MestreArea>(obj));
	        return obj;
        }

	    public void Remove(Guid id)
	    {
			_mestreAreaService.Remove(id);
	    }

	    public IEnumerable<MestreAreaViewModel> Search(Expression<Func<MestreAreaViewModel, bool>> predicate)
	    {
	        throw new NotImplementedException();
	    }

	 
	}
}