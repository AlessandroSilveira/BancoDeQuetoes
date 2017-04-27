using System.Collections.Generic;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Domain.Interfaces.Repository
{
	public interface ITopicoAtribuidoRepository:IRepository<TopicoAtribuido>
	{
	    void Dispose();
		IEnumerable<TopicoAtribuido> ExecutadorDePesquisa(TopicoAtribuido form);
	}
}

