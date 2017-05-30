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
    public class DisciplinaAppService : ApplicationService, IDisciplinaAppService
    {
        private readonly IDisciplinaService _disciplinaService;

        public DisciplinaAppService(IDisciplinaService disciplinaService, IUnitOfWork uow) : base(uow)
        {
            _disciplinaService = disciplinaService;
        }

        public DisciplinaViewModel Add(DisciplinaViewModel obj)
        {
            var disciplina = Mapper.Map<DisciplinaViewModel, Disciplina>(obj);
            BeginTransaction();
            _disciplinaService.Add(disciplina);
            Commit();
            return obj;
        }

        public DisciplinaViewModel GetById(Guid id)
        {
            return Mapper.Map<Disciplina, DisciplinaViewModel>(_disciplinaService.GetById(id));
        }

        public IEnumerable<DisciplinaViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<Disciplina>, IEnumerable<DisciplinaViewModel>>(_disciplinaService.GetAll());
        }

        public DisciplinaViewModel Update(DisciplinaViewModel obj)
        {
            BeginTransaction();
            _disciplinaService.Update(Mapper.Map<DisciplinaViewModel, Disciplina>(obj));
            Commit();
            return obj;
        }

        public void Remove(Guid id)
        {
            BeginTransaction();
            _disciplinaService.Remove(id);
            Commit();
        }

        public void Dispose()
        {
            _disciplinaService.Dispose();
        }

        public IEnumerable<DisciplinaViewModel> ResultadoPesquisaDisciplina(DisciplinaViewModel form)
        {
            var disciplina = Mapper.Map<DisciplinaViewModel, Disciplina>(form);

            return
                Mapper.Map<IEnumerable<Disciplina>, IEnumerable<DisciplinaViewModel>>(
                    _disciplinaService.ResultadoPesquisaDisciplina(disciplina));
        }

        public IEnumerable<DisciplinaViewModel> ResultadoPesquisaDisciplinaAtribuicao(DisciplinaViewModel form)
        {
            var disciplina = Mapper.Map<DisciplinaViewModel, Disciplina>(form);
            return
                Mapper.Map<IEnumerable<Disciplina>, IEnumerable<DisciplinaViewModel>>(
                    _disciplinaService.ResultadoPesquisaDisciplinaAtribuicao(disciplina));
        }
    }
}
