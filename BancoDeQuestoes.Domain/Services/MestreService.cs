using System;
using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
    public class MestreService :  IMestreService
    {
        private IMestreRepository _mestreRepository;

        public MestreService(IMestreRepository mestreRepository)
        {
            _mestreRepository = mestreRepository;
        }

        public void Add(Mestre obj)
        {
            _mestreRepository.Add(obj);

        }

	    public Mestre GetById(Guid id)
	    {
	     return   _mestreRepository.GetById(id);

	    }

	    public IEnumerable<Mestre> GetAll()
	    {
	      return  _mestreRepository.GetAll();

	    }

	    public void Update(Mestre obj)
	    {
	        _mestreRepository.Update(obj);

	    }

	    public void Remove(Guid obj)
	    {
	        _mestreRepository.Remove(obj);

        }

	    public void Dispose()
	    {
	        _mestreRepository.Dispose();
            GC.SuppressFinalize(this);

	    }
	}
}
