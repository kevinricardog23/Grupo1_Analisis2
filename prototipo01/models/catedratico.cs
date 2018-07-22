namespace prototipo01.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mydb.catedratico")]
    public partial class catedratico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public catedratico()
        {
            laboratorio = new HashSet<laboratorio>();
            curso = new HashSet<curso>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int dpi_catedratico { get; set; }

        [StringLength(30)]
        public string nombre_catedratico { get; set; }

        [StringLength(30)]
        public string apellido_catedratico { get; set; }

        [StringLength(15)]
        public string telefono_catedratico { get; set; }

        [StringLength(35)]
        public string correo_catedratico { get; set; }

        public int? edad_catedratico { get; set; }

        [StringLength(45)]
        public string direccion_catedratico { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<laboratorio> laboratorio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<curso> curso { get; set; }
    }
}
