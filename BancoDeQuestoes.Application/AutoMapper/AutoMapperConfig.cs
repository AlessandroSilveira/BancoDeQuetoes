﻿using AutoMapper;
using BancoDeQuestoes.Mvc.AutoMapper;

namespace BancoDeQuestoes.Application.AutoMapper
{
	public class AutoMapperConfig
	{
		public static void RegisterMapping()
		{
			Mapper.Initialize(x =>
			{
				x.AddProfile<DomaintoviewModelMappingProfile>();
				x.AddProfile<ViewModelToDomainMappingProfile>();
			});
		}
	
	}
}