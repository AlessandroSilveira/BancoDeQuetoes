using BancoDeQuestoes.Models;

namespace BancoDeQuestoes.Domain.Entities
{
    public  class INSCR_BQ_TOP_DISC_CARGO
    {
        public int ID_TOP_DISC_CARGO { get; set; }
        public int ID_TOPICO { get; set; }
        public int ID_DISCIPLINA { get; set; }
        public int ID_CARGO { get; set; }
        public int ID_PROJETO { get; set; }
        public int COD_PROJETO { get; set; }
        public string DESC_STATUS { get; set; }
        public virtual INSCR_BQ_CARGO_CBO INSCR_BQ_CARGO_CBO { get; set; }
        public virtual INSCR_BQ_DISCIPLINA INSCR_BQ_DISCIPLINA { get; set; }
        public virtual Projeto Projeto { get; set; }
        public virtual Disciplina Disciplina { get; set; }
    }
}
