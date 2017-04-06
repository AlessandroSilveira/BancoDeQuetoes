using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BancoDeQuestoes.Models;
using BancoDeQuestoes.Repositories;

namespace BancoDeQuestoes.Interfaces
{
    public interface IMestreRepository : IBaseRepository<INSCR_BQ_MESTRE>
    {
       // object Include(Func<object, object> func);
        List<INSCR_BQ_MESTRE> Include();
    }
}