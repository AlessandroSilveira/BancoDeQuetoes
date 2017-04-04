namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_BANCO_BAIXA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_BANCO_BAIXA()
        {
            INSCR_INSTBOLETO = new HashSet<INSCR_INSTBOLETO>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_BANCO_BAIXA { get; set; }

        [Required]
        [StringLength(50)]
        public string DESC_BANCO_BAIXA { get; set; }

        public int NUM_FIXO_POSICAO { get; set; }

        [Required]
        [StringLength(50)]
        public string DESC_FIXO_CORINGA { get; set; }

        public int NUM_POSICAO_INSCRICAO { get; set; }

        public int NUM_TAMANHO_INSCRICAO { get; set; }

        public int NUM_POSICAO_VALOR { get; set; }

        public int NUM_TAMANHO_VALOR { get; set; }

        [Required]
        [StringLength(1)]
        public string DESC_ATIVO { get; set; }

        public int? NUM_POSICAO_CPF { get; set; }

        [StringLength(11)]
        public string NUM_TAMANHO_CPF { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_INSTBOLETO> INSCR_INSTBOLETO { get; set; }
    }
}
