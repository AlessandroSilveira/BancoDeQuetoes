using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repositories;
using BancoDeQuestoes.Domain.Interfaces.Services;

namespace BancoDeQuestoes.Domain.Services
{
	public class TopicoAtribuidoService : ServiceBase<TopicoAtribuido>, ITopicoAtribuidoService
	{
		public TopicoAtribuidoService(IRepositoryBase<TopicoAtribuido> repositoryBase) : base(repositoryBase)
		{
		}
	}
}