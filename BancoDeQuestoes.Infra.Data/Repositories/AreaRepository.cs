﻿using System;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repositories;


namespace BancoDeQuestoes.Infra.Data.Repositories
{
	public class AreaRepository : BaseRepository<Area>, IAreaRepository
	{
		public void Dispose()
		{
			throw new NotImplementedException();
		}
	}
}