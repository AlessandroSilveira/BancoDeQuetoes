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
    public class MestreAreaAppService :  IMestreAreaAppService
	{
	    private readonly MestreAreaRepository _mestreAreaRepository;

	    public MestreAreaAppService(MestreAreaRepository mestreAreaRepository)
	    {
	        _mestreAreaRepository = mestreAreaRepository;
	    }

	    public void Dispose()
	    {
	        _mestreAreaRepository.Dispose();
	    }

	    public MestreAreaViewModel Add(MestreAreaViewModel obj)
	    {
	        var mestreArea = Mapper.Map<MestreAreaViewModel, MestreArea>(obj);
	        _mestreAreaRepository.Add(mestreArea);
	        return obj;

	    }

	    public MestreAreaViewModel GetById(Guid id)
	    {
	        return Mapper.Map<MestreArea, MestreAreaViewModel>(_mestreAreaRepository.GetById(id));

	    }

	    public IEnumerable<MestreAreaViewModel> GetAll()
	    {
	        return Mapper.Map<IEnumerable<MestreArea>, IEnumerable<MestreAreaViewModel>>(_mestreAreaRepository.GetAll());
        }

	    public MestreAreaViewModel Update(MestreAreaViewModel obj)
	    {
	        _mestreAreaRepository.Update(Mapper.Map<MestreAreaViewModel, MestreArea>(obj));
	        return obj;
        }

	    public void Remove(Guid id)
	    {
	        _mestreAreaRepository.Remove(id);
	    }

	    public IEnumerable<MestreAreaViewModel> Search(Expression<Func<MestreAreaViewModel, bool>> predicate)
	    {
	        throw new NotImplementedException();
	    }

	    public int SaveChanges()
	    {
	       return _mestreAreaRepository.SaveChanges();
	    }
	}
}