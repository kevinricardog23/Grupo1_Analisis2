namespace prototipo01.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mydb.bitacora")]
    public partial class bitacora
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_bitacora { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fecha_bitacora { get; set; }

        public TimeSpan? hora_bitacora { get; set; }

        [StringLength(45)]
        public string accionusario_bitacora { get; set; }

        [StringLength(45)]
        public string resultado_bitacora { get; set; }

        [StringLength(45)]
        public string error_bitacora { get; set; }

        [StringLength(45)]
        public string ippc_bitacora { get; set; }

        public int USUARIO_id_usuario { get; set; }

        public virtual usuario usuario { get; set; }
    }
}
