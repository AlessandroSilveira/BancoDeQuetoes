using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using AutoMapper;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Application.Interface
{
	public class MestreDependenteAppService :ApplicationService, IMestreDependenteAppService
	{
		private readonly IMestreDependenteService _mestreDependente;

		public MestreDependenteAppService(IMestreDependenteService mestreDependente, IUnitOfWork uow) :base(uow)
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
            BeginTransaction();
			_mestreDependente.Add(mestreDependente);
            Commit();
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
            BeginTransaction();
			_mestreDependente.Update(Mapper.Map<MestreDependenteViewModel, MestreDependente>(obj));
            Commit();
	        return obj;
	    }

	    public void Remove(Guid id)
	    {
            BeginTransaction();
			_mestreDependente.Remove(id);
            Commit();
	    }

	    public IEnumerable<MestreDependenteViewModel> Search(Expression<Func<MestreDependenteViewModel, bool>> predicate)
	    {
	        throw new NotImplementedException();
	    }
	}
}