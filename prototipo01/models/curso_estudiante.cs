namespace prototipo01.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mydb.curso_estudiante")]
    public partial class curso_estudiante
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ALUMNO_dpi_alumno { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CURSO_id_curso { get; set; }

        [StringLength(45)]
        public string estado_cursoestudiante { get; set; }

        public virtual alumno alumno { get; set; }

        public virtual curso curso { get; set; }
    }
}
