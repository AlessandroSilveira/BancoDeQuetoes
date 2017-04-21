using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Infra.Data.Repositories;
using AutoMapper;

namespace BancoDeQuestoes.Application.Interface.Services
{

    public class BancaAppService : IBancaAppService
    {

        private readonly BancaRepository _bancaRepository;

        public BancaAppService(BancaRepository bancaRepository)
        {
            _bancaRepository = bancaRepository;
        }

        public BancaViewModel Add(BancaViewModel obj)
        {
            var banca = Mapper.Map<BancaViewModel, Banca>(obj);
            _bancaRepository.Add(banca);
            return obj;
        }

        public IEnumerable<BancaViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<Banca>, IEnumerable<BancaViewModel>>(_bancaRepository.GetAll());
        }

        public BancaViewModel GetById(Guid id)
        {
            return Mapper.Map<Banca, BancaViewModel>(_bancaRepository.GetById(id));
        }

        public void Remove(Guid id)
        {
            _bancaRepository.Remove(id);
        }

        public int SaveChanges()
        {
            return _bancaRepository.SaveChanges();
        }

        public IEnumerable<BancaViewModel> Search(Expression<Func<BancaViewModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public BancaViewModel Update(BancaViewModel obj)
        {
            _bancaRepository.Update(Mapper.Map<BancaViewModel, Banca>(obj));
            return obj;
        }

         
        public void Dispose()
        {
            _bancaRepository.Dispose();
        }      
    }
}
