using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiSCar.Modelo
{
    [Table("Permisos")]
    public class Permiso
    {
        [Key]
        public int pkPermiso { get; set; }

        [Required(ErrorMessage = "Nombre del Modulo es requerido")]
        [StringLength(150)]
        public String sModulo { get; set; }

        [StringLength(240)]
        public String sDescripcion { get; set; }

        public virtual ICollection<PermisoNegadoRol> permisosnegadosrol { get; set; }
    }
}
