using System;
using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
    public class AreaService : IAreaService
    {
        private readonly IAreaRepository _areaRepository;

        public AreaService(IAreaRepository areaRepository)
        {
            _areaRepository = areaRepository;
        }


        public void Add(Area obj)
        {
            _areaRepository.Add(obj);

        }

      

        public Area GetById(Guid id)
	    {
	       return _areaRepository.GetById(id);

	    }

	    public IEnumerable<Area> GetAll()
	    {
	        return _areaRepository.GetAll();

	    }

	    public void Update(Area obj)
	    {
	        _areaRepository.Add(obj);

	    }

	    public void Remove(Guid obj)
	    {
	        _areaRepository.Remove(obj);

        }

	    public void Dispose()
	    {
	        _areaRepository.Dispose();
            GC.SuppressFinalize(this);
	    }
	}
}
