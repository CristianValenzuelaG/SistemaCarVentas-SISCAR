using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiSCar.Modelo;


namespace SiSCar.Controlador
{



        public class ManejoSesion
        {
            public static SessiononHelper Login(string User, string Password)
            {
                SessiononHelper objSession = new SessiononHelper();
                try
                {
                    using (var ctx = new DataModel())
                    {
                        Usuario user = ctx.usuarios.Include("rol")
                            .Include("rol.PermisosNegadoRol")
                            .Where(r => r.sEmail == User && r.bStatus == true).FirstOrDefault();

                        if (user != null)
                        {
                            if (user.sPassword == Password)
                            {
                                objSession.isValid = true;
                                objSession.usuario = user;
                            }

                        }
                    }
                    return objSession;
                }
                catch (Exception ex)
                {

                    throw;
                }
            }

            public class SessiononHelper
            {
                public Boolean isValid { get; set; }
                public Usuario usuario { get; set; }
                public string msgError { get; set; }

                public Boolean tienepermiso(int validarpermiso)
                {
                    Boolean tiene = false;

                    if (isValid)
                    {
                        try
                        {
                            using (var ctx = new DataModel())
                            {
                                PermisoNegadoRol pNegado =
                                    usuario.rol.permisosnegadorol.Where(r => r.pkPermisoNegadoRol
                                    == validarpermiso)
                                        .FirstOrDefault();
                                if (pNegado == null) tiene = true;

                            }
                            return tiene;
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                    }
                    else
                    {
                        return tiene;
                    }
                }

             
            }
        }
    public enum enumPermisoActivos
    {
        ventas = 1,
        Auto = 2,
        usuarios = 3,
        propietario = 4,
        comprador = 5,
        }
}
