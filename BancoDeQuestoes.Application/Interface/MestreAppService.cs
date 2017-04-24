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
	public class MestreAppService :  IMestreAppService
	{
		private readonly IMestreService _mestreService;

		public MestreAppService(IMestreService mestreService)
		{
			_mestreService = mestreService;
		}

		public void Dispose()
	    {
			_mestreService.Dispose();
	    }

	    public MestreViewModel Add(MestreViewModel obj)
	    {
	        var mestre = Mapper.Map<MestreViewModel, Mestre>(obj);
			_mestreService.Add(mestre);
	        return obj;
	    }

	    public MestreViewModel GetById(Guid id)
	    {
	        return Mapper.Map<Mestre, MestreViewModel>(_mestreService.GetById(id));

        }

	    public IEnumerable<MestreViewModel> GetAll()
	    {
	        return Mapper.Map<IEnumerable<Mestre>, IEnumerable<MestreViewModel>>(_mestreService.GetAll());
        }

	    public MestreViewModel Update(MestreViewModel obj)
	    {
			_mestreService.Update(Mapper.Map<MestreViewModel, Mestre>(obj));
	        return obj;
        }

	    public void Remove(Guid id)
	    {
			_mestreService.Remove(id);
	    }

	    public IEnumerable<MestreViewModel> Search(Expression<Func<MestreViewModel, bool>> predicate)
	    {
	        throw new NotImplementedException();
	    }
	}
}