using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using BancoDeQuestoes.Interfaces;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Repositories
{
    public class DisciplinaRepository : BaseRepository, IDisciplinaRepository
    {
        public IQueryable<INSCR_BQ_TOPICO> List()
        {
            return _db.INSCR_BQ_TOPICO.Include(i => i.INSCR_BQ_CARGO_CBO).Include(i => i.INSCR_BQ_DISCIPLINA);
        }

        public INSCR_BQ_TOPICO Find(int? id)
        {
            return _db.INSCR_BQ_TOPICO.Find(id);
        }

        public IEnumerable Cargo()
        {
            return _db.INSCR_BQ_CARGO_CBO;
        }

        public IEnumerable Area()
        {
            return _db.INSCR_BQ_DISCIPLINA;
        }

        public void Add(INSCR_BQ_TOPICO iNscrBqTopico)
        {
            _db.INSCR_BQ_TOPICO.Add(iNscrBqTopico);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }

        public DbEntityEntry<INSCR_BQ_TOPICO> Entry(INSCR_BQ_TOPICO iNscrBqTopico)
        {
            return _db.Entry(iNscrBqTopico);
        }

        public void Remove(INSCR_BQ_TOPICO iNscrBqTopico)
        {
            _db.INSCR_BQ_TOPICO.Remove(iNscrBqTopico);
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public List<INSCR_BQ_DISCIPLINA> ListaArea()
        {
            return _db.INSCR_BQ_DISCIPLINA.Where(a => a.DESC_ATIVO == "S").ToList();
        }
    }
}