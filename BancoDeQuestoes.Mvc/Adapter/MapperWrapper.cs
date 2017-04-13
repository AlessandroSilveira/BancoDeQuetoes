using System;
using System.Collections.Generic;
using AutoMapper;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Mvc.Adapter.Interface;
using BancoDeQuestoes.Mvc.ViewModels;

namespace BancoDeQuestoes.Mvc.Adapter
{
	public class MapperWrapper : IMapperWrapper
	{
		private IProjetoAppService _projetoAppService;

		public MapperWrapper(IProjetoAppService projetoAppService)
		{
			_projetoAppService = projetoAppService;
		}

		public object Map(Type type, Type type1, IEnumerable<Projeto> getAll)
		{
			return Mapper.Map<IEnumerable<Projeto>, IEnumerable<ProjetoViewModel>>(_projetoAppService.GetAll());
		}
	}
}