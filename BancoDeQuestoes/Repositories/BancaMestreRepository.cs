using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using BancoDeQuestoes.Interfaces;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Repositories
{
    public class BancaMestreRepository : BaseRepository , IBancaMestreRepository
    {
        public List<INSCR_BQ_BANCA> List()
        {
           return _db.INSCR_BQ_BANCA.ToList();
        }

        public INSCR_BQ_BANCA Find(int? id)
        {
            return _db.INSCR_BQ_BANCA.Find(id);

        }

        public void Add(INSCR_BQ_BANCA iNscrBqBanca)
        {
            _db.INSCR_BQ_BANCA.Add(iNscrBqBanca);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }

        public DbEntityEntry<INSCR_BQ_BANCA> Entry(INSCR_BQ_BANCA iNscrBqBanca)
        {
            return _db.Entry(iNscrBqBanca);
        }

        public void Remove(INSCR_BQ_BANCA iNscrBqBanca)
        {
            _db.INSCR_BQ_BANCA.Remove(iNscrBqBanca);
        }

        public void Dispose()
        {
           _db.Dispose();
        }
    }
}