using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
	public class MestreDependenteService :  IMestreDependenteService
	{
	    private IMestreDependenteRepository _mestreDependenteRepository;

	    public MestreDependenteService(IMestreDependenteRepository mestreDependenteRepository)
	    {
	        _mestreDependenteRepository = mestreDependenteRepository;
	    }

	    public MestreDependente Add(MestreDependente obj)
	    {
	      return  _mestreDependenteRepository.Add(obj);

	    }

	    public MestreDependente GetById(Guid id)
	    {
	      return  _mestreDependenteRepository.GetById(id);

	    }

	    public IEnumerable<MestreDependente> GetAll()
	    {
	        return _mestreDependenteRepository.GetAll();
	    }

		public MestreDependente Update(MestreDependente obj)
	    {
	     return   _mestreDependenteRepository.Update(obj);

	    }

	    public void Remove(Guid obj)
	    {
	        _mestreDependenteRepository.Remove(obj);

        }

	    public void Dispose()
	    {
	        _mestreDependenteRepository.Dispose();
            GC.SuppressFinalize(this);

	    }

		
	}
}
