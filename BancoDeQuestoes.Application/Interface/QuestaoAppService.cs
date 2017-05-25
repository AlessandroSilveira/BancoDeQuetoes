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
    public class QuestaoAppService : ApplicationService, IQuestaoAppService
    {
        private readonly IQuestaoService _questaoService;

        public QuestaoAppService(IQuestaoService questaoService, IUnitOfWork uow) : base(uow)
        {
            _questaoService = questaoService;
        }

        public void Dispose()
        {
            _questaoService.Dispose();
        }

        public QuestaoViewModel Add(QuestaoViewModel obj)
        {
            var questao = Mapper.Map<QuestaoViewModel, Questao>(obj);
            BeginTransaction();
            _questaoService.Add(questao);
            Commit();
            return obj;
        }

        public QuestaoViewModel GetById(Guid id)
        {
            return Mapper.Map<Questao, QuestaoViewModel>(_questaoService.GetById(id));
        }

        public IEnumerable<QuestaoViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<Questao>, IEnumerable<QuestaoViewModel>>(_questaoService.GetAll());
        }

        public QuestaoViewModel Update(QuestaoViewModel obj)
        {
            BeginTransaction();
            _questaoService.Update(Mapper.Map<QuestaoViewModel, Questao>(obj));
            Commit();
            return obj;
        }

        public void Remove(Guid id)
        {
            BeginTransaction();
            _questaoService.Remove(id);
            Commit();
        }
    }
}
