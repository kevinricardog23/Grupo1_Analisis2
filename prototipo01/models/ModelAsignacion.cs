namespace prototipo01.models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelAsignacion : DbContext
    {
        public ModelAsignacion()
            : base("name=ModelAsignacion")
        {
        }

        public virtual DbSet<alumno> alumno { get; set; }
        public virtual DbSet<banco> banco { get; set; }
        public virtual DbSet<bitacora> bitacora { get; set; }
        public virtual DbSet<carrera> carrera { get; set; }
        public virtual DbSet<catedratico> catedratico { get; set; }
        public virtual DbSet<cuenta> cuenta { get; set; }
        public virtual DbSet<curso_model> curso { get; set; }
        public virtual DbSet<curso_estudiante> curso_estudiante { get; set; }
        public virtual DbSet<edificio> edificio { get; set; }
        public virtual DbSet<facultad> facultad { get; set; }
        public virtual DbSet<horario> horario { get; set; }
        public virtual DbSet<laboratorio> laboratorio { get; set; }
        public virtual DbSet<pago> pago { get; set; }
        public virtual DbSet<pensum> pensum { get; set; }
        public virtual DbSet<perfil> perfil { get; set; }
        public virtual DbSet<prerequisito> prerequisito { get; set; }
        public virtual DbSet<salon> salon { get; set; }
        public virtual DbSet<seccion_curso> seccion_curso { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<alumno>()
                .Property(e => e.nombre_alumno)
                .IsUnicode(false);

            modelBuilder.Entity<alumno>()
                .Property(e => e.apellido_alumno)
                .IsUnicode(false);

            modelBuilder.Entity<alumno>()
                .Property(e => e.telefono_alumno)
                .IsUnicode(false);

            modelBuilder.Entity<alumno>()
                .Property(e => e.correo_alumno)
                .IsUnicode(false);

            modelBuilder.Entity<alumno>()
                .Property(e => e.direccion_alumno)
                .IsUnicode(false);

            modelBuilder.Entity<alumno>()
                .Property(e => e.estado_alumno)
                .IsUnicode(false);

            modelBuilder.Entity<alumno>()
                .HasMany(e => e.curso_estudiante)
                .WithRequired(e => e.alumno)
                .HasForeignKey(e => e.ALUMNO_dpi_alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<alumno>()
                .HasMany(e => e.pago)
                .WithRequired(e => e.alumno)
                .HasForeignKey(e => e.ALUMNO_dpi_alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<banco>()
                .Property(e => e.nombre_banco)
                .IsUnicode(false);

            modelBuilder.Entity<banco>()
                .Property(e => e.direccion_banco)
                .IsUnicode(false);

            modelBuilder.Entity<banco>()
                .Property(e => e.telefono_banco)
                .IsUnicode(false);

            modelBuilder.Entity<banco>()
                .HasMany(e => e.cuenta)
                .WithRequired(e => e.banco)
                .HasForeignKey(e => e.BANCO_id_banco)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<bitacora>()
                .Property(e => e.accionusario_bitacora)
                .IsUnicode(false);

            modelBuilder.Entity<carrera>()
                .Property(e => e.nombre_carrera)
                .IsUnicode(false);

            modelBuilder.Entity<carrera>()
                .Property(e => e.jornada_carrera)
                .IsUnicode(false);

            modelBuilder.Entity<carrera>()
                .HasMany(e => e.alumno)
                .WithRequired(e => e.carrera)
                .HasForeignKey(e => e.CARRERA_id_carrera)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<carrera>()
                .HasMany(e => e.pensum)
                .WithRequired(e => e.carrera)
                .HasForeignKey(e => e.CARRERA_id_carrera)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<catedratico>()
                .Property(e => e.nombre_catedratico)
                .IsUnicode(false);

            modelBuilder.Entity<catedratico>()
                .Property(e => e.apellido_catedratico)
                .IsUnicode(false);

            modelBuilder.Entity<catedratico>()
                .Property(e => e.telefono_catedratico)
                .IsUnicode(false);

            modelBuilder.Entity<catedratico>()
                .Property(e => e.correo_catedratico)
                .IsUnicode(false);

            modelBuilder.Entity<catedratico>()
                .Property(e => e.direccion_catedratico)
                .IsUnicode(false);

            modelBuilder.Entity<catedratico>()
                .HasMany(e => e.seccion_curso)
                .WithOptional(e => e.catedratico)
                .HasForeignKey(e => e.catedratico_id);

            modelBuilder.Entity<catedratico>()
                .HasMany(e => e.laboratorio)
                .WithRequired(e => e.catedratico)
                .HasForeignKey(e => e.CATEDRATICO_dpi_catedratico)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cuenta>()
                .Property(e => e.nombre_cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<cuenta>()
                .Property(e => e.tipo_cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<cuenta>()
                .HasMany(e => e.pago)
                .WithRequired(e => e.cuenta)
                .HasForeignKey(e => e.CUENTA_id_cuenta)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<curso_model>()
                .Property(e => e.nombre_curso)
                .IsUnicode(false);

            modelBuilder.Entity<curso_model>()
                .Property(e => e.semestre_curso)
                .IsUnicode(false);

            modelBuilder.Entity<curso_model>()
                .HasMany(e => e.seccion_curso)
                .WithOptional(e => e.curso)
                .HasForeignKey(e => e.curso_id);

            modelBuilder.Entity<curso_model>()
                .HasMany(e => e.prerequisito)
                .WithRequired(e => e.curso)
                .HasForeignKey(e => e.CURSO_id_curso_requisito)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<curso_model>()
                .HasMany(e => e.prerequisito1)
                .WithRequired(e => e.curso1)
                .HasForeignKey(e => e.CURSO_id_curso_prerequisito)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<curso_estudiante>()
                .Property(e => e.estado_cursoestudiante)
                .IsUnicode(false);

            modelBuilder.Entity<edificio>()
                .Property(e => e.nombre_edificio)
                .IsUnicode(false);

            modelBuilder.Entity<edificio>()
                .Property(e => e.ubicacion_edificio)
                .IsUnicode(false);

            modelBuilder.Entity<edificio>()
                .HasMany(e => e.salon)
                .WithRequired(e => e.edificio)
                .HasForeignKey(e => e.EDIFICIO_id_edificio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<facultad>()
                .Property(e => e.nombre_facultad)
                .IsUnicode(false);

            modelBuilder.Entity<facultad>()
                .Property(e => e.direccion_facultad)
                .IsUnicode(false);

            modelBuilder.Entity<facultad>()
                .Property(e => e.telefono_facultad)
                .IsUnicode(false);

            modelBuilder.Entity<facultad>()
                .Property(e => e.correo_facultad)
                .IsUnicode(false);

            modelBuilder.Entity<facultad>()
                .HasMany(e => e.alumno)
                .WithRequired(e => e.facultad)
                .HasForeignKey(e => e.FACULTAD_id_facultad)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<facultad>()
                .HasMany(e => e.carrera)
                .WithRequired(e => e.facultad)
                .HasForeignKey(e => e.FACULTAD_id_facultad)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<horario>()
                .Property(e => e.horario_horario)
                .IsUnicode(false);

            modelBuilder.Entity<horario>()
                .HasMany(e => e.laboratorio)
                .WithRequired(e => e.horario)
                .HasForeignKey(e => e.HORARIO_id_horario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<horario>()
                .HasMany(e => e.seccion_curso)
                .WithOptional(e => e.horario)
                .HasForeignKey(e => e.horario_id);

            modelBuilder.Entity<laboratorio>()
                .Property(e => e.descripcion_laboratorio)
                .IsUnicode(false);

            modelBuilder.Entity<laboratorio>()
                .HasMany(e => e.seccion_curso)
                .WithOptional(e => e.laboratorio)
                .HasForeignKey(e => e.laboratorio_id);

            modelBuilder.Entity<pago>()
                .Property(e => e.tipo_pago)
                .IsUnicode(false);

            modelBuilder.Entity<pensum>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<pensum>()
                .HasMany(e => e.curso)
                .WithRequired(e => e.pensum)
                .HasForeignKey(e => e.PENSUM_id_pensum)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<perfil>()
                .Property(e => e.nombre_perfil)
                .IsUnicode(false);

            modelBuilder.Entity<perfil>()
                .Property(e => e.descripcion_perfil)
                .IsUnicode(false);

            modelBuilder.Entity<perfil>()
                .HasMany(e => e.usuario)
                .WithMany(e => e.perfil)
                .Map(m => m.ToTable("perfil_usuario", "mydb").MapLeftKey("PERFIL_id_perfil").MapRightKey("USUARIO_id_usuario"));

            modelBuilder.Entity<salon>()
                .Property(e => e.capacidad_salon)
                .IsUnicode(false);

            modelBuilder.Entity<salon>()
                .Property(e => e.nombre_salon)
                .IsUnicode(false);

            modelBuilder.Entity<salon>()
                .HasMany(e => e.laboratorio)
                .WithRequired(e => e.salon)
                .HasForeignKey(e => e.SALON_id_salon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<salon>()
                .HasMany(e => e.seccion_curso)
                .WithOptional(e => e.salon)
                .HasForeignKey(e => e.salon_id);

            modelBuilder.Entity<seccion_curso>()
                .Property(e => e.seccion_seccion)
                .IsUnicode(false);

            modelBuilder.Entity<seccion_curso>()
                .Property(e => e.estado_seccion)
                .IsUnicode(false);

            modelBuilder.Entity<seccion_curso>()
                .Property(e => e.ciclo)
                .IsUnicode(false);

            modelBuilder.Entity<seccion_curso>()
                .HasMany(e => e.curso_estudiante)
                .WithRequired(e => e.seccion_curso)
                .HasForeignKey(e => e.CURSO_id_curso)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.usuario_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.nombre_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.apellido_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.password_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.correo_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.telefono_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .HasMany(e => e.bitacora)
                .WithRequired(e => e.usuario)
                .HasForeignKey(e => e.usuario_id_usuario)
                .WillCascadeOnDelete(false);
        }
    }
}
