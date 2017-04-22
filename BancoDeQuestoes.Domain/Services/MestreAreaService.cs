using System;
using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
    public class MestreAreaService : IMestreAreaService
    {
        private IMestreAreaService _mestreAreaService;

        public MestreAreaService(IMestreAreaService mestreAreaService)
        {
            _mestreAreaService = mestreAreaService;
        }

        public void Add(MestreArea obj)
	    {
	        _mestreAreaService.Add(obj);

        }

	    public MestreArea GetById(Guid id)
	    {
	       return _mestreAreaService.GetById(id);

	    }

	    public IEnumerable<MestreArea> GetAll()
	    {
	        return _mestreAreaService.GetAll();
	    }

	    public void Update(MestreArea obj)
	    {
	        _mestreAreaService.Update(obj);

        }

	    public void Remove(Guid obj)
	    {
	        _mestreAreaService.Remove(obj);

        }

	    public void Dispose()
	    {
	        _mestreAreaService.Dispose();
            GC.SuppressFinalize(this);

        }
	}
}
