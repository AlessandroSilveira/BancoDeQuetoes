namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_PROVA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_PROVA()
        {
            INSCR_PROVA_CIDADE = new HashSet<INSCR_PROVA_CIDADE>();
            INSCR_PROVA_CONFIG_VALOR = new HashSet<INSCR_PROVA_CONFIG_VALOR>();
        }

        [Key]
        public int ID_PROVA { get; set; }

        public int? ID_CONCURSO { get; set; }

        public DateTime? DT_PROVA { get; set; }

        public string DESC_PROVA { get; set; }

        public int? NUM_PREVISAO_INSCRITOS_GERAL { get; set; }

        public int? NUM_PREVISAO_INSCRITOS_CIDADE { get; set; }

        [StringLength(10)]
        public string HORARIO_PROVA { get; set; }

        public int? NUM_CIDADES { get; set; }

        public int? NUM_ATIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PROVA_CIDADE> INSCR_PROVA_CIDADE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PROVA_CONFIG_VALOR> INSCR_PROVA_CONFIG_VALOR { get; set; }
    }
}
