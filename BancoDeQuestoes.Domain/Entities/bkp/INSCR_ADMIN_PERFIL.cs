namespace BancoDeQuestoes.Domain.Entities
{
	public  class INSCR_ADMIN_PERFIL
    {
        public int ID_ADMIN_PERFIL { get; set; }
        public int ID_ADMIN { get; set; }
        public int ID_PERFIL { get; set; }
        public int? ID_CONCURSO { get; set; }
        public string DESC_VARIAVEL { get; set; }
        public virtual INSCR_ADMIN INSCR_ADMIN { get; set; }
    }
}
