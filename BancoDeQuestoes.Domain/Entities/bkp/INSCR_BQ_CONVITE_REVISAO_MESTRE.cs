using System;
using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Domain.Entities
{
	public class INSCR_BQ_CONVITE_REVISAO_MESTRE
    {
        public int ID_CONVITE_REVISAO_MESTRE { get; set; }
        public int ID_MESTRE { get; set; }
        public int? ID_QUESTAO { get; set; }
        public int? DESC_ACEITE { get; set; }
        public DateTime? DATA_ACEITE { get; set; }
        public virtual INSCR_BQ_MESTRE INSCR_BQ_MESTRE { get; set; }
        public virtual INSCR_BQ_QUESTAO INSCR_BQ_QUESTAO { get; set; }
    }
}
