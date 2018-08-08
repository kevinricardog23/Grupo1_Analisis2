namespace prototipo01.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mydb.alumno")]
    public partial class alumno
    {
        internal string carnet_alumno;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public alumno()
        {
            curso_estudiante = new HashSet<curso_estudiante>();
            pago = new HashSet<pago>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int dpi_alumno { get; set; }

        [StringLength(30)]
        public string nombre_alumno { get; set; }

        [StringLength(30)]
        public string apellido_alumno { get; set; }

        [StringLength(15)]
        public string telefono_alumno { get; set; }

        [StringLength(35)]
        public string correo_alumno { get; set; }

        public int FACULTAD_id_facultad { get; set; }

        public int CARRERA_id_carrera { get; set; }

        public int edad_alumno { get; set; }

        [StringLength(45)]
        public string carnet { get; set; }

        [StringLength(45)]
        public string direccion_alumno { get; set; }

        [StringLength(45)]
        public string estado_alumno { get; set; }

        public virtual carrera carrera { get; set; }

        public virtual facultad facultad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<curso_estudiante> curso_estudiante { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pago> pago { get; set; }
    }
}
