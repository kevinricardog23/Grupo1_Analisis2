namespace prototipo01.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mydb.curso")]
    public partial class curso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public curso()
        {
            curso_estudiante = new HashSet<curso_estudiante>();
            catedratico = new HashSet<catedratico>();
            curso1 = new HashSet<curso>();
            curso2 = new HashSet<curso>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_curso { get; set; }

        [StringLength(30)]
        public string nombre_curso { get; set; }

        public int PENSUM_id_pensum { get; set; }

        public int LABORATORIO_id_laboratorio { get; set; }

        public int SECCION_id_seccion { get; set; }

        public int SALON_id_salon { get; set; }

        public int HORARIO_id_horario { get; set; }

        [StringLength(45)]
        public string ciclo_curso { get; set; }

        [StringLength(45)]
        public string semestre_curso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<curso_estudiante> curso_estudiante { get; set; }

        public virtual horario horario { get; set; }

        public virtual laboratorio laboratorio { get; set; }

        public virtual pensum pensum { get; set; }

        public virtual salon salon { get; set; }

        public virtual seccion seccion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<catedratico> catedratico { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<curso> curso1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<curso> curso2 { get; set; }
    }
}
