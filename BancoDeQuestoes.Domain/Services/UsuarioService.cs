using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
    public class UsuarioService : IUsuarioService
    {

        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public void Dispose()
        {
            _usuarioRepository.Dispose();
        }

        public Usuario Add(Usuario obj)
        {
           return _usuarioRepository.Add(obj);
        }

        public Usuario GetById(Guid id)
        {
            return _usuarioRepository.GetById(id);
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _usuarioRepository.GetAll();
        }

        public Usuario Update(Usuario obj)
        {
            return _usuarioRepository.Update(obj);
        }

        public void Remove(Guid id)
        {
            _usuarioRepository.Remove(id);
        }

        public IEnumerable<Usuario> Search(Expression<Func<Usuario, bool>> func)
        {
            return _usuarioRepository.Search(func);
        }

        public void DesativarLock(Guid id)
        {
            _usuarioRepository.DesativarLock(id);
        }
    }
}