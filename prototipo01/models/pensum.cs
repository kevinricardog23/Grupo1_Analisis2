namespace prototipo01.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mydb.pensum")]
    public partial class pensum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pensum()
        {
            curso = new HashSet<curso_model>();
        }

        [Key]
        public int id_pensum { get; set; }

        public int CARRERA_id_carrera { get; set; }

        [StringLength(45)]
        public string nombre { get; set; }

        public virtual carrera carrera { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<curso_model> curso { get; set; }
    }
}
