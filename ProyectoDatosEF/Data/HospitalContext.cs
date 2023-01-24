using Microsoft.EntityFrameworkCore;
using ProyectoDatosEF.Models;

namespace ProyectoDatosEF.Data
{
    public class HospitalContext: DbContext
    {
        //Necesitamos un constructor obligatorio para recibir cadena conexion desde  program
        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options) { }

        //debemos mapear cada clase model de la bse de datos con un objeto DBSet. Cada tabla
        //de la base de datos sera un DbSet con un model y haremos las consultas a dicho DbSet
        public DbSet<Hospital> Hospitales { get; set; }
        public DbSet<Doctor> Doctores { get; set; }

        public DbSet<Plantilla> Plantillas { get; set; }

    }
}
