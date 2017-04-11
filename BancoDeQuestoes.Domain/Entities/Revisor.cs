

namespace BancoDeQuestoes.Domain.Entities
{
	public  class Revisor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Revisor()
        {
            //INSCR_BQ_CONVITE_REVISOR = new HashSet<INSCR_BQ_CONVITE_REVISOR>();
            //INSCR_BQ_QUESTAO_RECICLAR_REVISOR = new HashSet<INSCR_BQ_QUESTAO_RECICLAR_REVISOR>();
            //INSCR_BQ_QUESTAO_REVISADA = new HashSet<INSCR_BQ_QUESTAO_REVISADA>();
            //INSCR_BQ_QUESTAO_REVISOR = new HashSet<INSCR_BQ_QUESTAO_REVISOR>();
            //INSCR_BQ_RESPOSTA_REVISADA = new HashSet<INSCR_BQ_RESPOSTA_REVISADA>();
        }

       
        public int RevisorId { get; set; }
		public string Nome { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string EmailSecundario { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Senha { get; set; }
        public int AreaId { get; set; }
        public bool Ativo { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<INSCR_BQ_CONVITE_REVISOR> INSCR_BQ_CONVITE_REVISOR { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<INSCR_BQ_QUESTAO_RECICLAR_REVISOR> INSCR_BQ_QUESTAO_RECICLAR_REVISOR { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<INSCR_BQ_QUESTAO_REVISADA> INSCR_BQ_QUESTAO_REVISADA { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<INSCR_BQ_QUESTAO_REVISOR> INSCR_BQ_QUESTAO_REVISOR { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<INSCR_BQ_RESPOSTA_REVISADA> INSCR_BQ_RESPOSTA_REVISADA { get; set; }
    }
}
