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
    public class ConviteMestreAppService : ApplicationService, IConviteMestreAppService
    {
        private readonly IConviteMestreService _conviteMestreService;

        public ConviteMestreAppService(IUnitOfWork unitOfWork, IConviteMestreService conviteMestreService)
            : base(unitOfWork)
        {
            _conviteMestreService = conviteMestreService;
        }

        public void Dispose()
        {
            _conviteMestreService.Dispose();
        }

        public ConviteMestreViewModel Add(ConviteMestreViewModel obj)
        {
            var topico = Mapper.Map<ConviteMestreViewModel, ConviteMestre>(obj);
            BeginTransaction();
            var returnObj = _conviteMestreService.Add(topico);
            Commit();
            return Mapper.Map<ConviteMestre, ConviteMestreViewModel>(returnObj);
        }

        public ConviteMestreViewModel GetById(Guid id)
        {
            return Mapper.Map<ConviteMestre, ConviteMestreViewModel>(_conviteMestreService.GetById(id));
        }

        public IEnumerable<ConviteMestreViewModel> GetAll()
        {
            return
               Mapper.Map<IEnumerable<ConviteMestre>, IEnumerable<ConviteMestreViewModel>>(
                   _conviteMestreService.GetAll());
        }

        public ConviteMestreViewModel Update(ConviteMestreViewModel obj)
        {
            BeginTransaction();
            _conviteMestreService.Update(Mapper.Map<ConviteMestreViewModel, ConviteMestre>(obj));
            Commit();
            return obj;
        }

        public void Remove(Guid id)
        {
            BeginTransaction();
            _conviteMestreService.Remove(id);
            Commit();
        }

     
        public IEnumerable<ConviteMestreViewModel> Search(Expression<Func<ConviteMestre, bool>> func)
        {
            return
                Mapper.Map<IEnumerable<ConviteMestre>, IEnumerable<ConviteMestreViewModel>>(
                    _conviteMestreService.Search(func));
        }

        public void Detach(ConviteMestreViewModel dadosConvite)
        {
            _conviteMestreService.Detach(Mapper.Map<ConviteMestreViewModel, ConviteMestre>(dadosConvite));
        }
    }
}