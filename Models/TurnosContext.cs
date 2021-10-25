using Microsoft.EntityFrameworkCore;

namespace Turnos.Models{
    public class TurnosContext:DbContext
    {
        public TurnosContext(DbContextOptions<TurnosContext> opciones):base(opciones)
        {
            
        }
        public DbSet<Especialidad>Especialidad{get;set;}

        public DbSet<Paciente>Paciente{get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Especialidad>(entidad => {
                entidad.ToTable("Especialidad");
                entidad.HasKey(e=>e.IdEspecialidad);

                entidad.Property(e=> e.Descripcion)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);
            });

            modelBuilder.Entity<Paciente>(entidad=>{
                entidad.ToTable("Paciente");
                entidad.HasKey(e=>e.idPaciente);

                entidad.Property(e=>e.Nombre)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(true);

                entidad.Property(e=>e.Apellido)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(true);

                entidad.Property(e=>e.Direccion)
                .IsRequired()
                .HasMaxLength(80)
                .IsUnicode(true);

                entidad.Property(e=>e.Telefono)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(true);

                entidad.Property(e=>e.Email)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(true);
            });
        }
    }
}