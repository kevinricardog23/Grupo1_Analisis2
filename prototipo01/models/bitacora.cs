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
        public int id_bitacora { get; set; }

        public DateTime? fecha_hora_bitacora { get; set; }

        [StringLength(45)]
        public string accionusario_bitacora { get; set; }

        public int usuario_id_usuario { get; set; }

        public virtual usuario usuario { get; set; }
    }
}
