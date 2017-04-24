using System.Collections;
using System.Collections.Generic;

namespace BancoDeQuestoes.Mvc.Controllers
{
	public class ListaFormacao 
	{
		public Dictionary<string, string> Formacoes()
		{
			var lista = new Dictionary<string, string>
			{
				{"", "Selecione"},
				{"Graduação", "Graduação"},
				{"Pós-Graduação", "Pós-Graduação"},
				{"Mestrado", "Mestrado"},
				{"Doutorado", "Doutorado"}
			};


			return lista;
		}
	}
}