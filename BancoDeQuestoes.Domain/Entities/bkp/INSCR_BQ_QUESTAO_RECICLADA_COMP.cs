using System;

namespace BancoDeQuestoes.Domain.Entities
{
	public partial class INSCR_BQ_QUESTAO_RECICLADA_COMP
    {
        public int ID_QUESTAO_RECICLADA_COMP { get; set; }
        public int ID_QUESTAO { get; set; }
        public int ID_ADMIN { get; set; }
        public DateTime DATA_RECICLAGEM { get; set; }
        public int? ID_QUESTAO_REVISADA { get; set; }
    }
}
