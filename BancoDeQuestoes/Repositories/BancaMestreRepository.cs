using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using BancoDeQuestoes.Interfaces;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Repositories
{
    public class BancaMestreRepository : BaseRepository<INSCR_BQ_BANCA> , IBancaMestreRepository
    {
        
    }
}