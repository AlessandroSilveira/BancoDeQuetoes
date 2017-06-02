using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using AutoMapper;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Application.Interface
{
    public class MestreAppService : ApplicationService, IMestreAppService
    {
        private readonly IMestreService _mestreService;

        public MestreAppService(IMestreService mestreService, IUnitOfWork uow) : base(uow)
        {
            _mestreService = mestreService;
        }

        public void Dispose()
        {
            _mestreService.Dispose();
        }

        public MestreViewModel Add(MestreViewModel obj)
        {
            var mestre = Mapper.Map<MestreViewModel, Mestre>(obj);
            BeginTransaction();
            _mestreService.Add(mestre);
            Commit();
            return obj;
        }

        public MestreViewModel GetById(Guid id)
        {
            return Mapper.Map<Mestre, MestreViewModel>(_mestreService.GetById(id));
        }

        public IEnumerable<MestreViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<Mestre>, IEnumerable<MestreViewModel>>(_mestreService.GetAll());
        }

        public MestreViewModel Update(MestreViewModel obj)
        {
            BeginTransaction();
            _mestreService.Update(Mapper.Map<MestreViewModel, Mestre>(obj));
            Commit();
            return obj;
        }

        public void Remove(Guid id)
        {
            BeginTransaction();
            _mestreService.Remove(id);
            Commit();
        }
        
        public IEnumerable<MestreViewModel> Search(Expression<Func<Mestre, bool>> func)
        {
            return Mapper.Map<IEnumerable<Mestre>, IEnumerable<MestreViewModel>>(_mestreService.Search(func));
        }
    }
}