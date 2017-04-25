using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using AutoMapper;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Services;
using BancoDeQuestoes.Infra.Data.Repository;

namespace BancoDeQuestoes.Application.Interface
{
	public class AreaAppService :  IAreaAppService
	{

		private readonly IAreaService _areaService;

		public AreaAppService(IAreaService areaService)
		{
			_areaService = areaService;
		}


		public AreaViewModel Add(AreaViewModel obj)
		{
			var area = Mapper.Map<AreaViewModel, Area>(obj);
			_areaService.Add(area);
			return obj;
		}

		public AreaViewModel GetById(Guid id)
		{
		    return Mapper.Map<Area, AreaViewModel>(_areaService.GetById(id));
        }

		public IEnumerable<AreaViewModel> GetAll()
		{
			return Mapper.Map<IEnumerable<Area>, IEnumerable<AreaViewModel>>(_areaService.GetAll());
		}

		public AreaViewModel Update(AreaViewModel obj)
		{
			_areaService.Update(Mapper.Map<AreaViewModel,Area>(obj));
			return obj;
		}

		public void Remove(Guid id)
		{
			_areaService.Remove(id);
		}

		public IEnumerable<AreaViewModel> Search(Expression<Func<AreaViewModel, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public void Dispose()
		{
			_areaService.Dispose();
		}

	
	}
}
