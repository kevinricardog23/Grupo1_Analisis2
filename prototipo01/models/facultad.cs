namespace prototipo01.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mydb.facultad")]
    public partial class facultad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public facultad()
        {
            alumno = new HashSet<alumno>();
            carrera = new HashSet<carrera>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_facultad { get; set; }

        [StringLength(30)]
        public string nombre_facultad { get; set; }

        [StringLength(45)]
        public string direccion_facultad { get; set; }

        [StringLength(15)]
        public string telefono_facultad { get; set; }

        [StringLength(35)]
        public string correo_facultad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<alumno> alumno { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<carrera> carrera { get; set; }
    }
}
