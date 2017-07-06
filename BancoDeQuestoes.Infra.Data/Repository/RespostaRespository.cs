using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Domain.Interfaces.Repository;
using BancoDeQuestoes.Infra.Data.Context;

namespace BancoDeQuestoes.Infra.Data.Repository
{
	public class RespostaRespository : RepositoryBase<Resposta>, IRespostaRepository
	{
		public RespostaRespository(Db context) : base(context)
		{
		}
	}
}
