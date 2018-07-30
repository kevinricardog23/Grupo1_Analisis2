namespace prototipo01.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mydb.curso")]
    public partial class curso_model
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public curso_model()
        {
            seccion_curso = new HashSet<seccion_curso>();
            prerequisito = new HashSet<prerequisito>();
            prerequisito1 = new HashSet<prerequisito>();
        }

        [Key]
        public int id_curso { get; set; }

        [StringLength(30)]
        public string nombre_curso { get; set; }

        public int PENSUM_id_pensum { get; set; }

        [StringLength(45)]
        public string semestre_curso { get; set; }

        public int? creditos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<seccion_curso> seccion_curso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prerequisito> prerequisito { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prerequisito> prerequisito1 { get; set; }

        public virtual pensum pensum { get; set; }
    }
}
