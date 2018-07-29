namespace prototipo01.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mydb.salon")]
    public partial class salon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public salon()
        {
            laboratorio = new HashSet<laboratorio>();
            seccion_curso = new HashSet<seccion_curso>();
        }

        [Key]
        public int id_salon { get; set; }

        [StringLength(45)]
        public string capacidad_salon { get; set; }

        public int EDIFICIO_id_edificio { get; set; }

        [StringLength(45)]
        public string nombre_salon { get; set; }

        public virtual edificio edificio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<laboratorio> laboratorio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<seccion_curso> seccion_curso { get; set; }
    }
}
