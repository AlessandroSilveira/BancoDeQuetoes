﻿using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Repository
{
	public interface IItemPesquisaTopico
	{
		List<Disciplina> Pesquisa(Disciplina form, List<Disciplina> sql);
		IItemPesquisaTopico Proximo { get; set; }
	}
}
