using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Interfaces
{
    public interface IBancaMestreRepository
    {
        List<INSCR_BQ_BANCA> List();
        INSCR_BQ_BANCA Find(int? id);
        void Add(INSCR_BQ_BANCA iNscrBqBanca);
        void SaveChanges();
        DbEntityEntry<INSCR_BQ_BANCA> Entry(INSCR_BQ_BANCA iNscrBqBanca);
        void Remove(INSCR_BQ_BANCA iNscrBqBanca);
        void Dispose();
    }
}