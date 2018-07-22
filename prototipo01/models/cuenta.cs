namespace prototipo01.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mydb.cuenta")]
    public partial class cuenta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cuenta()
        {
            pago = new HashSet<pago>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_cuenta { get; set; }

        [StringLength(30)]
        public string nombre_cuenta { get; set; }

        public float? tipomoneda_cuenta { get; set; }

        [StringLength(45)]
        public string tipo_cuenta { get; set; }

        public float? saldo_cuenta { get; set; }

        public int BANCO_id_banco { get; set; }

        public virtual banco banco { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pago> pago { get; set; }
    }
}
