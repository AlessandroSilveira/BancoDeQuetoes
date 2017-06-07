using System.Collections;
using System.Collections.Generic;

namespace BancoDeQuestoes.Mvc.Controllers
{
    public class ListaTipoPagamento
    {
        public static Dictionary<string, string> TipoPagamento()
        {
            var lista = new Dictionary<string, string>
            {
                {"", "Selecione"},
                {"Emissão de Nota", "Emissão de Nota"},
                {"R.P.A.", "R.P.A."}
            };
            return lista;
        }
    }
}