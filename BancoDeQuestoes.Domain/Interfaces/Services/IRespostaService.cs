using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Services
{
	public interface IRespostaService : IDisposable
	{
		Resposta Add(Resposta obj);
		Resposta GetById(Guid id);
		IEnumerable<Resposta> GetAll();
		Resposta Update(Resposta obj);
		void Remove(Guid id);
		IEnumerable<Resposta> Search(Expression<Func<Resposta, bool>> func);
	}
}
