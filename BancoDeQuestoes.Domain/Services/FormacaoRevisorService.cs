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
	public class FormacaoRevisorService : ServiceBase<RevisorFormacao>, IFormacaoRevisorService
	{

		public FormacaoRevisorService(IRepositoryBase<RevisorFormacao> repositoryBase) : base(repositoryBase)
		{
		}
	}
}
