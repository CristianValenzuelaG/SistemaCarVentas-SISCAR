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
    [Table("Ventas")]
   public class Venta
    {
        #region Datos BD
        [Key]
        public int pkVenta { get; set; }
        public DateTime vFecha { get; set; }
        public int vTotal { get; set; }


        public int? comprador_fk { get; set; }
        public virtual Comprador compradores { get; set; }
        public int? auto_fk { get; set; }
        public virtual Auto autos { get; set; }
        #endregion

        public static List<Venta> BuscarporFecha(int pkVenta)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.ventas.Where(r => r.pkVenta == pkVenta).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void guardar(Venta nVenta)//Agregamos primero la funcion para guardar un nuevo cliente
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    if (nVenta.pkVenta > 0)
                    {
                        ctx.Entry(nVenta).State = EntityState.Modified;
                    }
                    else
                    {
                        ctx.Entry(nVenta).State = EntityState.Added;

                        
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
