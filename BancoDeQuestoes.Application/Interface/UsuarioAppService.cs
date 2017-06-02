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
    public class UsuarioAppService : ApplicationService, IUsuarioAppService
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioAppService(IUsuarioService usuarioService, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _usuarioService = usuarioService;
        }

        public void Dispose()
        {
            _usuarioService.Dispose();
        }

        public UsuarioViewModel Add(UsuarioViewModel obj)
        {
            var topico = Mapper.Map<UsuarioViewModel, Usuario>(obj);
            BeginTransaction();
            _usuarioService.Add(topico);
            Commit();
            return obj;
        }

        public UsuarioViewModel GetById(Guid id)
        {
            return Mapper.Map<Usuario, UsuarioViewModel>(_usuarioService.GetById(id));
        }

        public IEnumerable<UsuarioViewModel> GetAll()
        {
            return
                Mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(
                    _usuarioService.GetAll());
        }

        public UsuarioViewModel Update(UsuarioViewModel obj)
        {
            BeginTransaction();
            _usuarioService.Update(Mapper.Map<UsuarioViewModel, Usuario>(obj));
            Commit();
            return obj;
        }

        public void Remove(Guid id)
        {
            BeginTransaction();
            _usuarioService.Remove(id);
            Commit();
        }

        public IEnumerable<UsuarioViewModel> Search(Expression<Func<Usuario, bool>> func)
        {
            return
                Mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(
                    _usuarioService.Search(func));
        }

     

        public void DesativarLock(Guid id)
        {
            _usuarioService.DesativarLock(id);
        }
    }
}
