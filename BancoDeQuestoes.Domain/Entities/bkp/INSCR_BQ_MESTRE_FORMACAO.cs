namespace BancoDeQuestoes.Domain.Entities
{
	public class INSCR_BQ_MESTRE_FORMACAO
	{
		public int ID_MESTRE_FORMACAO { get; set; }
		public int ID_MESTRE { get; set; }
		public string DESC_TIPO_FORMACAO { get; set; }
		public string DESC_CURSO { get; set; }
		public string DESC_INSTITUICAO { get; set; }
		public bool DESC_COPIA_DIPLOMA { get; set; }
		public bool DESC_DIPLOMA_AUTENTICADO { get; set; }
		public int DESC_NUMERO_COPIAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual INSCR_BQ_MESTRE INSCR_BQ_MESTRE { get; set; }
    }
}