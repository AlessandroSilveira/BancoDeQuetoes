using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Application.Interface.Services
{
	public class AreaAppService : AppServiceBase<Area> , IAreaAppService
	{
		private IAreaService _areaService;

		public AreaAppService(IAreaService areaService):base(areaService)
		{
			_areaService = areaService;
		}
	}
}
