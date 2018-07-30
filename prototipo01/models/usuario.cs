namespace prototipo01.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mydb.usuario")]
    public partial class usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usuario()
        {
            bitacora = new HashSet<bitacora>();
            perfil = new HashSet<perfil>();
        }

        [Key]
        public int id_usuario { get; set; }

        [StringLength(45)]
        public string usuario_usuario { get; set; }

        [StringLength(30)]
        public string nombre_usuario { get; set; }

        [StringLength(30)]
        public string apellido_usuario { get; set; }

        [StringLength(45)]
        public string password_usuario { get; set; }

        [StringLength(35)]
        public string correo_usuario { get; set; }

        [StringLength(15)]
        public string telefono_usuario { get; set; }

        //TEST

        public int? nivel_privilegio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bitacora> bitacora { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<perfil> perfil { get; set; }
    }
}
