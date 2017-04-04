namespace BancoDeQuestoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSCR_RESULTADO_CAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSCR_RESULTADO_CAD()
        {
            INSCR_RESULTADO_CAD_ADMIN = new HashSet<INSCR_RESULTADO_CAD_ADMIN>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_RESULTADO_CAD { get; set; }

        public int ID_RESULTADO { get; set; }

        public int ID_CONCURSO { get; set; }

        public int RG_CAD { get; set; }

        [StringLength(150)]
        public string DESC_IMAGEM { get; set; }

        [Required]
        [StringLength(50)]
        public string DESC_STATUS { get; set; }

        [StringLength(50)]
        public string DESC_NOTA01 { get; set; }

        [StringLength(50)]
        public string DESC_NOTA02 { get; set; }

        [StringLength(50)]
        public string DESC_NOTA03 { get; set; }

        [StringLength(50)]
        public string DESC_NOTA04 { get; set; }

        [StringLength(50)]
        public string DESC_NOTA05 { get; set; }

        [StringLength(50)]
        public string DESC_NOTA06 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA07 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA08 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA09 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA10 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA11 { get; set; }

        [StringLength(50)]
        public string DESC_NOTA12 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA13 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA14 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA15 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA16 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA17 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA18 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA19 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA20 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA21 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA22 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA23 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA24 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA25 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA26 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA27 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA28 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA29 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA30 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA31 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA32 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA33 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA34 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA35 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA36 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA37 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA38 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA39 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA40 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA41 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA42 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA43 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA44 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA45 { get; set; }

        [StringLength(50)]
        public string DESC_NOTA46 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA47 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA48 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA49 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA50 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA51 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA52 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA53 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA54 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA55 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA56 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA57 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA58 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA59 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA60 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA61 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA62 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA63 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA64 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA65 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA66 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA67 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA68 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA69 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA70 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA71 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA72 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA73 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA74 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA75 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA76 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA77 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA78 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA79 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA80 { get; set; }

        [StringLength(10)]
        public string DESC_NOTA81 { get; set; }

        [StringLength(50)]
        public string DESC_NOTA82 { get; set; }

        [StringLength(50)]
        public string DESC_NOTA83 { get; set; }

        [StringLength(50)]
        public string DESC_NOTA84 { get; set; }

        [StringLength(50)]
        public string DESC_NOTA85 { get; set; }

        [StringLength(50)]
        public string DESC_NOTA86 { get; set; }

        [StringLength(50)]
        public string DESC_NOTA87 { get; set; }

        [StringLength(50)]
        public string DESC_NOTA88 { get; set; }

        [StringLength(50)]
        public string DESC_NOTA89 { get; set; }

        [StringLength(50)]
        public string DESC_NOTA90 { get; set; }

        [StringLength(50)]
        public string DESC_NOTA91 { get; set; }

        public virtual INSCR_CAD INSCR_CAD { get; set; }

        public virtual INSCR_RESULTADO INSCR_RESULTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCR_RESULTADO_CAD_ADMIN> INSCR_RESULTADO_CAD_ADMIN { get; set; }
    }
}
