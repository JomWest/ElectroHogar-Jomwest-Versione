using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public partial class Empleados
    {
        public Empleados(string CedulaEmpleado, string NombreEmpleado, string ApellidoEmpleado, int TelefonoEmpleado  ,string UsuarioEmpleado, string ContraseñaEmpleado)
        {
            this.CedulaEmpleado = CedulaEmpleado;
            this.NombreEmpleado = NombreEmpleado;
            this.ApellidoEmpleado = ApellidoEmpleado;
            this.TelefonoEmpleado = TelefonoEmpleado;
            this.UsuarioEmpleado = UsuarioEmpleado;
            this.ContraseñaEmpleado = ContraseñaEmpleado;

        }
    }
}
