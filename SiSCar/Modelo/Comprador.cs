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
    [Table("Compradores")]
   public class Comprador
    {
        [Key]
        public int pkComprador { get; set; }

        [Required(ErrorMessage = "Nombre Requerido")]
        [StringLength(100)]
        public string cNombre { get; set; }

        [Required(ErrorMessage = "Direccion Requerida")]
        [StringLength(100)]
        public string cDireccion { get; set; }

        [Required(ErrorMessage = "Ciudad Requerida")]
        [StringLength(100)]
        public string cCiudad { get; set; }

        public Boolean cStatus { get; set; }

        public virtual ICollection<Venta> venta { get; set; }
        public Comprador()
        {
            this.cStatus = true;
        }
        public void guardar(Comprador nComprador)//Agregamos primero la funcion para guardar un nuevo cliente
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    if (nComprador.pkComprador > 0)
                    {
                        ctx.Entry(nComprador).State = EntityState.Modified;
                    }
                    else
                    {
                        ctx.Entry(nComprador).State = EntityState.Added;
                    }
                    ctx.SaveChanges();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }      
    }
}
