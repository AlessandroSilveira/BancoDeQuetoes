using System;
using System.Collections.Generic;
using AutoMapper;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Application.Interface
{
	public class AreaAppService : ApplicationService, IAreaAppService
    {
        private readonly IAreaService _areaService;

        public AreaAppService(IAreaService areaService, IUnitOfWork uow) : base(uow)
        {
            _areaService = areaService;
        }

        public AreaViewModel Add(AreaViewModel obj)
        {
            var area = Mapper.Map<AreaViewModel, Area>(obj);
            BeginTransaction();
            _areaService.Add(area);
            Commit();
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
            BeginTransaction();
            _areaService.Update(Mapper.Map<AreaViewModel, Area>(obj));
            Commit();
            return obj;
        }

        public void Remove(Guid id)
        {
            BeginTransaction();
            _areaService.Remove(id);
            Commit();
        }

        

        public void Dispose()
        {
            _areaService.Dispose();
        }
    }
}
