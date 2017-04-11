using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repositories;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
	public class FormacaoRevisorService : ServiceBase<FormacaoRevisor>, IFormacaoRevisorService
	{

		public FormacaoRevisorService(IRepositoryBase<FormacaoRevisor> repositoryBase) : base(repositoryBase)
		{
		}
	}
}
