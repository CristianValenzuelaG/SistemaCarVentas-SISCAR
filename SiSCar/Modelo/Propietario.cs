using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiSCar.Modelo
{
    [Table("Propietarios")]
  public class Propietario
    {
        #region Datos de BD
        [Key]
        public int pkPropietario { get; set; }

        [Required(ErrorMessage = "Nombre Requerido")]
        [StringLength(50)]
        public string pNombre { get; set; }

        [Required(ErrorMessage = "Direccion Requerida")]
        [StringLength(50)]
        public string pDireccion{ get; set; }

        [Required(ErrorMessage = "Telefono Requerido")]
        [StringLength(50)]
        public string pTelefono { get; set; }

        [Required(ErrorMessage = "Correo Requerido")]
        [StringLength(50)]
        public string pCorreo { get; set; }

        [Required(ErrorMessage = "INE Requerida")]
        [StringLength(50)]
        public string pIfe { get; set; }

        [Required(ErrorMessage = "FotoPro Requerida")]
        [StringLength(50)]
        public string pFoto { get; set; }

        public Boolean pStatus { get; set; }
        public virtual ICollection<Auto> autos { get; set; }

        public Propietario()
        {
            this.pStatus = true;
        }
        #endregion

        public static List<Propietario> BuscarPorNombre(string valorBuscar, Boolean sStatus)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.propietarios.Where(r => r.pNombre.Contains(valorBuscar) && r.pStatus == sStatus).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Guardar(Propietario nPropietario)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    if (nPropietario.pkPropietario > 0)
                    {
                        ctx.propietarios.Attach(nPropietario);
                        ctx.Entry(nPropietario).State = EntityState.Modified;
                    }
                    else
                    {
                        ctx.Entry(nPropietario).State = EntityState.Added;
                        ctx.propietarios.Attach(nPropietario);
                    }
                    ctx.SaveChanges();
                   
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Propietario> BuscarporID(int pkPropietario)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.propietarios.Where(r => r.pkPropietario == pkPropietario).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Propietario> BuscarporID_Comprar(int pkPropietario)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.propietarios.Where(r => r.pkPropietario == pkPropietario).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //public void guardar(Propietario nPropietario, TipoOperacion tOperacion, int pkGrupo = 0)
        //{
        //    try
        //    {
        //        using (var ctx = new DataModel())
        //        {
        //            if (nPropietario.pkPropietario > 0)
        //            {
        //                ctx.Entry(nPropietario).State = EntityState.Modified;
        //            }
        //            else
        //            {
        //                ctx.Entry(nPropietario).State = EntityState.Added;
        //            }
        //            ctx.SaveChanges();
        //            if (tOperacion == TipoOperacion.NUEVO)
        //            {
        //                //TODO: REGISTRARLO EN EL GRUPO SELECCIONADO

        //                //SiSCar.Modelo.Auto.RegistrarNuevoAlumno(pkGrupo, nAlumno.pkAlumno);
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

    }
    //public enum TipoOperacion
    //{
    //    NUEVO,
    //    ACTUALIZACION
    //}
}
