﻿using System;
using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Services
{
	public interface IQuestaoService : IDisposable
	{
		Questao Add(Questao obj);
		Questao GetById(Guid id);
		IEnumerable<Questao> GetAll();
		Questao Update(Questao obj);
		void Remove(Guid id);
	}
}