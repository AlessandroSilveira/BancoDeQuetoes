

namespace BancoDeQuestoes.Domain.Entities
{
    public partial class INSCR_BQ_QUESTAO_PROJETO
    {
        public int ID_QUESTAO_PROJETO { get; set; }
        public int ID_QUESTAO_REVISADA { get; set; }
        public int ID_PROJETO { get; set; }
        public virtual Projeto Projeto { get; set; }
        public virtual INSCR_BQ_QUESTAO_REVISADA INSCR_BQ_QUESTAO_REVISADA { get; set; }
    }
}
