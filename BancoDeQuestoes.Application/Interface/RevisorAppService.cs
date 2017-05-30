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
    public class RevisorAppService : ApplicationService, IRevisorAppService
    {
        private readonly IRevisorService _revisorService;

        public RevisorAppService(IRevisorService revisorService, IUnitOfWork uow) : base(uow)
        {
            _revisorService = revisorService;
        }

        public void Dispose()
        {
            _revisorService.Dispose();
        }

        public RevisorViewModel Add(RevisorViewModel obj)
        {
            var revisor = Mapper.Map<RevisorViewModel, Revisor>(obj);
            BeginTransaction();
            _revisorService.Add(revisor);
            Commit();
            return obj;
        }

        public RevisorViewModel GetById(Guid id)
        {
            return Mapper.Map<Revisor, RevisorViewModel>(_revisorService.GetById(id));
        }

        public IEnumerable<RevisorViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<Revisor>, IEnumerable<RevisorViewModel>>(_revisorService.GetAll());
        }

        public RevisorViewModel Update(RevisorViewModel obj)
        {
            BeginTransaction();
            _revisorService.Update(Mapper.Map<RevisorViewModel, Revisor>(obj));
            Commit();
            return obj;
        }

        public void Remove(Guid id)
        {
            BeginTransaction();
            _revisorService.Remove(id);
            Commit();
        }
    }
}
