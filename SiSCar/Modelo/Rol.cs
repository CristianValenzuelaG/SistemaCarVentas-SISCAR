using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiSCar.Modelo
{
    [Table("Roles")]
    public class Rol
    {
        #region Base Region
            
        [Key]
        public int pkRol { get; set; }

        [Required(ErrorMessage = "Se Requiere campo")]
        [StringLength(100)]
        public String sNombre { get; set; }

        public Boolean bStatus { get; set; }
        public Rol()
        {
            this.bStatus = true;
        }

        public virtual ICollection<Usuario> usuarios { get; set; }
        public virtual ICollection<PermisoNegadoRol> permisosnegadorol { get; set; }
        #endregion
        public static List<Rol> getAll(Boolean status)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.roles.Where(r => r.bStatus == status).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
