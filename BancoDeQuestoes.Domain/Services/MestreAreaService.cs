using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
    public class MestreAreaService : IMestreAreaService
    {
	    private readonly IMestreAreaRepository _mestreAreaRepository;

	    public MestreAreaService(IMestreAreaRepository mestreAreaRepository)
	    {
		    _mestreAreaRepository = mestreAreaRepository;
	    }


	    public MestreArea Add(MestreArea obj)
	    {
			return _mestreAreaRepository.Add(obj);

        }

	    public MestreArea GetById(Guid id)
	    {
	       return _mestreAreaRepository.GetById(id);

	    }

	    public IEnumerable<MestreArea> GetAll()
	    {
	        return _mestreAreaRepository.GetAll();
	    }

	    public MestreArea Update(MestreArea obj)
	    {
			return _mestreAreaRepository.Update(obj);

        }

	    public void Remove(Guid obj)
	    {
			_mestreAreaRepository.Remove(obj);

        }

	    public void Dispose()
	    {
			_mestreAreaRepository.Dispose();
            GC.SuppressFinalize(this);

        }

	   
    }
}
