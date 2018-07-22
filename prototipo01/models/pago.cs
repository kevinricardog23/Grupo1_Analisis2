namespace prototipo01.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mydb.pago")]
    public partial class pago
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_pago { get; set; }

        [StringLength(45)]
        public string tipo_pago { get; set; }

        public int CUENTA_id_cuenta { get; set; }

        public int ALUMNO_dpi_alumno { get; set; }

        public float? monto_pago { get; set; }

        public virtual alumno alumno { get; set; }

        public virtual cuenta cuenta { get; set; }
    }
}
