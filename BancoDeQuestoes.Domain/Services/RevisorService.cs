using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
    public  class RevisorService : IRevisorService
    {
        private readonly IRevisorRepository _revisorRepository;

        public RevisorService(IRevisorRepository revisorRepository)
        {
            _revisorRepository = revisorRepository;
        }

        public Revisor Add(Revisor obj)
        {
         return   _revisorRepository.Add(obj);

        }

	    public Revisor GetById(Guid id)
	    {
	      return  _revisorRepository.GetById(id);

	    }

	    public IEnumerable<Revisor> GetAll()
	    {
	        return _revisorRepository.GetAll();

	    }

	    public Revisor Update(Revisor obj)
	    {
	    return    _revisorRepository.Update(obj);

	    }

	    public void Remove(Guid obj)
	    {
	        _revisorRepository.Remove(obj);

        }

	    public void Dispose()
	    {
	        _revisorRepository.Dispose();
            GC.SuppressFinalize(this);

	    }

    }
}
