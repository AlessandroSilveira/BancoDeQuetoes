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
	public class MestreDependenteAppService :IMestreDependenteAppService
	{
		private readonly IMestreDependenteService _mestreDependente;

		public MestreDependenteAppService(IMestreDependenteService mestreDependente)
		{
			_mestreDependente = mestreDependente;
		}

		public void Dispose()
	    {
			_mestreDependente.Dispose();

        }

	    public MestreDependenteViewModel Add(MestreDependenteViewModel obj)
	    {
	        var mestreDependente = Mapper.Map<MestreDependenteViewModel, MestreDependente>(obj);
			_mestreDependente.Add(mestreDependente);
	        return obj;
	    }

	    public MestreDependenteViewModel GetById(Guid id)
	    {
	       return Mapper.Map<MestreDependente, MestreDependenteViewModel>(_mestreDependente.GetById(id));
        }

	    public IEnumerable<MestreDependenteViewModel> GetAll()
	    {
	        return Mapper.Map<IEnumerable<MestreDependente>, IEnumerable<MestreDependenteViewModel>>(_mestreDependente.GetAll());
        }

	    public MestreDependenteViewModel Update(MestreDependenteViewModel obj)
	    {
			_mestreDependente.Update(Mapper.Map<MestreDependenteViewModel, MestreDependente>(obj));
	        return obj;

	    }

	    public void Remove(Guid id)
	    {
			_mestreDependente.Remove(id);
	    }

	    public IEnumerable<MestreDependenteViewModel> Search(Expression<Func<MestreDependenteViewModel, bool>> predicate)
	    {
	        throw new NotImplementedException();
	    }
	}
}