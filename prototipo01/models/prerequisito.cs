namespace prototipo01.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mydb.prerequisito")]
    public partial class prerequisito
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CURSO_id_curso_requisito { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CURSO_id_curso_prerequisito { get; set; }

        public int? creditos { get; set; }

        public virtual curso curso { get; set; }

        public virtual curso curso1 { get; set; }
    }
}
