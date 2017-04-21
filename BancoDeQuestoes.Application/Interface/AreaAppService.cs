using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using AutoMapper;
using BancoDeQuestoes.Application.ViewModels;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Infra.Data.Repositories;

namespace BancoDeQuestoes.Application.Interface
{
	public class AreaAppService :  IAreaAppService
	{

		private readonly AreaRepository _areaRepository;

		public AreaAppService(AreaRepository areaRepository)
		{
			_areaRepository = areaRepository;
		}

        public AreaAppService()
        {
        }

        public AreaViewModel Add(AreaViewModel obj)
		{
			var area = Mapper.Map<AreaViewModel, Area>(obj);
			_areaRepository.Add(area);
			return obj;
		}

		public AreaViewModel GetById(Guid id)
		{
		    return Mapper.Map<Area, AreaViewModel>(_areaRepository.GetById(id));
        }

		public IEnumerable<AreaViewModel> GetAll()
		{
			return Mapper.Map<IEnumerable<Area>, IEnumerable<AreaViewModel>>(_areaRepository.GetAll());
		}

		public AreaViewModel Update(AreaViewModel obj)
		{
			_areaRepository.Update(Mapper.Map<AreaViewModel,Area>(obj));
			return obj;
		}

		public void Remove(Guid id)
		{
			_areaRepository.Remove(id);
		}

		public IEnumerable<AreaViewModel> Search(Expression<Func<AreaViewModel, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public void Dispose()
		{
			_areaRepository.Dispose();
		}

		public int SaveChanges()
		{
		   return _areaRepository.SaveChanges();
		}
	}
}
