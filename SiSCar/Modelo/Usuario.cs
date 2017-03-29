using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiSCar.Modelo
{
    [Table("Usuarios")]
    public class Usuario
    {
        #region Codigo de la bd
            
        [Key]
        public int pkUsuario { get; set; }

        [Required(ErrorMessage = "Se requiere Email")]
        [StringLength(100)]
        public String sEmail { get; set; }

        [Required(ErrorMessage = "Password Obligatorio")]
        [StringLength(140)]
        public String sPassword { get; set; }

        public Boolean bStatus { get; set; }

        public Usuario()
        {
            this.bStatus = true;
        }

        public virtual Rol rol { get; set; }
        #endregion

        public static List<Usuario> BuscarPorEmail(string valorBuscar, Boolean sStatus)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.usuarios.Where(r => r.sEmail.Contains(valorBuscar) && r.bStatus == sStatus).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Guardar(Usuario sUsuario)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    if (sUsuario.pkUsuario > 0)
                    {
                        ctx.Entry(sUsuario).State = EntityState.Modified;
                    }
                    else
                    {
                        ctx.Entry(sUsuario).State = EntityState.Added;
                    }
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Usuario> BuscarporID(int pkUsuario)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.usuarios.Where(r => r.pkUsuario == pkUsuario).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
