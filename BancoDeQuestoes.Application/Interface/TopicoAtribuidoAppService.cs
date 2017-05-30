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
    public class TopicoAtribuidoAppService : ApplicationService, ITopicoAtribuidoAppService
    {
        private readonly ITopicoAtribuidoService _topicoAtribuido;
        private readonly IProjetoAppService _projetoAppService;

        public TopicoAtribuidoAppService(ITopicoAtribuidoService topicoAtribuido, IProjetoAppService projetoAppService,
            IUnitOfWork uow) : base(uow)
        {
            _topicoAtribuido = topicoAtribuido;
            _projetoAppService = projetoAppService;
        }

        public void Dispose()
        {
            _topicoAtribuido.Dispose();
        }

        public TopicoAtribuidoViewModel Add(TopicoAtribuidoViewModel obj)
        {
            var topico = Mapper.Map<TopicoAtribuidoViewModel, TopicoAtribuido>(obj);
            BeginTransaction();
            _topicoAtribuido.Add(topico);
            Commit();
            return obj;
        }

        public TopicoAtribuidoViewModel GetById(Guid id)
        {
            return Mapper.Map<TopicoAtribuido, TopicoAtribuidoViewModel>(_topicoAtribuido.GetById(id));
        }

        public IEnumerable<TopicoAtribuidoViewModel> GetAll()
        {
            return
                Mapper.Map<IEnumerable<TopicoAtribuido>, IEnumerable<TopicoAtribuidoViewModel>>(
                    _topicoAtribuido.GetAll());
        }

        public TopicoAtribuidoViewModel Update(TopicoAtribuidoViewModel obj)
        {
            BeginTransaction();
            _topicoAtribuido.Update(Mapper.Map<TopicoAtribuidoViewModel, TopicoAtribuido>(obj));
            Commit();
            return obj;
        }

        public void Remove(Guid id)
        {
            BeginTransaction();
            _topicoAtribuido.Remove(id);
            Commit();
        }

        public int ObterCodigoProjeto(Guid projetoId)
        {
            var projeto = _projetoAppService.GetById(projetoId);
            return projeto.CodigoProjeto;
        }

        public IEnumerable<TopicoAtribuidoViewModel> Search(Expression<Func<TopicoAtribuido, bool>> func)
        {
            return
                Mapper.Map<IEnumerable<TopicoAtribuido>, IEnumerable<TopicoAtribuidoViewModel>>(
                    _topicoAtribuido.Search(func));
        }
    }
}