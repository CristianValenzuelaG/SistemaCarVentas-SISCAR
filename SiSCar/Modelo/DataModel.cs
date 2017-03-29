using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiSCar.Modelo
{
    class DataModel:DbContext
    {
        public DataModel() : base("DataModel")
        {

        }
        public virtual DbSet<Usuario> usuarios { get; set; }
        public virtual DbSet<Rol> roles { get; set; }
        public virtual DbSet<Permiso> permisos { get; set; }
        public virtual DbSet<PermisoNegadoRol> permisosnegadorol { get; set; }
        public virtual DbSet<Venta> ventas { get; set; }
        public virtual DbSet<Propietario> propietarios { get; set; }
        public virtual DbSet<Comprador> Compradores { get; set; }
        public virtual DbSet<Auto> autos { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
