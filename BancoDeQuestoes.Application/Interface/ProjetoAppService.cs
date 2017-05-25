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
    public class ProjetoAppService : ApplicationService, IProjetoAppService
    {
        private readonly IProjetoService _projetoService;

        public ProjetoAppService(IProjetoService projetoService, IUnitOfWork uow) : base(uow)
        {
            _projetoService = projetoService;
        }

        public void Dispose()
        {
            _projetoService.Dispose();
        }

        public ProjetoViewModel Add(ProjetoViewModel obj)
        {
            var projeto = Mapper.Map<ProjetoViewModel, Projeto>(obj);
            BeginTransaction();
            _projetoService.Add(projeto);
            Commit();
            return obj;
        }

        public ProjetoViewModel GetById(Guid id)
        {
            return Mapper.Map<Projeto, ProjetoViewModel>(_projetoService.GetById(id));
        }

        public IEnumerable<ProjetoViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<Projeto>, IEnumerable<ProjetoViewModel>>(_projetoService.GetAll());
        }

        public ProjetoViewModel Update(ProjetoViewModel obj)
        {
            BeginTransaction();
            _projetoService.Update(Mapper.Map<ProjetoViewModel, Projeto>(obj));
            Commit();
            return obj;
        }

        public void Remove(Guid id)
        {
            BeginTransaction();
            _projetoService.Remove(id);
            Commit();
        }
    }
}
