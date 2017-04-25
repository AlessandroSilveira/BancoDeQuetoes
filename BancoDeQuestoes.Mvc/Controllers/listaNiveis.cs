using System.Collections;
using System.Collections.Generic;

namespace BancoDeQuestoes.Mvc.Controllers
{
	public class ListaNiveis
	{
		public Dictionary<string, string> Niveis()
		{
			var lista = new Dictionary<string, string>
			{
				{"", "Selecione"},
				{"Alta Complexidade", "Alta Complexidade"},
				{"Média Complexidade", "Média Complexidade"},
				{"Baixa Complexidade", "Baixa Complexidade"}
			};


			return lista;
		}
	}
}