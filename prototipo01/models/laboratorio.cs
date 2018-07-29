namespace prototipo01.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mydb.laboratorio")]
    public partial class laboratorio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public laboratorio()
        {
            seccion_curso = new HashSet<seccion_curso>();
        }

        [Key]
        public int id_laboratorio { get; set; }

        [StringLength(45)]
        public string descripcion_laboratorio { get; set; }

        public int CATEDRATICO_dpi_catedratico { get; set; }

        public int HORARIO_id_horario { get; set; }

        public int SALON_id_salon { get; set; }

        public virtual catedratico catedratico { get; set; }

        public virtual horario horario { get; set; }

        public virtual salon salon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<seccion_curso> seccion_curso { get; set; }
    }
}
