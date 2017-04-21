using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using AutoMapper;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Services;
using BancoDeQuestoes.Infra.Data.Repositories;

namespace BancoDeQuestoes.Application.Interface
{
	public class MestreAppService :  IMestreAppService
	{
	    private readonly MestreRepository _mestreRepository;

	    public MestreAppService(MestreRepository mestreRepository)
	    {
	        _mestreRepository = mestreRepository;
	    }

	    public void Dispose()
	    {
	        _mestreRepository.Dispose();
	    }

	    public MestreViewModel Add(MestreViewModel obj)
	    {
	        var mestre = Mapper.Map<MestreViewModel, Mestre>(obj);
	        _mestreRepository.Add(mestre);
	        return obj;
	    }

	    public MestreViewModel GetById(Guid id)
	    {
	        return Mapper.Map<Mestre, MestreViewModel>(_mestreRepository.GetById(id));

        }

	    public IEnumerable<MestreViewModel> GetAll()
	    {
	        return Mapper.Map<IEnumerable<Mestre>, IEnumerable<MestreViewModel>>(_mestreRepository.GetAll());
        }

	    public MestreViewModel Update(MestreViewModel obj)
	    {
	        _mestreRepository.Update(Mapper.Map<MestreViewModel, Mestre>(obj));
	        return obj;
        }

	    public void Remove(Guid id)
	    {
	        _mestreRepository.Remove(id);
	    }

	    public IEnumerable<MestreViewModel> Search(Expression<Func<MestreViewModel, bool>> predicate)
	    {
	        throw new NotImplementedException();
	    }

	    public int SaveChanges()
	    {
	      return  _mestreRepository.SaveChanges();
	    }


	}
}