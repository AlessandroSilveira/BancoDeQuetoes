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
	public class MestreDependenteAppService :IMestreDependenteAppService
	{
	    private readonly MestreDependenteRepsitory _mestreDependenteRepsitory;

	    public MestreDependenteAppService(MestreDependenteRepsitory mestreDependenteRepsitory)
	    {
	        _mestreDependenteRepsitory = mestreDependenteRepsitory;
	    }

	    public void Dispose()
	    {
	        _mestreDependenteRepsitory.Dispose();

        }

	    public MestreDependenteViewModel Add(MestreDependenteViewModel obj)
	    {
	        var mestreDependente = Mapper.Map<MestreDependenteViewModel, MestreDependente>(obj);
	        _mestreDependenteRepsitory.Add(mestreDependente);
	        return obj;
	    }

	    public MestreDependenteViewModel GetById(Guid id)
	    {
	       return Mapper.Map<MestreDependente, MestreDependenteViewModel>(_mestreDependenteRepsitory.GetById(id));
        }

	    public IEnumerable<MestreDependenteViewModel> GetAll()
	    {
	        return Mapper.Map<IEnumerable<MestreDependente>, IEnumerable<MestreDependenteViewModel>>(_mestreDependenteRepsitory.GetAll());
        }

	    public MestreDependenteViewModel Update(MestreDependenteViewModel obj)
	    {
	         _mestreDependenteRepsitory.Update(Mapper.Map<MestreDependenteViewModel, MestreDependente>(obj));
	        return obj;

	    }

	    public void Remove(Guid id)
	    {
	       _mestreDependenteRepsitory.Remove(id);
	    }

	    public IEnumerable<MestreDependenteViewModel> Search(Expression<Func<MestreDependenteViewModel, bool>> predicate)
	    {
	        throw new NotImplementedException();
	    }

	    public int SaveChanges()
	    {
	        return _mestreDependenteRepsitory.SaveChanges();
	    }
	}
}