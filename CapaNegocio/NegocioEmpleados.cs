using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;
using CapaEntidades;

namespace CapaNegocio
{
   public class NegocioEmpleados
    {
        ELECTROHOGAREntities db = new ELECTROHOGAREntities();


        public void NuevoUsuario(string CedulaEmpleado, string NombreEmpleado, string ApellidoEmpleado, int TelefonoEmpleado, string UsuarioEmpleado, string ContraseñaEmpleado)
        {
             using (db = new ELECTROHOGAREntities())
                {
                Empleados empleados = new Empleados();
                db.Empleados.Add(new Empleados(CedulaEmpleado, NombreEmpleado, ApellidoEmpleado, TelefonoEmpleado, UsuarioEmpleado, ContraseñaEmpleado));
                db.SaveChanges();
                }
       
        }

        public List<Empleados> LeerDatos()
        {
            try
            {
                using (db = new ELECTROHOGAREntities())
                {
                    var result = (from _Empleados in db.Empleados.OfType<Empleados>()
                                  select _Empleados).ToList();
                    return result;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}
