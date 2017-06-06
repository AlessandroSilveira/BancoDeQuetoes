using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
    public class ConviteMestreService : IConviteMestreRepository, IConviteMestreService
    {


        private readonly IConviteMestreRepository _conviteMestreRepository;

        public ConviteMestreService(IConviteMestreRepository conviteMestreRepository)
        {
            _conviteMestreRepository = conviteMestreRepository;
        }


        public ConviteMestre Add(ConviteMestre obj)
        {
           return _conviteMestreRepository.Add(obj);
        }

        public void Dispose()
        {
           _conviteMestreRepository.Dispose();
        }

        public IEnumerable<ConviteMestre> GetAll()
        {
            return _conviteMestreRepository.GetAll();
        }

        public ConviteMestre GetById(Guid id)
        {
            return _conviteMestreRepository.GetById(id);
        }

        public void Remove(Guid id)
        {
             _conviteMestreRepository.Remove(id);
        }

        public int SaveChanges()
        {
            return _conviteMestreRepository.SaveChanges();
        }

        public IEnumerable<ConviteMestre> Search(Expression<Func<ConviteMestre, bool>> predicate)
        {
            return _conviteMestreRepository.Search(predicate);
        }

        public ConviteMestre Update(ConviteMestre obj)
        {
            return _conviteMestreRepository.Update(obj);
        }

        public void Detach(ConviteMestre dadosConvite)
        {
            _conviteMestreRepository.Detach(dadosConvite);
        }
    }
}