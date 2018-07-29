namespace prototipo01.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mydb.seccion_curso")]
    public partial class seccion_curso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public seccion_curso()
        {
            curso_estudiante = new HashSet<curso_estudiante>();
        }

        [Key]
        public int id_seccion { get; set; }

        [StringLength(45)]
        public string seccion_seccion { get; set; }

        [StringLength(45)]
        public string estado_seccion { get; set; }

        public int? catedratico_id { get; set; }

        public int? curso_id { get; set; }

        public int? laboratorio_id { get; set; }

        public int? salon_id { get; set; }

        public int? horario_id { get; set; }

        [StringLength(45)]
        public string ciclo { get; set; }

        public virtual catedratico catedratico { get; set; }

        public virtual curso curso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<curso_estudiante> curso_estudiante { get; set; }

        public virtual horario horario { get; set; }

        public virtual laboratorio laboratorio { get; set; }

        public virtual salon salon { get; set; }
    }
}
