using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Interfaces
{
    public interface IDisciplinaRepository
    {
        IQueryable<INSCR_BQ_TOPICO> List();
        INSCR_BQ_TOPICO Find(int? id);
        IEnumerable Cargo();
        IEnumerable Area();
        void Add(INSCR_BQ_TOPICO iNscrBqTopico);
        void SaveChanges();
        DbEntityEntry<INSCR_BQ_TOPICO> Entry(INSCR_BQ_TOPICO iNscrBqTopico);
        void Remove(INSCR_BQ_TOPICO iNscrBqTopico);
        void Dispose();
        List<INSCR_BQ_DISCIPLINA> ListaArea();
        object ObterPesquisaDisciplina(object form);
    }
}