﻿using System.Collections;
using BancoDeQuestoes.Models;
using BancoDeQuestoes.Services;

namespace BancoDeQuestoes.Interfaces
{
    public interface IDisciplinaRepository : IBaseRepository<INSCR_BQ_TOPICO>
    {
	    IEnumerable Cargo();
	    IEnumerable Area();
		IEnumerable GetAll(INSCR_BQ_TOPICO form);
	}
}