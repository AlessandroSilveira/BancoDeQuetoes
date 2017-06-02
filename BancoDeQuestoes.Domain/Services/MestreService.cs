using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
	public class MestreService : IMestreService
	{
		private readonly IMestreRepository _mestreRepository;

		public MestreService(IMestreRepository mestreRepository)
		{
			_mestreRepository = mestreRepository;
		}

		public Mestre Add(Mestre obj)
		{
			return _mestreRepository.Add(obj);
		}

		public Mestre GetById(Guid id)
		{
			return _mestreRepository.GetById(id);
		}

		public IEnumerable<Mestre> GetAll()
		{
			return _mestreRepository.GetAll();
		}

		public Mestre Update(Mestre obj)
		{
			return _mestreRepository.Update(obj);
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

	    public IEnumerable<Mestre> Search(Expression<Func<Mestre, bool>> func)
	    {
	        return _mestreRepository.Search(func);
	    }
	}
}
