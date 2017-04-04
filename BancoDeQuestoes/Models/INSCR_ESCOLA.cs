namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_ESCOLA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_ESCOLA()
        {
            INSCR_COORDENADOR_ESCOLA = new HashSet<INSCR_COORDENADOR_ESCOLA>();
            INSCR_ESCOLA_SALA = new HashSet<INSCR_ESCOLA_SALA>();
            INSCR_PROVA_ESCOLA = new HashSet<INSCR_PROVA_ESCOLA>();
            INSCR_PROVA_ESCOLA_MAPA = new HashSet<INSCR_PROVA_ESCOLA_MAPA>();
        }

        [Key]
        public int ID_ESCOLA { get; set; }

        public int ID_COORDENADOR { get; set; }

        [StringLength(250)]
        public string DESC_RAZAO { get; set; }

        [StringLength(250)]
        public string DESC_NOME { get; set; }

        [StringLength(50)]
        public string DESC_CNPJ { get; set; }

        [StringLength(100)]
        public string DESC_TIPO_LOGRADOURO { get; set; }

        public string DESC_ENDERECO { get; set; }

        [StringLength(10)]
        public string DESC_NUMERO { get; set; }

        [StringLength(250)]
        public string DESC_COMPL { get; set; }

        [StringLength(250)]
        public string DESC_BAIRRO { get; set; }

        [StringLength(10)]
        public string DESC_CEP { get; set; }

        [StringLength(250)]
        public string DESC_CIDADE { get; set; }

        [StringLength(2)]
        public string DESC_UF { get; set; }

        [StringLength(20)]
        public string DESC_TIPO_TELEFONE1 { get; set; }

        [StringLength(2)]
        public string DESC_DDD1 { get; set; }

        [StringLength(10)]
        public string DESC_TELEFONE1 { get; set; }

        [StringLength(20)]
        public string DESC_TIPO_TELEFONE2 { get; set; }

        [StringLength(2)]
        public string DESC_DDD2 { get; set; }

        [StringLength(10)]
        public string DESC_TELEFONE2 { get; set; }

        [StringLength(50)]
        public string DESC_RESPONSAVEL { get; set; }

        [StringLength(50)]
        public string DESC_RESPONSAVEL_CARGO { get; set; }

        [StringLength(50)]
        public string DESC_EMAIL { get; set; }

        [StringLength(1)]
        public string DESC_TEM_ACESSIBILIDADE { get; set; }

        public int? NUM_QUANT_BAN_MASC { get; set; }

        public int? NUM_QUANT_BAN_FEM { get; set; }

        [StringLength(10)]
        public string DESC_RAMPA { get; set; }

        [StringLength(1)]
        public string DESC_ELEVADOR { get; set; }

        public DateTime? DT_CADASTRO { get; set; }

        public int? NUM_ATIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_COORDENADOR_ESCOLA> INSCR_COORDENADOR_ESCOLA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_ESCOLA_SALA> INSCR_ESCOLA_SALA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PROVA_ESCOLA> INSCR_PROVA_ESCOLA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_PROVA_ESCOLA_MAPA> INSCR_PROVA_ESCOLA_MAPA { get; set; }
    }
}
